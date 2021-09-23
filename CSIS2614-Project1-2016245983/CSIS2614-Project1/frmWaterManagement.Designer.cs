namespace CSIS2614_Project1
{
    partial class CfrmWaterManagement
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
            this.mnustrpWaterManagement = new System.Windows.Forms.MenuStrip();
            this.dcbhmfgvjhgvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usageReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nvKhKhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelsPerMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kjlkHkHJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picWater = new System.Windows.Forms.PictureBox();
            this.mnustrpWaterManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).BeginInit();
            this.SuspendLayout();
            // 
            // mnustrpWaterManagement
            // 
            this.mnustrpWaterManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dcbhmfgvjhgvToolStripMenuItem,
            this.nvKhKhToolStripMenuItem,
            this.kjlkHkHJToolStripMenuItem});
            this.mnustrpWaterManagement.Location = new System.Drawing.Point(0, 0);
            this.mnustrpWaterManagement.Name = "mnustrpWaterManagement";
            this.mnustrpWaterManagement.Size = new System.Drawing.Size(365, 24);
            this.mnustrpWaterManagement.TabIndex = 1;
            this.mnustrpWaterManagement.Text = "menuStrip2";
            // 
            // dcbhmfgvjhgvToolStripMenuItem
            // 
            this.dcbhmfgvjhgvToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem,
            this.usageReportToolStripMenuItem});
            this.dcbhmfgvjhgvToolStripMenuItem.Name = "dcbhmfgvjhgvToolStripMenuItem";
            this.dcbhmfgvjhgvToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.dcbhmfgvjhgvToolStripMenuItem.Text = "Households";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // usageReportToolStripMenuItem
            // 
            this.usageReportToolStripMenuItem.Name = "usageReportToolStripMenuItem";
            this.usageReportToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.usageReportToolStripMenuItem.Text = "Usage report";
            this.usageReportToolStripMenuItem.Click += new System.EventHandler(this.usageReportToolStripMenuItem_Click);
            // 
            // nvKhKhToolStripMenuItem
            // 
            this.nvKhKhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelsToolStripMenuItem,
            this.levelsPerMonthToolStripMenuItem});
            this.nvKhKhToolStripMenuItem.Name = "nvKhKhToolStripMenuItem";
            this.nvKhKhToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.nvKhKhToolStripMenuItem.Text = "Restrictions";
            // 
            // levelsToolStripMenuItem
            // 
            this.levelsToolStripMenuItem.Name = "levelsToolStripMenuItem";
            this.levelsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.levelsToolStripMenuItem.Text = "Levels";
            this.levelsToolStripMenuItem.Click += new System.EventHandler(this.levelsToolStripMenuItem_Click);
            // 
            // levelsPerMonthToolStripMenuItem
            // 
            this.levelsPerMonthToolStripMenuItem.Name = "levelsPerMonthToolStripMenuItem";
            this.levelsPerMonthToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.levelsPerMonthToolStripMenuItem.Text = "Levels per month";
            this.levelsPerMonthToolStripMenuItem.Click += new System.EventHandler(this.levelsPerMonthToolStripMenuItem_Click);
            // 
            // kjlkHkHJToolStripMenuItem
            // 
            this.kjlkHkHJToolStripMenuItem.Name = "kjlkHkHJToolStripMenuItem";
            this.kjlkHkHJToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.kjlkHkHJToolStripMenuItem.Text = "About";
            this.kjlkHkHJToolStripMenuItem.Click += new System.EventHandler(this.kjlkHkHJToolStripMenuItem_Click);
            // 
            // picWater
            // 
            this.picWater.Image = global::CSIS2614_Project1.Properties.Resources.images;
            this.picWater.Location = new System.Drawing.Point(25, 46);
            this.picWater.Name = "picWater";
            this.picWater.Size = new System.Drawing.Size(317, 272);
            this.picWater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWater.TabIndex = 2;
            this.picWater.TabStop = false;
            // 
            // CfrmWaterManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 353);
            this.Controls.Add(this.picWater);
            this.Controls.Add(this.mnustrpWaterManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CfrmWaterManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WATER MANAGEMENT";
            this.mnustrpWaterManagement.ResumeLayout(false);
            this.mnustrpWaterManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnustrpWaterManagement;
        private System.Windows.Forms.ToolStripMenuItem dcbhmfgvjhgvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nvKhKhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kjlkHkHJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usageReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelsPerMonthToolStripMenuItem;
        private System.Windows.Forms.PictureBox picWater;
    }
}

