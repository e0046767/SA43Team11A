using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA43Team11ALibraryManagementSystem
{
    public partial class FrmLoginUI : Form
    {
        FrmMainFrameUI fmfui;
        int count = 0;
        SA43Team11AEntities2 context;

        public FrmLoginUI(FrmMainFrameUI FMFUI)
        {
            InitializeComponent();
             fmfui = FMFUI;
        }

        private void FrmLoginUI_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            btnLoginChangePassword.Enabled = false;
            txtUserID.Focus();
        }

        private void txtUseID_TextChanged(object sender, EventArgs e)
        {
            if ((txtUserID.Text != "") && (txtPassword.Text != ""))
            {
                btnLogin.Enabled = true;
                btnLoginChangePassword.Enabled = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if ((txtUserID.Text != "") && (txtPassword.Text != ""))
            {
                btnLogin.Enabled = true;
                btnLoginChangePassword.Enabled = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userID = (txtUserID.Text).Trim();
            string password = (txtPassword.Text).Trim();

            string valid = ValidateLoginDetails();
            count++;

            if (valid == "yes")
            {
                fmfui.ValidUser(userID, password);
                this.Close();
            }
            else if ((valid == "no") && (count > 2))
            {
                MessageBox.Show("Sorry, 3 failed attempts to login reached. Please contact system administrator for help. Exiting the application now.");
                fmfui.UserExit();
            }
            else if ((valid == "no") && (count < 3))
            {
                string msg = string.Format("Unsuccessful Login, you have {0} more tries left.", (3 - count).ToString());
                MessageBox.Show(msg);
                txtPassword.Text = "";
                txtUserID.Text = "";
                txtUserID.Focus();
                btnLogin.Enabled = false;
                btnLoginChangePassword.Enabled = false;
            }
        }

        private string ValidateLoginDetails()
        {
            string valid = "";
            string userID = (txtUserID.Text).Trim();
            string password = (txtPassword.Text).Trim();

            context = new SA43Team11AEntities2();
            int cnt = 0;
            cnt = context.UserAccounts.Count(x => x.UserID == userID && x.UserPassword == password);

            if (cnt > 0)
            {
                valid = "yes";
            }
            else
            {
                valid = "no";
            }
            return valid;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            fmfui.UserExit();
        }

        private void btnLoginChangePassword_Click(object sender, EventArgs e)
        {
            string userID = (txtUserID.Text).Trim();
            string password = (txtPassword.Text).Trim();

            string valid = ValidateLoginDetails();
            count++;

            if (valid == "yes")
            {
                fmfui.ValidUserandChangePassword(userID, password);
                this.Close();
            }
            else if ((valid == "no") && (count > 2))
            {
                MessageBox.Show("Sorry, 3 failed attempts to login reached. Please contact system administrator for help. Exiting the application now.");
                fmfui.UserExit();
            }
            else if ((valid == "no") && (count < 3))
            {
                string msg = string.Format("Unsuccessful Login, you have {0} more tries left.", (3 - count).ToString());
                MessageBox.Show(msg);
                txtPassword.Text = "";
                txtUserID.Text = "";
                txtUserID.Focus();
                btnLogin.Enabled = false;
                btnLoginChangePassword.Enabled = false;
            }

        }
    }
}
