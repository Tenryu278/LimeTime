using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimeTime
{
    public partial class TitleListForm : Form
    {
        object[] names;

        public TitleListForm(string tilteID, string region)
        {
            InitializeComponent();

            RegionLabel.Text = region;
            TitleIDBox.Text = tilteID;

            names = TitleList.GetColumn("Name");
            TitleListBox.Items.AddRange(names);

            string[] parameters = new string[] { "Name", "UID", "Version", "Size", "Product Code", "Publisher" };
            string[] values = TitleList.GetFrom("TitleID", tilteID, parameters);
            if (values != null )
                TitleTextBox.Text = values[0];
        }

        private void ChangeTitle(int TitleIndex) 
        {
            string[] parameters = new string[]{ "TitleID", "UID", "Version", "Size", "Product Code", "Publisher" };
            object[] vals = TitleList.GetRowObjects(TitleIndex, parameters);

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
