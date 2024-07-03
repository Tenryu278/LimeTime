using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimeTime
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
            VersionLabel.Text = Application.ProductVersion;
            AppTitle.Text = Application.ProductName;
        }

        private void githubLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Tenryu278/LimeTime");
        }

        private void label3dsdb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/hax0kartik/3dsdb");
        }

        private void lime3ds_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Lime3DS/Lime3DS");
        }
    }
}
