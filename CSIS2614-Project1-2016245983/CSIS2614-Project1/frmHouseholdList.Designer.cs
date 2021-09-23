namespace CSIS2614_Project1
{
    partial class frmHouseholdList
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
            this.lstbxHouseholds = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNumOfPeople = new System.Windows.Forms.NumericUpDown();
            this.btnUsage = new System.Windows.Forms.Button();
            this.btnAddHouseHold = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbxHouseholds
            // 
            this.lstbxHouseholds.FormattingEnabled = true;
            this.lstbxHouseholds.Location = new System.Drawing.Point(12, 58);
            this.lstbxHouseholds.Name = "lstbxHouseholds";
            this.lstbxHouseholds.Size = new System.Drawing.Size(316, 238);
            this.lstbxHouseholds.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of people";
            // 
            // nudNumOfPeople
            // 
            this.nudNumOfPeople.Location = new System.Drawing.Point(339, 57);
            this.nudNumOfPeople.Name = "nudNumOfPeople";
            this.nudNumOfPeople.Size = new System.Drawing.Size(42, 20);
            this.nudNumOfPeople.TabIndex = 2;
            // 
            // btnUsage
            // 
            this.btnUsage.Location = new System.Drawing.Point(334, 94);
            this.btnUsage.Name = "btnUsage";
            this.btnUsage.Size = new System.Drawing.Size(75, 23);
            this.btnUsage.TabIndex = 3;
            this.btnUsage.Text = "Usage";
            this.btnUsage.UseVisualStyleBackColor = true;
            this.btnUsage.Click += new System.EventHandler(this.btnUsage_Click);
            // 
            // btnAddHouseHold
            // 
            this.btnAddHouseHold.Location = new System.Drawing.Point(334, 155);
            this.btnAddHouseHold.Name = "btnAddHouseHold";
            this.btnAddHouseHold.Size = new System.Drawing.Size(126, 23);
            this.btnAddHouseHold.TabIndex = 4;
            this.btnAddHouseHold.Text = "&Add household";
            this.btnAddHouseHold.UseVisualStyleBackColor = true;
            this.btnAddHouseHold.Click += new System.EventHandler(this.btnAddHouseHold_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(334, 184);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(385, 280);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(111, 32);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(213, 20);
            this.txtAdress.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Household Adress";
            // 
            // frmHouseholdList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 315);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddHouseHold);
            this.Controls.Add(this.btnUsage);
            this.Controls.Add(this.nudNumOfPeople);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbxHouseholds);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHouseholdList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Households";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxHouseholds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNumOfPeople;
        private System.Windows.Forms.Button btnUsage;
        private System.Windows.Forms.Button btnAddHouseHold;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label2;
    }
}