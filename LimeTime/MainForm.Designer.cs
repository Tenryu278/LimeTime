namespace LimeTime
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenButton = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.SaveAsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RegionLabel = new System.Windows.Forms.ToolStripLabel();
            this.RegionBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CreditsBtn = new System.Windows.Forms.ToolStripButton();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.TIDList = new System.Windows.Forms.ListBox();
            this.TIDLabel = new System.Windows.Forms.Label();
            this.PTMLabel = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.TitleName = new System.Windows.Forms.Label();
            this.FmtBtn1 = new System.Windows.Forms.RadioButton();
            this.FmtBtn2 = new System.Windows.Forms.RadioButton();
            this.FormatBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Delbtn = new System.Windows.Forms.Button();
            this.TIDBox = new System.Windows.Forms.ComboBox();
            this.TIDSupportlab = new System.Windows.Forms.Label();
            this.CreateLabel = new System.Windows.Forms.Label();
            this.TitledbButton = new System.Windows.Forms.Button();
            this.TimeSuportlab = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.FormatBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenButton,
            this.SaveButton,
            this.SaveAsButton,
            this.toolStripSeparator1,
            this.RegionLabel,
            this.RegionBox,
            this.toolStripSeparator2,
            this.CreditsBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(610, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenButton
            // 
            this.OpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(60, 33);
            this.OpenButton.Text = "Open";
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveButton.Enabled = false;
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(53, 33);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveAsButton.Enabled = false;
            this.SaveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(75, 33);
            this.SaveAsButton.Text = "Save as";
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // RegionLabel
            // 
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(67, 33);
            this.RegionLabel.Text = "region:";
            // 
            // RegionBox
            // 
            this.RegionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegionBox.Items.AddRange(new object[] {
            "EUR",
            "USA",
            "JPN",
            "KRA",
            "TWN"});
            this.RegionBox.Name = "RegionBox";
            this.RegionBox.Size = new System.Drawing.Size(100, 38);
            this.RegionBox.SelectedIndexChanged += new System.EventHandler(this.RegionBox_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // CreditsBtn
            // 
            this.CreditsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CreditsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreditsBtn.Name = "CreditsBtn";
            this.CreditsBtn.Size = new System.Drawing.Size(66, 33);
            this.CreditsBtn.Text = "About";
            this.CreditsBtn.Click += new System.EventHandler(this.CreditsBtn_Click);
            // 
            // HelpLabel
            // 
            this.HelpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Location = new System.Drawing.Point(12, 38);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(166, 18);
            this.HelpLabel.TabIndex = 1;
            this.HelpLabel.Text = "Where play_time.bin ?";
            // 
            // TIDList
            // 
            this.TIDList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TIDList.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TIDList.FormattingEnabled = true;
            this.TIDList.ItemHeight = 20;
            this.TIDList.Location = new System.Drawing.Point(12, 123);
            this.TIDList.Name = "TIDList";
            this.TIDList.Size = new System.Drawing.Size(233, 264);
            this.TIDList.TabIndex = 2;
            this.TIDList.SelectedIndexChanged += new System.EventHandler(this.TIDList_SelectedIndexChanged);
            // 
            // TIDLabel
            // 
            this.TIDLabel.AutoSize = true;
            this.TIDLabel.Location = new System.Drawing.Point(268, 142);
            this.TIDLabel.Name = "TIDLabel";
            this.TIDLabel.Size = new System.Drawing.Size(58, 18);
            this.TIDLabel.TabIndex = 4;
            this.TIDLabel.Text = "TitleID";
            // 
            // PTMLabel
            // 
            this.PTMLabel.AutoSize = true;
            this.PTMLabel.Location = new System.Drawing.Point(251, 207);
            this.PTMLabel.Name = "PTMLabel";
            this.PTMLabel.Size = new System.Drawing.Size(78, 18);
            this.PTMLabel.TabIndex = 5;
            this.PTMLabel.Text = "PlayTime";
            // 
            // TimeBox
            // 
            this.TimeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeBox.Enabled = false;
            this.TimeBox.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimeBox.Location = new System.Drawing.Point(332, 202);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(266, 27);
            this.TimeBox.TabIndex = 6;
            this.TimeBox.GotFocus += new System.EventHandler(this.TimeBox_GotFocus);
            this.TimeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeBox_KeyPress);
            this.TimeBox.LostFocus += new System.EventHandler(this.TimeBox_LostFocus);
            // 
            // TitleName
            // 
            this.TitleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TitleName.Location = new System.Drawing.Point(250, 85);
            this.TitleName.Name = "TitleName";
            this.TitleName.Size = new System.Drawing.Size(313, 49);
            this.TitleName.TabIndex = 7;
            this.TitleName.Text = "Unknown";
            this.TitleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FmtBtn1
            // 
            this.FmtBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FmtBtn1.AutoSize = true;
            this.FmtBtn1.Checked = true;
            this.FmtBtn1.Location = new System.Drawing.Point(6, 24);
            this.FmtBtn1.Name = "FmtBtn1";
            this.FmtBtn1.Size = new System.Drawing.Size(137, 22);
            this.FmtBtn1.TabIndex = 9;
            this.FmtBtn1.TabStop = true;
            this.FmtBtn1.Text = "y/d/hh:mm:ss";
            this.FmtBtn1.UseVisualStyleBackColor = true;
            this.FmtBtn1.CheckedChanged += new System.EventHandler(this.FmtBtn1_CheckedChanged);
            // 
            // FmtBtn2
            // 
            this.FmtBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FmtBtn2.AutoSize = true;
            this.FmtBtn2.Location = new System.Drawing.Point(6, 77);
            this.FmtBtn2.Name = "FmtBtn2";
            this.FmtBtn2.Size = new System.Drawing.Size(141, 22);
            this.FmtBtn2.TabIndex = 10;
            this.FmtBtn2.Text = "SecoundsOnly";
            this.FmtBtn2.UseVisualStyleBackColor = true;
            this.FmtBtn2.CheckedChanged += new System.EventHandler(this.FmtBtn2_CheckedChanged);
            // 
            // FormatBox
            // 
            this.FormatBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormatBox.Controls.Add(this.FmtBtn1);
            this.FormatBox.Controls.Add(this.FmtBtn2);
            this.FormatBox.Enabled = false;
            this.FormatBox.Location = new System.Drawing.Point(336, 310);
            this.FormatBox.Name = "FormatBox";
            this.FormatBox.Size = new System.Drawing.Size(202, 117);
            this.FormatBox.TabIndex = 11;
            this.FormatBox.TabStop = false;
            this.FormatBox.Text = "Format";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(12, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(516, 25);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "\"C:\\Users\\{UserName}\\AppData\\Roaming\\Citra\\log\\play_time.bin\"\r\n";
            this.textBox1.Click += new System.EventHandler(this.PathBox_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Addbtn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Addbtn.Location = new System.Drawing.Point(12, 393);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(84, 34);
            this.Addbtn.TabIndex = 13;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Delbtn
            // 
            this.Delbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delbtn.Enabled = false;
            this.Delbtn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Delbtn.Location = new System.Drawing.Point(161, 393);
            this.Delbtn.Name = "Delbtn";
            this.Delbtn.Size = new System.Drawing.Size(84, 34);
            this.Delbtn.TabIndex = 14;
            this.Delbtn.Text = "Delete";
            this.Delbtn.UseVisualStyleBackColor = true;
            this.Delbtn.Click += new System.EventHandler(this.Delbtn_Click);
            // 
            // TIDBox
            // 
            this.TIDBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TIDBox.Enabled = false;
            this.TIDBox.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TIDBox.Location = new System.Drawing.Point(332, 137);
            this.TIDBox.MaxLength = 16;
            this.TIDBox.Name = "TIDBox";
            this.TIDBox.Size = new System.Drawing.Size(266, 28);
            this.TIDBox.TabIndex = 15;
            this.TIDBox.SelectedIndexChanged += new System.EventHandler(this.TIDBox_SelectedIndexChanged);
            this.TIDBox.TextChanged += new System.EventHandler(this.TIDBox_TextChanged);
            this.TIDBox.GotFocus += new System.EventHandler(this.TIDBox_GotFocus);
            this.TIDBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TIDBox_KeyPress);
            this.TIDBox.LostFocus += new System.EventHandler(this.TIDBox_LostFocus);
            // 
            // TIDSupportlab
            // 
            this.TIDSupportlab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TIDSupportlab.AutoSize = true;
            this.TIDSupportlab.Location = new System.Drawing.Point(485, 168);
            this.TIDSupportlab.Name = "TIDSupportlab";
            this.TIDSupportlab.Size = new System.Drawing.Size(113, 18);
            this.TIDSupportlab.TabIndex = 16;
            this.TIDSupportlab.Text = "HexOnly 0/16";
            this.TIDSupportlab.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CreateLabel
            // 
            this.CreateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateLabel.AutoSize = true;
            this.CreateLabel.Location = new System.Drawing.Point(23, 351);
            this.CreateLabel.Name = "CreateLabel";
            this.CreateLabel.Size = new System.Drawing.Size(92, 36);
            this.CreateLabel.TabIndex = 17;
            this.CreateLabel.Text = "CreateNew\r\n↓";
            // 
            // TitledbButton
            // 
            this.TitledbButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TitledbButton.Enabled = false;
            this.TitledbButton.Location = new System.Drawing.Point(569, 108);
            this.TitledbButton.Name = "TitledbButton";
            this.TitledbButton.Size = new System.Drawing.Size(29, 26);
            this.TitledbButton.TabIndex = 18;
            this.TitledbButton.Text = "...";
            this.TitledbButton.UseVisualStyleBackColor = true;
            this.TitledbButton.Click += new System.EventHandler(this.TitledbButton_Click);
            // 
            // TimeSuportlab
            // 
            this.TimeSuportlab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeSuportlab.Location = new System.Drawing.Point(436, 232);
            this.TimeSuportlab.Name = "TimeSuportlab";
            this.TimeSuportlab.Size = new System.Drawing.Size(162, 18);
            this.TimeSuportlab.TabIndex = 19;
            this.TimeSuportlab.Text = "Num and Colon Only";
            this.TimeSuportlab.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(610, 439);
            this.Controls.Add(this.TimeSuportlab);
            this.Controls.Add(this.TitledbButton);
            this.Controls.Add(this.CreateLabel);
            this.Controls.Add(this.TIDSupportlab);
            this.Controls.Add(this.TIDBox);
            this.Controls.Add(this.Delbtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FormatBox);
            this.Controls.Add(this.TitleName);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.PTMLabel);
            this.Controls.Add(this.TIDLabel);
            this.Controls.Add(this.TIDList);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "LimeTime";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.FormatBox.ResumeLayout(false);
            this.FormatBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenButton;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.ListBox TIDList;
        private System.Windows.Forms.Label TIDLabel;
        private System.Windows.Forms.Label PTMLabel;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Label TitleName;
        private System.Windows.Forms.RadioButton FmtBtn1;
        private System.Windows.Forms.RadioButton FmtBtn2;
        private System.Windows.Forms.GroupBox FormatBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripButton SaveAsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox RegionBox;
        private System.Windows.Forms.ToolStripLabel RegionLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton CreditsBtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Delbtn;
        private System.Windows.Forms.ComboBox TIDBox;
        private System.Windows.Forms.Label TIDSupportlab;
        private System.Windows.Forms.Label CreateLabel;
        private System.Windows.Forms.Button TitledbButton;
        private System.Windows.Forms.Label TimeSuportlab;
    }
}

