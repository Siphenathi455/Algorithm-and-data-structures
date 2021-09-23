namespace CSIS2614_Project1
{
    partial class frmRestrictionLevels
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
            this.lstbxLevels = new System.Windows.Forms.ListBox();
            this.txtRestrictions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMaxLitres = new System.Windows.Forms.NumericUpDown();
            this.lblLevels = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddLevel = new System.Windows.Forms.Button();
            this.btnDeleteLevel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLitres)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbxLevels
            // 
            this.lstbxLevels.FormattingEnabled = true;
            this.lstbxLevels.Location = new System.Drawing.Point(22, 47);
            this.lstbxLevels.Name = "lstbxLevels";
            this.lstbxLevels.Size = new System.Drawing.Size(87, 264);
            this.lstbxLevels.TabIndex = 0;
            this.lstbxLevels.SelectedIndexChanged += new System.EventHandler(this.lstbxLevels_SelectedIndexChanged);
            // 
            // txtRestrictions
            // 
            this.txtRestrictions.Location = new System.Drawing.Point(115, 87);
            this.txtRestrictions.Multiline = true;
            this.txtRestrictions.Name = "txtRestrictions";
            this.txtRestrictions.Size = new System.Drawing.Size(394, 170);
            this.txtRestrictions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max litres per person";
            // 
            // nudMaxLitres
            // 
            this.nudMaxLitres.Location = new System.Drawing.Point(246, 40);
            this.nudMaxLitres.Name = "nudMaxLitres";
            this.nudMaxLitres.Size = new System.Drawing.Size(55, 20);
            this.nudMaxLitres.TabIndex = 3;
            // 
            // lblLevels
            // 
            this.lblLevels.AutoSize = true;
            this.lblLevels.Location = new System.Drawing.Point(19, 31);
            this.lblLevels.Name = "lblLevels";
            this.lblLevels.Size = new System.Drawing.Size(33, 13);
            this.lblLevels.TabIndex = 4;
            this.lblLevels.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Restrictions";
            // 
            // btnAddLevel
            // 
            this.btnAddLevel.Location = new System.Drawing.Point(115, 288);
            this.btnAddLevel.Name = "btnAddLevel";
            this.btnAddLevel.Size = new System.Drawing.Size(75, 23);
            this.btnAddLevel.TabIndex = 6;
            this.btnAddLevel.Text = "&Add level";
            this.btnAddLevel.UseVisualStyleBackColor = true;
            this.btnAddLevel.Click += new System.EventHandler(this.btnAddLevel_Click);
            // 
            // btnDeleteLevel
            // 
            this.btnDeleteLevel.Location = new System.Drawing.Point(216, 288);
            this.btnDeleteLevel.Name = "btnDeleteLevel";
            this.btnDeleteLevel.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteLevel.TabIndex = 7;
            this.btnDeleteLevel.Text = "&Delete level";
            this.btnDeleteLevel.UseVisualStyleBackColor = true;
            this.btnDeleteLevel.Click += new System.EventHandler(this.btnDeleteLevel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(434, 288);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRestrictionLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 328);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteLevel);
            this.Controls.Add(this.btnAddLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLevels);
            this.Controls.Add(this.nudMaxLitres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRestrictions);
            this.Controls.Add(this.lstbxLevels);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRestrictionLevels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restriction Levels";
            this.Load += new System.EventHandler(this.frmRestrictionLevels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLitres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxLevels;
        private System.Windows.Forms.TextBox txtRestrictions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMaxLitres;
        private System.Windows.Forms.Label lblLevels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddLevel;
        private System.Windows.Forms.Button btnDeleteLevel;
        private System.Windows.Forms.Button btnClose;
    }
}