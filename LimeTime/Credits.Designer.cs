namespace LimeTime
{
    partial class Credits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logo = new System.Windows.Forms.PictureBox();
            this.AppTitle = new System.Windows.Forms.Label();
            this.githubLabel = new System.Windows.Forms.LinkLabel();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.creditsBox = new System.Windows.Forms.GroupBox();
            this.label3dsdb = new System.Windows.Forms.LinkLabel();
            this.lime3ds = new System.Windows.Forms.LinkLabel();
            this.thx2 = new System.Windows.Forms.Label();
            this.thx1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.creditsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = global::LimeTime.Properties.Resources.LimeTime;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(136, 136);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // AppTitle
            // 
            this.AppTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppTitle.AutoSize = true;
            this.AppTitle.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AppTitle.Location = new System.Drawing.Point(236, 12);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(185, 40);
            this.AppTitle.TabIndex = 1;
            this.AppTitle.Text = "LimeTime";
            this.AppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // githubLabel
            // 
            this.githubLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.githubLabel.AutoSize = true;
            this.githubLabel.Location = new System.Drawing.Point(274, 52);
            this.githubLabel.Name = "githubLabel";
            this.githubLabel.Size = new System.Drawing.Size(98, 18);
            this.githubLabel.TabIndex = 2;
            this.githubLabel.TabStop = true;
            this.githubLabel.Text = "Open github";
            this.githubLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLabel_LinkClicked);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.VersionLabel.Location = new System.Drawing.Point(427, 25);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(85, 24);
            this.VersionLabel.TabIndex = 3;
            this.VersionLabel.Text = "Version";
            // 
            // creditsBox
            // 
            this.creditsBox.Controls.Add(this.thx1);
            this.creditsBox.Controls.Add(this.thx2);
            this.creditsBox.Controls.Add(this.lime3ds);
            this.creditsBox.Controls.Add(this.label3dsdb);
            this.creditsBox.Location = new System.Drawing.Point(175, 92);
            this.creditsBox.Name = "creditsBox";
            this.creditsBox.Size = new System.Drawing.Size(318, 169);
            this.creditsBox.TabIndex = 4;
            this.creditsBox.TabStop = false;
            this.creditsBox.Text = "Thaks for :";
            // 
            // label3dsdb
            // 
            this.label3dsdb.AutoSize = true;
            this.label3dsdb.Location = new System.Drawing.Point(65, 38);
            this.label3dsdb.Name = "label3dsdb";
            this.label3dsdb.Size = new System.Drawing.Size(52, 18);
            this.label3dsdb.TabIndex = 0;
            this.label3dsdb.TabStop = true;
            this.label3dsdb.Text = "3dsdb";
            this.label3dsdb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label3dsdb_LinkClicked);
            // 
            // lime3ds
            // 
            this.lime3ds.AutoSize = true;
            this.lime3ds.Location = new System.Drawing.Point(53, 108);
            this.lime3ds.Name = "lime3ds";
            this.lime3ds.Size = new System.Drawing.Size(76, 18);
            this.lime3ds.TabIndex = 1;
            this.lime3ds.TabStop = true;
            this.lime3ds.Text = "Lime3DS";
            this.lime3ds.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lime3ds_LinkClicked);
            // 
            // thx2
            // 
            this.thx2.AutoSize = true;
            this.thx2.Location = new System.Drawing.Point(135, 108);
            this.thx2.Name = "thx2";
            this.thx2.Size = new System.Drawing.Size(89, 18);
            this.thx2.TabIndex = 2;
            this.thx2.Text = "developers";
            // 
            // thx1
            // 
            this.thx1.AutoSize = true;
            this.thx1.Location = new System.Drawing.Point(135, 38);
            this.thx1.Name = "thx1";
            this.thx1.Size = new System.Drawing.Size(95, 18);
            this.thx1.TabIndex = 3;
            this.thx1.Text = "3ds title list";
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(524, 290);
            this.Controls.Add(this.creditsBox);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.githubLabel);
            this.Controls.Add(this.AppTitle);
            this.Controls.Add(this.logo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Credits";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credits";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.creditsBox.ResumeLayout(false);
            this.creditsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label AppTitle;
        private System.Windows.Forms.LinkLabel githubLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.GroupBox creditsBox;
        private System.Windows.Forms.Label thx1;
        private System.Windows.Forms.Label thx2;
        private System.Windows.Forms.LinkLabel lime3ds;
        private System.Windows.Forms.LinkLabel label3dsdb;
    }
}