using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA43Team11ALibraryManagementSystem
{
    public partial class FrmUserAccountUI : Form
    {
        string userID;
        string name;
        FrmMainFrameUI fmfui;
        SA43Team11AEntities2 context;
        string uID = "";
        string uName = "";
        string uPword = "";

        public FrmUserAccountUI(string userID, string name, FrmMainFrameUI fmfui)
        {
            InitializeComponent();
            this.userID = userID;
            this.name = name;
            this.fmfui = fmfui;
        }

        private void FrmUserAccountUI_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            txtRetypePassword.Enabled = false;
            context = new SA43Team11AEntities2();

            if ((userID != "") && (name != ""))
            {
                UserAccount ua = context.UserAccounts.Where(x => x.UserID == userID).First();

                cbbUserID.Text = ua.UserID;
                txtName.Text = ua.UserName;
                cbbUserID.Enabled = false;
                txtName.Enabled = false;
                fmfui.StatusStrip = "Type your new password in 2 Password fields and click Save button.";
            }
            else
            {
                List<UserAccount> ua1 = context.UserAccounts.ToList();

                foreach(UserAccount uat in ua1)
                {
                    cbbUserID.Items.Add(uat.UserID);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            fmfui.Focus();
            this.Close();
            fmfui.StatusStrip = "Ready";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                txtRetypePassword.Text = "";
                txtRetypePassword.Enabled = true;
                btnSave.Enabled = false;
            }
        }

        private void cbbUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            context = new SA43Team11AEntities2();
            UserAccount ua = context.UserAccounts.Where(x => x.UserID == cbbUserID.Text).First();

            if (ua.UserName != null)
            {
                txtName.Text = ua.UserName;
                txtPassword.Text = "";
                txtRetypePassword.Text = "";
                uID = ua.UserID;
                uName = ua.UserName;
                uPword = ua.UserPassword;
            }
        }

        private void txtRetypePassword_TextChanged(object sender, EventArgs e)
        {
            if ((txtRetypePassword.Text != "") && (txtPassword.Text != ""))
            {
                btnSave.Enabled = true;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if ((uID != "") && (txtName.Text != "") && (txtPassword.Text == "") && (txtRetypePassword.Text == ""))
            {
                context = new SA43Team11AEntities2();
                UserAccount ua = context.UserAccounts.Where(x => x.UserID == cbbUserID.Text).First();
                      
                ua.UserName = txtName.Text;
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            context = new SA43Team11AEntities2();

            if (txtPassword.Text.Trim() != txtRetypePassword.Text.Trim())
            {
                MessageBox.Show("New Password entered inconsistent! Please re-enter new password");
                txtPassword.Text = "";
                txtRetypePassword.Text = "";
                txtPassword.Focus();
            }
            else if (txtPassword.Text.Trim() == uPword)
            {
                MessageBox.Show("New Password can not be same as existing password. Please re-enter new password.");
                txtPassword.Text = "";
                txtRetypePassword.Text = "";
                txtPassword.Focus();
            }
            else if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Name cannot be empty. Please enter a Name.");
                txtName.Text = "";
                txtName.Focus();
            }
            else if (((txtName.Text.Trim() != uName) && ((txtPassword.Text.Trim() == "")) || ((txtPassword.Text.Trim() == txtRetypePassword.Text.Trim()) && txtPassword.Text.Trim() != uPword)))
            {
                int count = 0;
                count = context.UserAccounts.Count(x => x.UserID == cbbUserID.Text.Trim());

                if (count > 0)
                {
                    UserAccount ua = context.UserAccounts.Where(x => x.UserID == cbbUserID.Text.Trim()).First();

                    ua.UserName = txtName.Text.Trim();

                    if ((txtPassword.Text.Trim() == txtRetypePassword.Text.Trim()) && txtPassword.Text.Trim() != uPword && txtPassword.Text.Trim() != "")
                    {
                        ua.UserPassword = txtPassword.Text.Trim();
                    }
                    uID = ua.UserID;
                    uName = ua.UserName;
                    uPword = ua.UserPassword;
                }
                else
                {
                    UserAccount uaNew = new UserAccount();

                    uaNew.UserID = cbbUserID.Text.Trim();
                    uaNew.UserName = txtName.Text.Trim();

                    if ((txtPassword.Text.Trim() == txtRetypePassword.Text.Trim()) && txtPassword.Text.Trim() != uPword && txtPassword.Text.Trim() != "")
                    {
                        uaNew.UserPassword = txtPassword.Text.Trim();
                    }
                    uID = uaNew.UserID;
                    uName = uaNew.UserName;
                    uPword = uaNew.UserPassword;

                    context.UserAccounts.Add(uaNew);
                }
                context.SaveChanges();
                txtPassword.Text = "";
                txtRetypePassword.Text = "";
                fmfui.StatusStrip = "Transaction updated successfully";
            }
        }
    }
}
