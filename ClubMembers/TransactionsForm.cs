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
    public partial class TransactionsForm : Form
    {
        // config variables
        //int recordsPerPage = 15;
        //string currentlyShowing;
        
        public TransactionsForm()
        {
            InitializeComponent();
        }

        private void TransactionsForm_Load(object sender, EventArgs e)
        {
            cbSemester.DataSource = App.getSemesterList();
            cbSemester.DisplayMember = "semester";
            cbSemester.ValueMember = "semester";
            cbSemester.SelectedIndex = -1;
            cbUsernames.DataSource = App.getUsernames();
            cbUsernames.DisplayMember = "username";
            cbUsernames.ValueMember = "username";
            cbUsernames.SelectedIndex = -1;
            cbMembers.DataSource = App.getUsernames();
            cbMembers.DisplayMember = "username";
            cbMembers.ValueMember = "username";
            if (cbMembers.Items.Count > 0)
            {
                cbMembers.SelectedIndex = 0;
            }
            else
            {
                cbMembers.SelectedIndex = -1;
            }
            cbDepNo.DataSource = App.getDepositIds();
            cbDepNo.DisplayMember = "DepositNumber";
            cbDepNo.ValueMember = "DepositNumber";
            cbDepNo.SelectedIndex = -1;
            
            //fillInUsernames();
            loadTransactions();
            btnSave.Enabled = false;
        }

        private void loadTransactions()
        {
            if (rbActiveMembers.Checked)
            {
                gridTransactions.DataSource = App.getActiveTransactions();
            }
            else
            {
                gridTransactions.DataSource = App.getTransactions();
            }
            
            txtTotalRecs.Text = gridTransactions.Rows.Count.ToString();
            updateAdvanced();
            alterAdvanced(false);
        }

        private void btnMemberTrans_Click(object sender, EventArgs e)
        {
            gridTransactions.DataSource = App.getMemberTransactions(cbMembers.Text);
            txtTotalRecs.Text = gridTransactions.Rows.Count.ToString();
            updateAdvanced();
            alterAdvanced(false);
            btnDelete.Enabled = true;
        }

        private void btnDeposits_Click(object sender, EventArgs e)
        {
            gridTransactions.DataSource = App.getDepositList();
            txtTotalRecs.Text = gridTransactions.Rows.Count.ToString();
            btnClear.PerformClick();
            alterAdvanced(false);
            btnDelete.Enabled = false;
        }

        private void updateAdvanced()
        {
            DataTable dt = App.getAllTransColsForID(gridTransactions.SelectedRows[0].Cells[0].Value.ToString());
            DataGridView view = new DataGridView();
            view.DataSource = dt;

            lblActualID.Text =  dt.Rows[0][0].ToString();
            cbUsernames.Text =  dt.Rows[0][3].ToString();
            string amt =        dt.Rows[0][8].ToString();
            decimal amount      = Decimal.Parse(amt);
            txtAmt.Text =       amount.ToString("C");
            dtpDate.Text =      dt.Rows[0][4].ToString();
            cbType.Text =       dt.Rows[0][1].ToString();
            string strSemester = dt.Rows[0][2].ToString();
            cbSemester.SelectedIndex = cbSemester.FindStringExact(strSemester);
            string depId = dt.Rows[0][5].ToString();
            if (!depId.Equals(""))
            {
                Debug.WriteLine(depId);
                cbDepNo.SelectedIndex = cbDepNo.FindStringExact(depId);
            }
            else
            {
                cbDepNo.SelectedIndex = -1;
            }
            rtbDescr.Text =     dt.Rows[0][7].ToString();
            txtCheckNo.Text =   dt.Rows[0][6].ToString();
        }

        private void alterAdvanced(Boolean canAlter)
        {
            Control[] ctrls = { lblActualID, cbUsernames, txtAmt, dtpDate, btnNow, 
                                   cbType, cbSemester, cbDepNo, rtbDescr, txtCheckNo};

            foreach (Control c in ctrls)
            {
                if (canAlter)
                    c.Enabled = true;
                else
                    c.Enabled = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (rbAllMembers.Checked)
            {
                gridTransactions.DataSource = App.getTransactions();
            }
            else
            {
                gridTransactions.DataSource = App.getActiveTransactions();
            }
            updateAdvanced();
            alterAdvanced(false);
            btnDelete.Enabled = true;
        }

        private void gridTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateAdvanced();
            alterAdvanced(false);
            btnSave.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbUsernames.Text = "";
            txtAmt.Text = "";
            dtpDate.Text = DateTime.Now.ToString();
            cbType.Text = "";
            cbSemester.SelectedIndex = -1;
            cbDepNo.SelectedIndex = -1;
            rtbDescr.Text = "";
            txtDepID.Text = "";
            txtCheckNo.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            alterAdvanced(true);
            btnSave.Enabled = true;
        }

        private Boolean checkRequiredInput()
        {
            Boolean verified = true;
            String failedFields = "";
            if (cbUsernames.Text.Equals(""))
            {
                verified = false;
                failedFields += "Username\n";
            }
            if (txtAmt.Text.Equals(""))
            {
                verified = false;
                failedFields += "Amount\n";
            } 
            if (cbType.Text.Equals(""))
            {
                verified = false;
                failedFields += "Type\n";
            }
            if (cbSemester.Text.Equals(""))
            {
                verified = false;
                failedFields += "Semester\n";
            }

            if (!verified)
            {
                MessageBox.Show(failedFields, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
                //new EMessageDialog(failedFields).ShowDialog();

            return verified;
        }

        private void btnNow_Click(object sender, EventArgs e)
        {
            dtpDate.Text = DateTime.Now.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Transaction trans;
            if (checkRequiredInput())
            {
                if (lblActualID.Text == "")
                {
                    // new transaction
                    trans = new Transaction();
                    trans.username = cbUsernames.Text;
                    string type = cbType.SelectedItem.ToString();
                    //string fAmt = txtAmt.Text.Substring(1);
                    trans.amount = App.MyDecParse(txtAmt.Text);
                    if (type.Equals("Payment") || type.Equals("Refund") || type.Equals("Credit"))
                    {
                        trans.amount = trans.amount * -1;
                    }
                    trans.transDate = dtpDate.Value.Date;
                    trans.type = type;
                    trans.semester = cbSemester.Text;
                    trans.description = rtbDescr.Text;
                    trans.depositNumber = txtDepID.Text;
                    trans.checkNumber = txtCheckNo.Text;
                    ClubMember cm = new ClubMember(trans);
                    lblResult.Text = cm.addTransaction();
                    btnRefresh.PerformClick();
                    System.Threading.Thread.Sleep(1000);
                    lblResult.Text = "";
                }
                else
                {
                    trans = new Transaction(Int32.Parse(lblActualID.Text));
                    trans.username = cbUsernames.Text;
                    string type = cbType.SelectedItem.ToString();
                    trans.amount = App.MyDecParse(txtAmt.Text);
                    if (type.Equals("Payment") || type.Equals("Refund") || type.Equals("Credit"))
                    {
                        trans.amount = trans.amount * -1;
                    }
                    // incase a payment, refund or credit is changed to a charge
                    else if (type.Equals("Charge"))
                    {
                        trans.amount = Math.Abs(trans.amount);
                    }
                    trans.transDate = dtpDate.Value.Date;
                    trans.type = cbType.Text;
                    trans.semester = cbSemester.Text;
                    trans.description = rtbDescr.Text;
                    trans.depositNumber = txtDepID.Text;
                    trans.checkNumber = txtCheckNo.Text;
                    lblResult.Text = trans.Save();
                    btnRefresh.PerformClick(); 
                    System.Threading.Thread.Sleep(1000);
                    lblResult.Text = "";
                }
                if (lblResult.Text.Equals("Success!"))
                {
                    alterAdvanced(false);
                    lblActualID.Text = trans.getTransNo().ToString();
                }
            }
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            alterAdvanced(true);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnClear.PerformClick();
            btnSave.Enabled = true;
            alterAdvanced(true);
            lblActualID.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(gridTransactions.SelectedRows[0].Cells[0].Value);
            Transaction t = new Transaction(int.Parse(gridTransactions.SelectedRows[0].Cells[0].Value.ToString()));
            DialogResult result = MessageBox.Show("Are you sure you want to permanently delete this transaction?", 
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.Yes))
            {
                t.Delete();
                btnRefresh.PerformClick();
            }
            btnDelete.Enabled = false;
            
        }

        private void btnSaveDep_Click(object sender, EventArgs e)
        {
            Deposit d = new Deposit(txtDepID.Text);
            lblDepResult.Text = d.DBstatus;
            btnDeposits.PerformClick();
        }

        private void btnChrgFees_Click(object sender, EventArgs e)
        {
            ChargeMembershipFeesForm fee = new ChargeMembershipFeesForm();
            fee.MdiParent = this.MdiParent;
            fee.Show();
        }
    }
}
