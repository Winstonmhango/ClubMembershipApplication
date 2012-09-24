using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClubMembers
{
    public partial class AddEditClubMemberForm : Form
    {
        public AddEditClubMemberForm()
        {
            InitializeComponent();
            fillInUsernames();
            unLockFields();
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            btnUnlock.Visible = true;
            btnUpdate.Enabled = false;
            btnUnlock.Enabled = false;
        }

        public AddEditClubMemberForm(ClubMember c)
        {
            InitializeComponent();
            fillInUsernames();
            loadFields(c);
            btnUpdate.Enabled = false;
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            btnUnlock.Visible = true;
            lockFields();
        }

        public AddEditClubMemberForm(bool b)
        {
            InitializeComponent();
            fillInUsernames();
            unLockFields();
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            btnUnlock.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClubMember c = new ClubMember(txtUsername.Text);
            DialogResult result = DialogResult.OK;
            if (!txtUsername.Text.Equals(c.getUsername()))
            {
                result = MessageBox.Show("Username cannot be updated.\nContinue without updating username?",
                    "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            if (result.Equals(DialogResult.OK))
            {
                c.status = cbStatus.Text;
                c.nickName = txtNickname.Text;
                c.firstName = txtFname.Text;
                c.lastName = txtLname.Text;
                c.addressLine1 = txtAddress1.Text;
                c.addressLine2 = txtAddress2.Text;
                c.city = txtCity.Text;
                c.state = cbState.SelectedItem.ToString();
                c.zip = txtZip.Text;
                c.email = txtEmail.Text;
                c.homePhone = txtHomePh.Text;
                c.cellPhone = txtCellPh.Text;
                c.dateOfBirth = dtpDOB.Value.Date;
                c.emergencyContact1 = txtEName1.Text;
                c.emergencyContact1Relation = txtERelation1.Text;
                c.emergencyContact1Phone = txtEPhone1.Text;
                c.emergencyContact2 = txtEName2.Text;
                c.emergencyContact2Relation = txtERelation2.Text;
                c.emergencyContact2Phone = txtEPhone2.Text;
                c.insuranceCompanyName = txtInsName.Text;
                c.insurancePolicyNumber = txtInsPolicyNum.Text;
                c.insuranceGroupNumber = txtInsGroupNum.Text;
                string str = c.Save();
                if (str.Equals("Success"))
                {
                    btnClear.PerformClick();
                }
                else
                {
                    MessageBox.Show(str, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddCM_Click(object sender, EventArgs e)
        {
            // validate username is available
            if (!validateUsername())
            {
                MessageBox.Show("Username field was left blank or unavailable, try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                ClubMember c = new ClubMember(cbUsernames.SelectedValue.ToString());
                c.status = cbStatus.Text;
                c.nickName = txtNickname.Text;
                c.firstName = txtFname.Text;
                c.lastName = txtLname.Text;
                c.addressLine1 = txtAddress1.Text;
                c.addressLine2 = txtAddress2.Text;
                c.city = txtCity.Text;
                c.state = cbState.SelectedItem.ToString();
                c.zip = txtZip.Text;
                c.email = txtEmail.Text;
                c.homePhone = txtHomePh.Text;
                c.cellPhone = txtCellPh.Text;
                c.dateOfBirth = dtpDOB.Value.Date;
                c.emergencyContact1 = txtEName1.Text;
                c.emergencyContact1Relation = txtERelation1.Text;
                c.emergencyContact1Phone = txtEPhone1.Text;
                c.emergencyContact2 = txtEName2.Text;
                c.emergencyContact2Relation = txtERelation2.Text;
                c.emergencyContact2Phone = txtEPhone2.Text;
                c.insuranceCompanyName = txtInsName.Text;
                c.insurancePolicyNumber = txtInsPolicyNum.Text;
                c.insuranceGroupNumber = txtInsGroupNum.Text;
                string str = c.Save();
                if (str.Equals("Success"))
                {
                    btnClear.PerformClick();
                    btnAdd.Visible = false;
                    btnUpdate.Visible = true;
                    btnUnlock.Visible = true;
                }
                else
                {
                    MessageBox.Show(str, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnShowTrans_Click(object sender, EventArgs e)
        {
            TransactionsForm child = new TransactionsForm();
            child.MdiParent = this.MdiParent;
            child.Show();
        }

        private void btnCheckAvail_Click(object sender, EventArgs e)
        {
            validateUsername();
        }

        private void loadFields(ClubMember member)
        {
            cbUsernames.Text = member.getUsername();
            cbStatus.Text = member.status;
            txtUsername.Text = member.getUsername();
            txtNickname.Text = member.nickName;
            txtFname.Text = member.firstName;
            txtLname.Text = member.lastName;
            txtAddress1.Text = member.addressLine1;
            txtAddress2.Text = member.addressLine2;
            txtCity.Text = member.city;
            cbState.Text = member.state;
            txtZip.Text = member.zip;
            txtEmail.Text = member.email;
            txtHomePh.Text = member.homePhone;
            txtCellPh.Text = member.cellPhone;
            dtpDOB.Value = member.dateOfBirth;

            txtEName1.Text = member.emergencyContact1;
            txtERelation1.Text = member.emergencyContact1Relation;
            txtEPhone1.Text = member.emergencyContact1Phone;

            txtEName2.Text = member.emergencyContact2;
            txtERelation2.Text = member.emergencyContact2Relation;
            txtEPhone2.Text = member.emergencyContact2Phone;

            txtInsName.Text = member.insuranceCompanyName;
            txtInsPolicyNum.Text = member.insurancePolicyNumber;
            txtInsGroupNum.Text = member.insuranceGroupNumber;
        }

        private void fillInUsernames()
        {
            cbUsernames.DataSource = App.getMembersAndBalance();
            cbUsernames.DisplayMember = "username";
            cbUsernames.ValueMember = "username";
            cbUsernames.SelectedIndex = 1;

        }

        private void lockFields()
        {
            cbStatus.Enabled = false;
            txtUsername.Enabled = false;
            txtNickname.Enabled = false;
            txtFname.Enabled = false;
            txtLname.Enabled = false;
            txtAddress1.Enabled = false;
            txtAddress2.Enabled = false;
            txtCity.Enabled = false;
            cbState.Enabled = false;
            txtZip.Enabled = false;
            txtEmail.Enabled = false;
            txtHomePh.Enabled = false;
            txtCellPh.Enabled = false;
            dtpDOB.Enabled = false;

            txtEName1.Enabled = false;
            txtERelation1.Enabled = false;
            txtEPhone1.Enabled = false;

            txtEName2.Enabled = false;
            txtERelation2.Enabled = false;
            txtEPhone2.Enabled = false;

            txtInsName.Enabled = false;
            txtInsPolicyNum.Enabled = false;
            txtInsGroupNum.Enabled = false;

            btnUpdate.Enabled = false;
        }

        private void unLockFields()
        {
            cbStatus.Enabled = true;
            txtUsername.Enabled = true;
            txtNickname.Enabled = true;
            txtFname.Enabled = true;
            txtLname.Enabled = true;
            txtAddress1.Enabled = true;
            txtAddress2.Enabled = true;
            txtCity.Enabled = true;
            cbState.Enabled = true;
            txtZip.Enabled = true;
            txtEmail.Enabled = true;
            txtHomePh.Enabled = true;
            txtCellPh.Enabled = true;
            dtpDOB.Enabled = true;

            txtEName1.Enabled = true;
            txtERelation1.Enabled = true;
            txtEPhone1.Enabled = true;

            txtEName2.Enabled = true;
            txtERelation2.Enabled = true;
            txtEPhone2.Enabled = true;

            txtInsName.Enabled = true;
            txtInsPolicyNum.Enabled = true;
            txtInsGroupNum.Enabled = true;
        }

        private void rbLocked_CheckedChanged(object sender, EventArgs e)
        {
            lockFields();
        }

        private void rbUnlocked_CheckedChanged(object sender, EventArgs e)
        {
            unLockFields();
        }

        private void btnLoadCM_Click(object sender, EventArgs e)
        {
            loadFields(new ClubMember(cbUsernames.Text));
            lockFields();
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            btnUnlock.Enabled = true;
            btnUnlock.Visible = true;
        }

        private Boolean validateUsername()
        {
            DataTable dt = App.getUsernames();
            Boolean free = true;
            btnCheckAvail.Enabled = false;

            if (txtUsername.Text != "")
            {
                foreach (DataRow r in dt.Rows)
                {
                    if (r[0].Equals(txtUsername.Text))
                        free = false;
                }
            }
            else
                free = false;

            System.Threading.Thread.Sleep(1000);
            if (free)
                picAvailStatus.BackgroundImage = Properties.Resources.success;
            else
                picAvailStatus.BackgroundImage = Properties.Resources.error;
            btnCheckAvail.Enabled = true;

            return free;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbStatus.Text = "";
            txtUsername.Text = "";
            txtNickname.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtCity.Text = "";
            cbState.Text = "";
            txtZip.Text = "";
            txtEmail.Text = "";
            txtHomePh.Text = "";
            txtCellPh.Text = "";
            dtpDOB.Text = "";

            txtEName1.Text = "";
            txtERelation1.Text = "";
            txtEPhone1.Text = "";

            txtEName2.Text = "";
            txtERelation2.Text = "";
            txtEPhone2.Text = "";

            txtInsName.Text = "";
            txtInsPolicyNum.Text = "";
            txtInsGroupNum.Text = "";

            unLockFields();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            btnUnlock.Visible = false;
            btnClear.PerformClick();
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            unLockFields();
            btnUpdate.Enabled = true;
        }


    }
}
