namespace SA43Team11ALibraryManagementSystem
{
    partial class FrmUserAccountUI
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
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtRetypePassword = new System.Windows.Forms.TextBox();
            this.lblRetypePassword = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbbUserID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(160, 72);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(67, 20);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(271, 119);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 27);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(174, 126);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(271, 177);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(233, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(144, 184);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // txtRetypePassword
            // 
            this.txtRetypePassword.Location = new System.Drawing.Point(271, 238);
            this.txtRetypePassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtRetypePassword.Name = "txtRetypePassword";
            this.txtRetypePassword.Size = new System.Drawing.Size(233, 27);
            this.txtRetypePassword.TabIndex = 4;
            this.txtRetypePassword.TextChanged += new System.EventHandler(this.txtRetypePassword_TextChanged);
            // 
            // lblRetypePassword
            // 
            this.lblRetypePassword.AutoSize = true;
            this.lblRetypePassword.Location = new System.Drawing.Point(81, 245);
            this.lblRetypePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRetypePassword.Name = "lblRetypePassword";
            this.lblRetypePassword.Size = new System.Drawing.Size(146, 20);
            this.lblRetypePassword.TabIndex = 6;
            this.lblRetypePassword.Text = "Re-type Password";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(271, 338);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(429, 338);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 29);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbbUserID
            // 
            this.cbbUserID.FormattingEnabled = true;
            this.cbbUserID.Location = new System.Drawing.Point(271, 66);
            this.cbbUserID.Name = "cbbUserID";
            this.cbbUserID.Size = new System.Drawing.Size(233, 28);
            this.cbbUserID.TabIndex = 1;
            this.cbbUserID.SelectedIndexChanged += new System.EventHandler(this.cbbUserID_SelectedIndexChanged);
            // 
            // FrmUserAccountUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 446);
            this.Controls.Add(this.cbbUserID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRetypePassword);
            this.Controls.Add(this.lblRetypePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUserID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUserAccountUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintain User Account";
            this.Load += new System.EventHandler(this.FrmUserAccountUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtRetypePassword;
        private System.Windows.Forms.Label lblRetypePassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbbUserID;
    }
}