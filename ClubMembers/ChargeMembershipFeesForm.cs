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
    public partial class ChargeMembershipFeesForm : Form
    {

        public ChargeMembershipFeesForm()
        {
            InitializeComponent();
        }

        private void ChargeMembershipFeesForm_Load(object sender, EventArgs e)
        {
            cbSemester.DataSource = App.getSemesterList();
            cbSemester.DisplayMember = "semester";
            cbSemester.ValueMember = "semester";
            cbSemester.SelectedIndex = 1;
            this.Location = new Point(this.MdiParent.Location.X / 2,
                                  this.MdiParent.Location.Y / 2);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text.Equals(""))
            {
                MessageBox.Show("Fee amount missing", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                decimal amt = App.MyDecParse(txtAmount.Text);
                string result = App.CreateGroupCharge(cbSemester.SelectedValue.ToString(), DateTime.Now.Date.Date,
                    "Fee for " + cbSemester.SelectedValue.ToString(), amt);
                if (result.Equals("Success"))
                {
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error performing group transaction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}
