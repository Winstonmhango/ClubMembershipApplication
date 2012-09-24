using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ClubMembers
{
    public partial class MembersForm : Form
    {
        public MembersForm()
        {
            InitializeComponent();
        }

        private void MembersForm_Load(object sender, EventArgs e)
        {
            gridMembers.DataSource = App.getMembersAndBalance();
            updateSnapshot();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (rbActiveMembers.Checked)
            {
                gridMembers.DataSource = App.getActiveMembersAndBalance();
            }
            else
            {
                gridMembers.DataSource = App.getMembersAndBalance();
            }
            updateSnapshot();
        }

        private void updateSnapshot()
        {
            Debug.WriteLine(gridMembers.SelectedRows[0].Cells[0].Value.ToString());
            if (gridMembers.SelectedRows.Count > 0)
            {
                lblSelectedUname.Text = gridMembers.SelectedRows[0].Cells[0].Value.ToString();
                lblSelectedFname.Text = gridMembers.SelectedRows[0].Cells[1].Value.ToString();
                lblSelectedLname.Text = gridMembers.SelectedRows[0].Cells[2].Value.ToString();
                Debug.WriteLine(gridMembers.SelectedRows[0].Cells[8].Value.ToString());
                string balance = gridMembers.SelectedRows[0].Cells[8].Value.ToString();
                decimal bal = 0m;
                if (balance == "")
                {
                    lblSelectedBal.Text = "0";
                }
                else
                {
                    lblSelectedBal.Text = balance;
                    bal = decimal.Parse(balance);
                }
                if (bal > 0)
                {
                    lblSelectedBal.ForeColor = System.Drawing.Color.Red;
                }
                else if (bal == 0)
                {
                    lblSelectedBal.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    lblSelectedBal.ForeColor = System.Drawing.Color.Green;
                }
                lblSelectedBal.Text = bal.ToString("c0");
            }
            else
            {
                lblSelectedUname.Text = "";
                lblSelectedFname.Text = "";
                lblSelectedLname.Text = "";
                lblSelectedBal.Text = "";
            }
        }

        private void gridMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateSnapshot();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ClubMember c = new ClubMember(gridMembers.SelectedRows[0].Cells[0].Value.ToString());
            AddEditClubMemberForm child = new AddEditClubMemberForm(c);
            child.MdiParent = this.MdiParent;
            child.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                ClubMember c = new ClubMember(gridMembers.SelectedRows[0].Cells[0].Value.ToString());
                c.Delete();
                Debug.WriteLine(c.DBstatus);
                if (c.DBstatus.Equals("Exists"))
                {
                    btnRefresh.PerformClick();
                    updateSnapshot();
                }
                else
                {
                    MessageBox.Show("Member does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddEditClubMemberForm child = new AddEditClubMemberForm(true);
            child.MdiParent = this.MdiParent;
            child.Show();
        }
    }
}
