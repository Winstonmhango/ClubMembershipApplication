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
    public partial class AdministrationForm : Form
    {
        public AdministrationForm()
        {
            InitializeComponent();
        }


        private void btnAddNewSemester_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            System.Threading.Thread.Sleep(3000);
            if (txtSemester.Equals("") || txtYear.Equals(""))
            {
                MessageBox.Show("Missing information, correct and resubmit.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string result = App.addSemester(txtSemester.Text + " " + txtYear.Text);
                System.Diagnostics.Debug.WriteLine(result);
                if (result.Equals("Success"))
                {
                    lblNewSemesterResult.ForeColor = System.Drawing.Color.Green;
                    lblResult.Text = result;
                    txtSemester.Text = "";
                    txtYear.Text = "";
                }
                else
                {
                    lblNewSemesterResult.ForeColor = System.Drawing.Color.Red;
                    lblResult.Text = result;
                    txtSemester.Text = "";
                    txtYear.Text = "";
                }

            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
