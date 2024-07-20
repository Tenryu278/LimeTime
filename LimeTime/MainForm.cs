using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace LimeTime
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();

            RegionBox.SelectedIndex = 0;
            TIDSupportlab.Text = $"HexOnly 0/{TIDBox.MaxLength}";
            TimeSuportlab.Text = "Num and Colon Only";
            this.FormClosing += Form_FormClosing;
        }

        /// <summary>
        /// タイトルIDとプレイ時間の<see cref="Dictionary{TKey, TValue}"/>
        /// This dictionary haves pairs of title ID and playtime
        /// </summary>
        Dictionary<string, ulong> dic = new Dictionary<string, ulong>();

        readonly string filt = "Lime3DS play_time | *.bin";

        string fpath;

        bool editing = false;

        private void OpenButton_Click(object sender, EventArgs e)
        {
            var f = new OpenFileDialog()
            {
                Filter = filt
            };
            if (f.ShowDialog() == DialogResult.OK) 
            {
                dic.Clear();
                TIDList.Items.Clear();

                fpath = f.FileName;
                dic = ReadData(fpath);
                foreach(var pair in dic) 
                    TIDList.Items.Add(pair.Key);

                TIDList.SetSelected(0, true);
                StartUp();
            }
        }

        /// <summary>
        /// ファイルを開くか新規作成したときに実行
        /// </summary>
        private void StartUp() 
        {
            if(fpath != null)
                SaveButton.Enabled = true;

            SaveAsButton.Enabled = true;
            CreateLabel.Visible = false;
        }

        /// <summary>
        /// <paramref name="path"/>で指定されたファイルからタイトルIDとプレイ時間を読み取ります
        /// Read titleID and play time from <paramref name="path"/>.
        /// </summary>
        /// <param name="path">file path</param>
        /// <returns>タイトルIDとプレイ時間の<see cref="Dictionary{TKey, TValue}"/>  pairs of titleID and play time in Dictionary.</returns>
        private Dictionary<string,ulong> ReadData(string path) 
        {
            Dictionary<string, ulong> result = new Dictionary<string, ulong>();

            using (var data = new FileStream(path, FileMode.Open)) 
            {
                var bin = new BinaryReader(data);
                while (data.Position < data.Length) 
                {
                    string id = "";
                    byte[] tid = bin.ReadBytes(8);
                    Array.Reverse(tid);
                    foreach (var ti in tid)
                    {
                        id += $"{ti:X2}";
                    }

                    ulong ptm = bin.ReadUInt64();
                    result.Add(id, ptm);
                }
            }
            return result;
        }

        private void Form_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e) => editing = false;

        private void TIDList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TIDList.SelectedItem == null) //if not selected
            {
                TIDBox.Enabled = false;
                TimeBox.Enabled = false;
                FormatBox.Enabled = false;
                Delbtn.Enabled = false;
                TitledbButton.Enabled = false;
                TIDBox.Text = "";
                TimeBox.Text = "";
                TitleName.Text = "Unknown";
                return;
            }
            if (!editing) //if selected and not editing
            {
                TIDBox.Enabled = true;
                TimeBox.Enabled = true;
                FormatBox.Enabled = true;
                Delbtn.Enabled = true;
                TitledbButton.Enabled = true;
                TIDBox.Text  = TIDList.SelectedItem.ToString();
                SetFormat();
                TitleName.Text = TitleList.GetFrom(TIDList.SelectedItem.ToString(), "Name");
                if (TitleName.Text == String.Empty)
                    TitleName.Text = "Unknown";
            }
        }

        private void RegionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!File.Exists("Newtonsoft.Json.dll"))
            {
                MessageBox.Show(@"""Newtonsoft.Json.dll"" is not exist, couldn't get title names!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RegionBox.Enabled = false;
                return;
            }
            TitleList titleList = new TitleList();
            titleList.Region = RegionBox.SelectedItem.ToString();

            TIDBox.Items.Clear();
            object[] items = TitleList.GetColumn("TitleID");
            TIDBox.Items.AddRange(items);

            TIDList_SelectedIndexChanged(null,null); //ChangeTitleLabel
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (editing)
                return;

            string emtID = "0004000000000000";
            ulong u = ulong.Parse(emtID , System.Globalization.NumberStyles.HexNumber);

            while (dic.ContainsKey(emtID)) //OPTIMIZE:
            {
                u++;
                emtID = "";

                byte[] ubytes = BitConverter.GetBytes(u);
                Array.Reverse(ubytes);
                foreach (byte b in ubytes)
                    emtID += $"{b:X2}";
            }
            dic.Add(emtID, 0);

            TIDList.Items.Add(emtID);
            TIDList.Refresh();
            TIDList.SetSelected(TIDList.Items.IndexOf(emtID), true);
            StartUp();
        }

        private void Delbtn_Click(object sender, EventArgs e)
        {
            if (editing) 
                return;

            if (TIDList.SelectedItem != null)
            {
                dic.Remove(TIDList.SelectedItem.ToString());

                int index = TIDList.Items.IndexOf(TIDList.SelectedItem);
                TIDList.Items.Remove(TIDList.SelectedItem);
                TIDList.Refresh();
                if(index > 0) //if == 0, can't select item
                    TIDList.SetSelected(index - 1, true);
            }
        }

        private void TitledbButton_Click(object sender, EventArgs e)
        {
            var dlg = new TitleListForm(TIDList.SelectedItem.ToString(), RegionBox.SelectedItem.ToString());
            string result = dlg.ShowAndGetDialog();

            if (result != TIDBox.Text)
            {
                editing = true;
                TIDBox.Text = result;
                TIDSave();
            }
        }

        private void CreditsBtn_Click(object sender, EventArgs e)
        {
            var dlg = new Credits();
            dlg.ShowDialog();
        }

        private void PathBox_Click(object sender, EventArgs e) => textBox1.SelectAll();

        private void FmtBtn1_CheckedChanged(object sender, EventArgs e) => SetFormat();

        private void FmtBtn2_CheckedChanged(object sender, EventArgs e) => SetFormat();

        /// <summary>
        /// Check a format and set time for <see cref="TimeBox"/>. 
        /// Also use when correcting text of <see cref="TimeBox"/>. 
        /// </summary>
        private void SetFormat() 
        {
            ulong current = dic[TIDList.SelectedItem.ToString()];
            if (FmtBtn1.Checked)
            {
                string[] time = UlongToTime(current);
                TimeBox.Text = $"{time[0]}:{time[1]}:{time[2]}:{time[3]}:{time[4]}";
                TimeBox.MaxLength = 32767;

                TimeSuportlab.Text = "Num and Colon Only";
            }
            else if (FmtBtn2.Checked) 
            {
                TimeBox.Text = current.ToString();
                TimeBox.MaxLength = ulong.MaxValue.ToString().Length;

                TimeSuportlab.Text = "Num Only";
            }
        }

        #region TIDBox

        private void TIDBox_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            //Hex check
            else if(e.KeyChar >= 'a' && e.KeyChar <= 'f' || e.KeyChar >= 'A' && e.KeyChar <= 'F' || e.KeyChar >= '0' && e.KeyChar <= '9')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void TIDBox_TextChanged(object sender, EventArgs e)
        {
            if(TIDBox.Text.Length > TIDBox.MaxLength) 
            {
                TIDBox.Text = TIDBox.Text.Remove(TIDBox.MaxLength);
            }

            TIDSupportlab.Text = $"HexOnly {TIDBox.Text.Length}/{TIDBox.MaxLength}";
        }

        private void TIDBox_SelectedIndexChanged(object sender, EventArgs e) => TIDSave();

        private void TIDBox_GotFocus(object sender, EventArgs e) => editing = true;

        private void TIDBox_LostFocus(object sender, EventArgs e) => TIDSave();

        private void TIDSave() 
        {
            //FIXME:再フォーカスされたとき、イベントが発生しない
            //
            //TODO:エラー時に再フォーカスしつつ、上の問題を解決
            if (editing)
            {
                string old = TIDList.SelectedItem.ToString();

                if (TIDBox.Text.Length != TIDBox.MaxLength) //ErrorCheck: Is format correct?
                {
                    MessageBox.Show("The TitleID must be 16 characters!", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TIDBox.Text = old;
                    //TIDBox.Focus();
                    editing = false;
                    return;
                }

                TIDBox.Text = TIDBox.Text.ToUpper();

                if (dic.ContainsKey(TIDBox.Text) && TIDBox.Text != old)  //ErrorCheck: Is Title already in dic?
                {
                    MessageBox.Show("This title is already in data!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TIDBox.Text = old;
                    //TIDBox.Focus();
                    editing = false;
                    return;
                }

                ulong val = dic[old];
                dic.Remove(old);
                dic.Add(TIDBox.Text, val);

                int index = TIDList.SelectedIndex;

                editing = false;
                TIDList.Items[index] = TIDBox.Text;
            }
        }

        #endregion
        #region TimeBox

        private void TimeBox_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (FmtBtn1.Checked)
            {
                if (e.KeyChar == (char)Keys.Back)
                    e.Handled = false;
                else if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ':')
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            else if (FmtBtn2.Checked)
            {
                if(e.KeyChar == (char)Keys.Back)
                    e.Handled = false;
                else if(e.KeyChar >= '0' && e.KeyChar <= '9') 
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void TimeBox_GotFocus(object sender, EventArgs e) => editing = true;

        private void TimeBox_LostFocus(object sender, EventArgs e) 
        {
            if (editing) 
            {
                if (FmtBtn1.Checked)
                {
                    string[] time = TimeBox?.Text.Split(':');
                    if (time.Length != 5) //ErrorCheck: Is format correct?
                    {
                        MessageBox.Show("The play time is not valid.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        SetFormat(); //Undo text without saving
                        TimeBox.Focus(); 
                        return;
                    }
                    ulong edited = TimeToUlong(time);
                    dic[TIDList.SelectedItem.ToString()] = edited;

                    SetFormat();
                    editing = false;

                }
                else if (FmtBtn2.Checked)
                {
                    try
                    {
                        ulong edited = ulong.Parse(TimeBox?.Text);
                        dic[TIDList.SelectedItem.ToString()] = edited;
                        editing = false;
                    }
                    catch(OverflowException)
                    {
                        MessageBox.Show($"The play time must be below {ulong.MaxValue} seconds!", "OverFlow", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TimeBox.Text = ulong.MaxValue.ToString();
                        TimeBox.Focus();
                    }
                    catch (FormatException) 
                    {
                        MessageBox.Show("The Format is wrong. Enter seconds as integer.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TimeBox.Text = "0";
                        TimeBox.Focus();
                    }
                    catch (ArgumentNullException) 
                    {
                        MessageBox.Show("Enter seconds as integer.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TimeBox.Text = "0";
                        TimeBox.Focus();
                    }
                }
            }
        }

        #endregion

        private void SaveButton_Click(object sender, EventArgs e) => WriteData(fpath);

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            var f = new SaveFileDialog() 
            {
                Filter = filt,
                FileName = "play_time.bin"
            };
            if(f.ShowDialog() == DialogResult.OK) 
            {
                WriteData(f.FileName);

                if(fpath == null)
                {
                    fpath = f.FileName;
                    SaveButton.Enabled = true;
                }
            }
        }

        private void WriteData(string path) 
        {
            using (var data = new FileStream(path, FileMode.Create)) 
            {
                var bin = new BinaryWriter(data);
                foreach(var pair in dic) 
                {
                    ulong idnum = ulong.Parse(pair.Key, System.Globalization.NumberStyles.HexNumber);
                    byte[] tid = BitConverter.GetBytes(idnum);
                    bin.Write(tid);

                    byte[] ptm = BitConverter.GetBytes(pair.Value);
                    bin.Write(ptm);
                }
            }
            MessageBox.Show("Done!");
        }

        private string[] UlongToTime(ulong seconds)
        {
            ulong sec = seconds % 60;
            ulong mins = seconds / 60;

            ulong min = mins % 60;
            ulong hors = mins / 60;

            ulong hour = hors % 24;
            ulong days = hors / 24;

            ulong day = days % 365;
            ulong year = days / 365;

            string[] time = new string[] { year.ToString(), day.ToString(), hour.ToString("00"), min.ToString("00"), sec.ToString("00") };

            return time;
        }

        private ulong TimeToUlong(string[] time)
        {
            try
            {
                ulong year = ulong.Parse(time[0]);
                ulong day = ulong.Parse(time[1]);
                ulong hour = ulong.Parse(time[2]);
                ulong min = ulong.Parse(time[3]);
                ulong sec = ulong.Parse(time[4]);

                ulong days = year * 365 + day;
                ulong hours = days * 24 + hour;
                ulong mins = hours * 60 + min;
                ulong seconds = mins * 60 + sec;

                return seconds;
            }
            catch (OverflowException)
            {
                MessageBox.Show($"The play time must be below {ulong.MaxValue} seconds!", "OverFlow", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return ulong.MaxValue;
            }
        }
    }
}
