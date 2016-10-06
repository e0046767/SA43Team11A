namespace SA43Team11ALibraryManagementSystem
{
    partial class FrmMemberUI
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
            this.lblMemberID = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtICNumber = new System.Windows.Forms.TextBox();
            this.lblICNumber = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.cbbMemberID = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(72, 40);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(92, 20);
            this.lblMemberID.TabIndex = 0;
            this.lblMemberID.Text = "Member ID";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(254, 78);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(341, 27);
            this.txtMemberName.TabIndex = 2;
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(72, 81);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(119, 20);
            this.lblMemberName.TabIndex = 2;
            this.lblMemberName.Text = "Member Name";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(72, 177);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(105, 20);
            this.lblDOB.TabIndex = 6;
            this.lblDOB.Text = "Date of Birth";
            // 
            // txtICNumber
            // 
            this.txtICNumber.Location = new System.Drawing.Point(254, 217);
            this.txtICNumber.Name = "txtICNumber";
            this.txtICNumber.Size = new System.Drawing.Size(200, 27);
            this.txtICNumber.TabIndex = 5;
            // 
            // lblICNumber
            // 
            this.lblICNumber.AutoSize = true;
            this.lblICNumber.Location = new System.Drawing.Point(72, 220);
            this.lblICNumber.Name = "lblICNumber";
            this.lblICNumber.Size = new System.Drawing.Size(167, 20);
            this.lblICNumber.TabIndex = 8;
            this.lblICNumber.Text = "Identification Number";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(254, 260);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(200, 27);
            this.txtContactNumber.TabIndex = 6;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(72, 263);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(131, 20);
            this.lblContactNumber.TabIndex = 10;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(254, 302);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(341, 27);
            this.txtEmailAddress.TabIndex = 7;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(72, 305);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(118, 20);
            this.lblEmailAddress.TabIndex = 12;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(254, 177);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(341, 27);
            this.dtpDOB.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(254, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 33);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(378, 385);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(76, 33);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // cbbMemberID
            // 
            this.cbbMemberID.FormattingEnabled = true;
            this.cbbMemberID.Location = new System.Drawing.Point(254, 34);
            this.cbbMemberID.Name = "cbbMemberID";
            this.cbbMemberID.Size = new System.Drawing.Size(200, 28);
            this.cbbMemberID.TabIndex = 1;
            this.cbbMemberID.SelectedIndexChanged += new System.EventHandler(this.cbbMemberID_SelectedIndexChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(72, 131);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(64, 20);
            this.lblGender.TabIndex = 13;
            this.lblGender.Text = "Gender";
            // 
            // cbbGender
            // 
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbbGender.Location = new System.Drawing.Point(254, 128);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(54, 28);
            this.cbbGender.TabIndex = 3;
            // 
            // FrmMemberUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 457);
            this.Controls.Add(this.cbbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cbbMemberID);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.txtICNumber);
            this.Controls.Add(this.lblICNumber);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.lblMemberID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMemberUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintain Library Member";
            this.Load += new System.EventHandler(this.FrmMemberUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtICNumber;
        private System.Windows.Forms.Label lblICNumber;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ComboBox cbbMemberID;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbbGender;
    }
}