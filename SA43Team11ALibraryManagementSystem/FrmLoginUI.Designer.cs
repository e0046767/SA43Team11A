namespace SA43Team11ALibraryManagementSystem
{
    partial class FrmLoginUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginUI));
            this.pboLogo = new System.Windows.Forms.PictureBox();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoginChangePassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pboLogo
            // 
            this.pboLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboLogo.BackgroundImage")));
            this.pboLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboLogo.Location = new System.Drawing.Point(0, 0);
            this.pboLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pboLogo.Name = "pboLogo";
            this.pboLogo.Size = new System.Drawing.Size(617, 301);
            this.pboLogo.TabIndex = 0;
            this.pboLogo.TabStop = false;
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Location = new System.Drawing.Point(132, 347);
            this.lblLogIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(67, 20);
            this.lblLogIn.TabIndex = 99;
            this.lblLogIn.Text = "User ID";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(220, 341);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(206, 27);
            this.txtUserID.TabIndex = 1;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUseID_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(220, 393);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(206, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(116, 399);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 20);
            this.lblPassword.TabIndex = 98;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(120, 457);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(79, 28);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(468, 457);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoginChangePassword
            // 
            this.btnLoginChangePassword.Location = new System.Drawing.Point(215, 457);
            this.btnLoginChangePassword.Name = "btnLoginChangePassword";
            this.btnLoginChangePassword.Size = new System.Drawing.Size(236, 28);
            this.btnLoginChangePassword.TabIndex = 4;
            this.btnLoginChangePassword.Text = "Login and Change Password";
            this.btnLoginChangePassword.UseVisualStyleBackColor = true;
            this.btnLoginChangePassword.Click += new System.EventHandler(this.btnLoginChangePassword_Click);
            // 
            // FrmLoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 508);
            this.Controls.Add(this.btnLoginChangePassword);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblLogIn);
            this.Controls.Add(this.pboLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLoginUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLoginUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboLogo;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoginChangePassword;
    }
}