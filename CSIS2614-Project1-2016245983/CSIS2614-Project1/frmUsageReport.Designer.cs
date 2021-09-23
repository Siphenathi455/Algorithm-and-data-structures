namespace CSIS2614_Project1
{
    partial class frmUsageReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMonths = new System.Windows.Forms.ComboBox();
            this.lstbxUsage = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkExceededLimits = new System.Windows.Forms.CheckBox();
            this.lblUsage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Month";
            // 
            // cmbMonths
            // 
            this.cmbMonths.FormattingEnabled = true;
            this.cmbMonths.Location = new System.Drawing.Point(90, 24);
            this.cmbMonths.Name = "cmbMonths";
            this.cmbMonths.Size = new System.Drawing.Size(143, 21);
            this.cmbMonths.TabIndex = 1;
            this.cmbMonths.SelectedIndexChanged += new System.EventHandler(this.cmbMonths_SelectedIndexChanged);
            // 
            // lstbxUsage
            // 
            this.lstbxUsage.FormattingEnabled = true;
            this.lstbxUsage.Location = new System.Drawing.Point(16, 85);
            this.lstbxUsage.Name = "lstbxUsage";
            this.lstbxUsage.Size = new System.Drawing.Size(217, 147);
            this.lstbxUsage.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(158, 272);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkExceededLimits
            // 
            this.chkExceededLimits.AutoSize = true;
            this.chkExceededLimits.Location = new System.Drawing.Point(16, 238);
            this.chkExceededLimits.Name = "chkExceededLimits";
            this.chkExceededLimits.Size = new System.Drawing.Size(127, 30);
            this.chkExceededLimits.TabIndex = 4;
            this.chkExceededLimits.Text = "Only households who\r\nexceeded limits";
            this.chkExceededLimits.UseVisualStyleBackColor = true;
            this.chkExceededLimits.CheckedChanged += new System.EventHandler(this.chkExceededLimits_CheckedChanged);
            // 
            // lblUsage
            // 
            this.lblUsage.AutoSize = true;
            this.lblUsage.Location = new System.Drawing.Point(13, 69);
            this.lblUsage.Name = "lblUsage";
            this.lblUsage.Size = new System.Drawing.Size(38, 13);
            this.lblUsage.TabIndex = 5;
            this.lblUsage.Text = "Usage";
            // 
            // frmUsageReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 307);
            this.Controls.Add(this.lblUsage);
            this.Controls.Add(this.chkExceededLimits);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstbxUsage);
            this.Controls.Add(this.cmbMonths);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsageReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usage Report";
            this.Load += new System.EventHandler(this.frmUsageReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMonths;
        private System.Windows.Forms.ListBox lstbxUsage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkExceededLimits;
        private System.Windows.Forms.Label lblUsage;
    }
}