using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClubMembers
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Displays About Box
        private void menuAbout_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }

        // Exits the application
        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Closes current MDI child window
        private void menuClose_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
        }

        // Closes all open MDI children windows
        private void menuCloseAll_Click(object sender, EventArgs e)
        {
            Form[] children = this.MdiChildren;
            foreach (Form f in children)
                f.Close();
        }

        // Cascades all child windows
        private void menuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        // Minimizes all open child windows
        private void menuMinimize_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                f.WindowState = FormWindowState.Minimized;
        }

        // Maximizes all open child windows
        private void menuMaximize_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                f.WindowState = FormWindowState.Maximized;
        }

        // Opens form to view all club members
        private void menuViewMembers_Click(object sender, EventArgs e)
        {
            MembersForm child = new MembersForm();
            child.MdiParent = this;
            child.Show();
        }

        // Opens form to add and edit club members
        private void menuAddEditMembers_Click(object sender, EventArgs e)
        {
            AddEditClubMemberForm child = new AddEditClubMemberForm();
            child.MdiParent = this;
            child.Show();
        }
        
        // Opens form for administration purposes
        private void menuAdminSemesters_Click(object sender, EventArgs e)
        {
            AdministrationForm child = new AdministrationForm();
            child.MdiParent = this;
            child.Show();
        }

        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MembersForm child = new MembersForm();
            child.MdiParent = this;
            child.Show();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionsForm child = new TransactionsForm();
            child.MdiParent = this;
            child.Show();
        }

    }
}
