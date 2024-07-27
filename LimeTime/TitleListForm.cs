using System;
using System.Windows.Forms;

namespace LimeTime
{
    public partial class TitleListForm : Form
    {
        object[] names;

        TitleList t;

        public TitleListForm(string tilteID, TitleList titleList)
        {
            InitializeComponent();
            t = titleList;

            RegionLabel.Text = t.Region.ToString();
            TitleIDBox.Text = tilteID;

            names = t.GetColumn("Name");
            TitleListBox.Items.AddRange(names);

            string[] parameters = new string[] { "Name", "UID", "Version", "Size", "Product Code", "Publisher" };
            string[] values = t.GetFrom("TitleID", tilteID, parameters);
            if (values != null )
                TitleTextBox.Text = values[0];
        }

        private void ChangeTitle(int TitleIndex) 
        {
            string[] parameters = new string[]{ "TitleID", "UID", "Version", "Size", "Product Code", "Publisher" };
            object[] vals = t.GetRowObjects(TitleIndex, parameters);

            TitleTextBox.Text = names[TitleIndex].ToString();
            TitleIDBox.Text = vals[0].ToString();
        }

        private void TitleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTitle(TitleListBox.SelectedIndex);
        }

        public string ShowAndGetDialog()
        {
            ShowDialog();
            return TitleIDBox.Text;
        }
    }
}
