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
    public partial class ViewAllMembersForm : Form
    {
        public ViewAllMembersForm()
        {
            InitializeComponent();
        }

        private void ViewAllMembersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportsclubDataSet.ClubMembers' table. You can move, or remove it, as needed.
            membersDataGrid.S
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            String username = membersDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            AddEditClubMemberForm child = 
               new AddEditClubMemberForm(username);
            child.MdiParent = this.MdiParent;
            child.Show();
             
        }
    }
}
