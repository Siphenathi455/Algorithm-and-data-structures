namespace CSIS2614_Project1
{
    partial class frmLevelsPerMonth
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
            this.lstbxLevelsPerMon = new System.Windows.Forms.ListBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddMon = new System.Windows.Forms.Button();
            this.btnDeleteMon = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbxLevelsPerMon
            // 
            this.lstbxLevelsPerMon.FormattingEnabled = true;
            this.lstbxLevelsPerMon.Location = new System.Drawing.Point(12, 45);
            this.lstbxLevelsPerMon.Name = "lstbxLevelsPerMon";
            this.lstbxLevelsPerMon.Size = new System.Drawing.Size(337, 212);
            this.lstbxLevelsPerMon.TabIndex = 0;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(12, 29);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Limit pp";
            // 
            // btnAddMon
            // 
            this.btnAddMon.Location = new System.Drawing.Point(15, 279);
            this.btnAddMon.Name = "btnAddMon";
            this.btnAddMon.Size = new System.Drawing.Size(75, 23);
            this.btnAddMon.TabIndex = 4;
            this.btnAddMon.Text = "&Add month";
            this.btnAddMon.UseVisualStyleBackColor = true;
            this.btnAddMon.Click += new System.EventHandler(this.btnAddMon_Click);
            // 
            // btnDeleteMon
            // 
            this.btnDeleteMon.Location = new System.Drawing.Point(108, 279);
            this.btnDeleteMon.Name = "btnDeleteMon";
            this.btnDeleteMon.Size = new System.Drawing.Size(85, 23);
            this.btnDeleteMon.TabIndex = 5;
            this.btnDeleteMon.Text = "&Delete month";
            this.btnDeleteMon.UseVisualStyleBackColor = true;
            this.btnDeleteMon.Click += new System.EventHandler(this.btnDeleteMon_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(274, 279);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLevelsPerMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 314);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteMon);
            this.Controls.Add(this.btnAddMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lstbxLevelsPerMon);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLevelsPerMonth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Levels per month";
            this.Load += new System.EventHandler(this.frmLevelsPerMonth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxLevelsPerMon;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddMon;
        private System.Windows.Forms.Button btnDeleteMon;
        private System.Windows.Forms.Button btnClose;
    }
}