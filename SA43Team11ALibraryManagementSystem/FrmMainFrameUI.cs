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
    public partial class FrmMainFrameUI : Form
    {
        string userID = "";
        string name = "";

        public FrmMainFrameUI()
        {
            InitializeComponent();
        }

        private void FrmMainFrameUI_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.WindowState = FormWindowState.Maximized;
            FrmLoginUI frmLoginUI = new FrmLoginUI(this);
            frmLoginUI.Show();
        }

        public string StatusStrip
        {
            set
            {
                toolStripStatusLabel1.Text = value;
            }
        }

        public void ValidUser(string userID, string name)
        {
            this.userID = userID;
            this.name = name;
            this.Show();
            this.Enabled = true;
            StatusStrip = "Ready";
        }

        public void ValidUserandChangePassword(string userID, string name)
        {
            this.userID = userID;
            this.name = name;
            this.Show();
            this.Enabled = true;
            CloseExistingChildForm();
            FrmUserAccountUI userAcctUI = new FrmUserAccountUI(userID, name, this);
            userAcctUI.MdiParent = this;
            userAcctUI.Show();
        }

        public void UserExit()
        {
            Application.Exit();
        }

        private void CloseExistingChildForm()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() != typeof(FrmMainFrameUI))
                {
                    form.Close();
                    return;
                }
            }
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseExistingChildForm();
            FrmUserAccountUI userAcctUI = new FrmUserAccountUI("", "", this);
            userAcctUI.MdiParent = this;
            userAcctUI.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseExistingChildForm();
            FrmUserAccountUI userAcctUI = new FrmUserAccountUI(userID, name, this);
            userAcctUI.MdiParent = this;
            userAcctUI.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseExistingChildForm();
            FrmMemberUI memberUI = new FrmMemberUI(userID, name, this);
            memberUI.MdiParent = this;
            memberUI.Show();
        }
    }
}
