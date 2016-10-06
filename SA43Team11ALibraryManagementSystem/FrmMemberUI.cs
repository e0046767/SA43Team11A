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
    public partial class FrmMemberUI : Form
    {
        string userID;
        string name;
        FrmMainFrameUI fmfui;
        SA43Team11AEntities2 context;

        public FrmMemberUI(string userID, string name, FrmMainFrameUI fmfui)
        {
            InitializeComponent();
            this.userID = userID;
            this.name = name;
            this.fmfui = fmfui;
        }

        private void FrmMemberUI_Load(object sender, EventArgs e)
        {
            //btnSave.Enabled = false;
            context = new SA43Team11AEntities2();

            List<Member> members = context.Members.ToList();
            
            foreach(Member mem in members)
            {
                cbbMemberID.Items.Add(mem.MemberID);
            }
        }

        private void cbbMemberID_SelectedIndexChanged(object sender, EventArgs e)
        {
            context = new SA43Team11AEntities2();

            Member member = context.Members.Where(x => x.MemberID == cbbMemberID.Text).First();

            if (member.MemberID != null)
            {
                txtMemberName.Text = member.MemberName;
                cbbGender.Text = member.Gender;
                dtpDOB.Text = member.DOB.ToString();
                txtICNumber.Text = member.ICNumber;
                txtContactNumber.Text = member.ContactNumber;
                txtEmailAddress.Text = member.E_Mail;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            fmfui.Show();
            this.Close();
            fmfui.StatusStrip = "Ready";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbbMemberID.Text.Trim() == "")
            {
                MessageBox.Show("Member ID cannot be blank. Please enter or select a Member ID.");
            }
            else if (txtMemberName.Text.Trim() == "")
            {
                MessageBox.Show("Member Name cannot be blank. Please enter a Member Name.");
            }
            else if (cbbGender.Text.Trim() == "")
            {
                MessageBox.Show("Gender cannot be blank. Please enter a Gender.");
            }
            else if (txtICNumber.Text.Trim() == "")
            {
                MessageBox.Show("Identification Number cannot be blank. Please enter a Identification Number.");
            }
            else
            {
                int count = 0;
                count = context.Members.Count(x => x.MemberID == cbbMemberID.Text);

              

                if (count > 0)
                {
                    Member member = context.Members.Where(x => x.MemberID == cbbMemberID.Text.Trim()).FirstOrDefault();

                    member.MemberID = cbbMemberID.Text.Trim();
                    member.MemberName = txtMemberName.Text.Trim();
                    member.Gender = cbbGender.Text.Trim();
                    member.DOB = dtpDOB.Value.Date;
                    member.ICNumber = txtICNumber.Text.Trim();
                    member.ContactNumber = txtContactNumber.Text.Trim();
                    member.E_Mail = txtEmailAddress.Text.Trim();

                }
                else
                {
                    Member memberNew = new Member();

                    memberNew.MemberID = cbbMemberID.Text.Trim();
                    memberNew.MemberName = txtMemberName.Text.Trim();
                    memberNew.Gender = cbbGender.Text.Trim();
                    memberNew.DOB = dtpDOB.Value.Date;
                    memberNew.ICNumber = txtICNumber.Text.Trim();
                    memberNew.ContactNumber = txtContactNumber.Text.Trim();
                    memberNew.E_Mail = txtEmailAddress.Text.Trim();

                    context.Members.Add(memberNew);
                }
                context.SaveChanges();
                fmfui.StatusStrip = "Transaction updated successfully";

            }
        }
    }
}
