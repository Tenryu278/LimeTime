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
        public TitleListForm(string tilteID, string region)
        {
            InitializeComponent();
            string[] parameters = new string[] { "Name", "UID", "Version", "Size", "Product Code", "Publisher" };
            string[] values = TitleList.GetFrom("TitleID", tilteID, parameters);
            if (values != null )
                TitleTextBox.Text = values[0];

            RegionLabel.Text = region;

            object[] items = TitleList.GetColumn("Name");
            TitleListBox.Items.AddRange(items);
        }

        private void ChangeTitle(string TitleName) 
        {
            TitleTextBox.Text = TitleName;
            string[] parameters = new string[] { "TitleID"};
            TitleList.GetFrom("Name", "Shovel Software Insurance Claim", parameters);
        }

        private void TitleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTitle(TitleListBox.SelectedItem.ToString());
        }

        private void TitleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
