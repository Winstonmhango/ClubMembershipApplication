namespace ClubMembers
{
    partial class MembersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembersForm));
            this.gbOps = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtTotalRecs = new System.Windows.Forms.TextBox();
            this.rbActiveMembers = new System.Windows.Forms.RadioButton();
            this.lblTotalRecs = new System.Windows.Forms.Label();
            this.lblMemTable = new System.Windows.Forms.Label();
            this.rbAllMembers = new System.Windows.Forms.RadioButton();
            this.btnAccount = new System.Windows.Forms.Button();
            this.gridMembers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbFunctions = new System.Windows.Forms.GroupBox();
            this.lblSelectedBal = new System.Windows.Forms.Label();
            this.lblBal = new System.Windows.Forms.Label();
            this.lblSelectedLname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblSelectedFname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblSelectedUname = new System.Windows.Forms.Label();
            this.lblUName = new System.Windows.Forms.Label();
            this.pbFballField = new System.Windows.Forms.PictureBox();
            this.gbOps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMembers)).BeginInit();
            this.gbFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFballField)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOps
            // 
            this.gbOps.BackColor = System.Drawing.Color.Transparent;
            this.gbOps.Controls.Add(this.btnNew);
            this.gbOps.Controls.Add(this.btnRefresh);
            this.gbOps.Controls.Add(this.txtTotalRecs);
            this.gbOps.Controls.Add(this.rbActiveMembers);
            this.gbOps.Controls.Add(this.lblTotalRecs);
            this.gbOps.Controls.Add(this.lblMemTable);
            this.gbOps.Controls.Add(this.rbAllMembers);
            this.gbOps.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbOps.Location = new System.Drawing.Point(515, 23);
            this.gbOps.Name = "gbOps";
            this.gbOps.Size = new System.Drawing.Size(296, 104);
            this.gbOps.TabIndex = 16;
            this.gbOps.TabStop = false;
            this.gbOps.Text = "Table Operations";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(165, 62);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(122, 26);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New Member...";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(212, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtTotalRecs
            // 
            this.txtTotalRecs.Location = new System.Drawing.Point(763, 13);
            this.txtTotalRecs.Name = "txtTotalRecs";
            this.txtTotalRecs.ReadOnly = true;
            this.txtTotalRecs.Size = new System.Drawing.Size(30, 20);
            this.txtTotalRecs.TabIndex = 9;
            // 
            // rbActiveMembers
            // 
            this.rbActiveMembers.AutoSize = true;
            this.rbActiveMembers.ForeColor = System.Drawing.Color.Black;
            this.rbActiveMembers.Location = new System.Drawing.Point(9, 71);
            this.rbActiveMembers.Name = "rbActiveMembers";
            this.rbActiveMembers.Size = new System.Drawing.Size(131, 17);
            this.rbActiveMembers.TabIndex = 2;
            this.rbActiveMembers.Text = "Show Active Members";
            this.rbActiveMembers.UseVisualStyleBackColor = true;
            // 
            // lblTotalRecs
            // 
            this.lblTotalRecs.AutoSize = true;
            this.lblTotalRecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecs.ForeColor = System.Drawing.Color.Black;
            this.lblTotalRecs.Location = new System.Drawing.Point(668, 16);
            this.lblTotalRecs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalRecs.Name = "lblTotalRecs";
            this.lblTotalRecs.Size = new System.Drawing.Size(90, 13);
            this.lblTotalRecs.TabIndex = 8;
            this.lblTotalRecs.Text = "Total records: ";
            // 
            // lblMemTable
            // 
            this.lblMemTable.AutoSize = true;
            this.lblMemTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemTable.ForeColor = System.Drawing.Color.Black;
            this.lblMemTable.Location = new System.Drawing.Point(6, 17);
            this.lblMemTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemTable.Name = "lblMemTable";
            this.lblMemTable.Size = new System.Drawing.Size(194, 13);
            this.lblMemTable.TabIndex = 0;
            this.lblMemTable.Text = "Data loaded from table: Members";
            // 
            // rbAllMembers
            // 
            this.rbAllMembers.AutoSize = true;
            this.rbAllMembers.Checked = true;
            this.rbAllMembers.ForeColor = System.Drawing.Color.Black;
            this.rbAllMembers.Location = new System.Drawing.Point(9, 48);
            this.rbAllMembers.Name = "rbAllMembers";
            this.rbAllMembers.Size = new System.Drawing.Size(112, 17);
            this.rbAllMembers.TabIndex = 1;
            this.rbAllMembers.TabStop = true;
            this.rbAllMembers.Text = "Show All Members";
            this.rbAllMembers.UseVisualStyleBackColor = true;
            // 
            // btnAccount
            // 
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.Green;
            this.btnAccount.Location = new System.Drawing.Point(238, 13);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(122, 26);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.Text = "Show Account...";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // gridMembers
            // 
            this.gridMembers.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gridMembers.AllowUserToAddRows = false;
            this.gridMembers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.fname,
            this.lname,
            this.Nickname,
            this.hphone,
            this.cphone,
            this.email,
            this.Status,
            this.Balance});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMembers.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridMembers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridMembers.Location = new System.Drawing.Point(12, 143);
            this.gridMembers.Name = "gridMembers";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMembers.Size = new System.Drawing.Size(799, 437);
            this.gridMembers.TabIndex = 17;
            this.gridMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMembers_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // fname
            // 
            this.fname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fname.DataPropertyName = "firstname";
            this.fname.HeaderText = "First Name";
            this.fname.Name = "fname";
            this.fname.Width = 82;
            // 
            // lname
            // 
            this.lname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lname.DataPropertyName = "lastname";
            this.lname.HeaderText = "Last Name";
            this.lname.Name = "lname";
            this.lname.Width = 83;
            // 
            // Nickname
            // 
            this.Nickname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nickname.DataPropertyName = "nickname";
            this.Nickname.HeaderText = "Nickname";
            this.Nickname.Name = "Nickname";
            this.Nickname.Width = 80;
            // 
            // hphone
            // 
            this.hphone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.hphone.DataPropertyName = "homephone";
            this.hphone.HeaderText = "Home Phone";
            this.hphone.Name = "hphone";
            this.hphone.Width = 94;
            // 
            // cphone
            // 
            this.cphone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cphone.DataPropertyName = "cellphone";
            this.cphone.HeaderText = "Cell Phone";
            this.cphone.Name = "cphone";
            this.cphone.Width = 83;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Width = 57;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 62;
            // 
            // Balance
            // 
            this.Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Balance.DataPropertyName = "balance";
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = "$0";
            this.Balance.DefaultCellStyle = dataGridViewCellStyle3;
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.Width = 71;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(238, 42);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(122, 26);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit Member...";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Location = new System.Drawing.Point(238, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 26);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Member...";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbFunctions
            // 
            this.gbFunctions.BackColor = System.Drawing.Color.Transparent;
            this.gbFunctions.Controls.Add(this.lblSelectedBal);
            this.gbFunctions.Controls.Add(this.lblBal);
            this.gbFunctions.Controls.Add(this.lblSelectedLname);
            this.gbFunctions.Controls.Add(this.lblLname);
            this.gbFunctions.Controls.Add(this.lblSelectedFname);
            this.gbFunctions.Controls.Add(this.lblFname);
            this.gbFunctions.Controls.Add(this.lblSelectedUname);
            this.gbFunctions.Controls.Add(this.lblUName);
            this.gbFunctions.Controls.Add(this.btnDelete);
            this.gbFunctions.Controls.Add(this.btnEdit);
            this.gbFunctions.Controls.Add(this.btnAccount);
            this.gbFunctions.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbFunctions.Location = new System.Drawing.Point(12, 23);
            this.gbFunctions.Name = "gbFunctions";
            this.gbFunctions.Size = new System.Drawing.Size(366, 103);
            this.gbFunctions.TabIndex = 18;
            this.gbFunctions.TabStop = false;
            this.gbFunctions.Text = "Selected Member Functions";
            // 
            // lblSelectedBal
            // 
            this.lblSelectedBal.AutoSize = true;
            this.lblSelectedBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedBal.ForeColor = System.Drawing.Color.Black;
            this.lblSelectedBal.Location = new System.Drawing.Point(67, 84);
            this.lblSelectedBal.Name = "lblSelectedBal";
            this.lblSelectedBal.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedBal.TabIndex = 19;
            // 
            // lblBal
            // 
            this.lblBal.AutoSize = true;
            this.lblBal.ForeColor = System.Drawing.Color.Black;
            this.lblBal.Location = new System.Drawing.Point(6, 84);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(46, 13);
            this.lblBal.TabIndex = 18;
            this.lblBal.Text = "Balance";
            // 
            // lblSelectedLname
            // 
            this.lblSelectedLname.AutoSize = true;
            this.lblSelectedLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedLname.ForeColor = System.Drawing.Color.Black;
            this.lblSelectedLname.Location = new System.Drawing.Point(67, 62);
            this.lblSelectedLname.Name = "lblSelectedLname";
            this.lblSelectedLname.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedLname.TabIndex = 17;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.ForeColor = System.Drawing.Color.Black;
            this.lblLname.Location = new System.Drawing.Point(6, 62);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(58, 13);
            this.lblLname.TabIndex = 16;
            this.lblLname.Text = "Last Name";
            // 
            // lblSelectedFname
            // 
            this.lblSelectedFname.AutoSize = true;
            this.lblSelectedFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFname.ForeColor = System.Drawing.Color.Black;
            this.lblSelectedFname.Location = new System.Drawing.Point(67, 42);
            this.lblSelectedFname.Name = "lblSelectedFname";
            this.lblSelectedFname.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedFname.TabIndex = 15;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.ForeColor = System.Drawing.Color.Black;
            this.lblFname.Location = new System.Drawing.Point(6, 42);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(57, 13);
            this.lblFname.TabIndex = 14;
            this.lblFname.Text = "First Name";
            // 
            // lblSelectedUname
            // 
            this.lblSelectedUname.AutoSize = true;
            this.lblSelectedUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedUname.ForeColor = System.Drawing.Color.Black;
            this.lblSelectedUname.Location = new System.Drawing.Point(67, 20);
            this.lblSelectedUname.Name = "lblSelectedUname";
            this.lblSelectedUname.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedUname.TabIndex = 13;
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.ForeColor = System.Drawing.Color.Black;
            this.lblUName.Location = new System.Drawing.Point(6, 20);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(55, 13);
            this.lblUName.TabIndex = 12;
            this.lblUName.Text = "Username";
            // 
            // pbFballField
            // 
            this.pbFballField.BackgroundImage = global::ClubMembers.Properties.Resources.football_field;
            this.pbFballField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFballField.Location = new System.Drawing.Point(384, 28);
            this.pbFballField.Name = "pbFballField";
            this.pbFballField.Size = new System.Drawing.Size(125, 98);
            this.pbFballField.TabIndex = 19;
            this.pbFballField.TabStop = false;
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(823, 592);
            this.Controls.Add(this.pbFballField);
            this.Controls.Add(this.gbFunctions);
            this.Controls.Add(this.gridMembers);
            this.Controls.Add(this.gbOps);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MembersForm";
            this.Text = "MembersForm";
            this.Load += new System.EventHandler(this.MembersForm_Load);
            this.gbOps.ResumeLayout(false);
            this.gbOps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMembers)).EndInit();
            this.gbFunctions.ResumeLayout(false);
            this.gbFunctions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFballField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOps;
        private System.Windows.Forms.TextBox txtTotalRecs;
        private System.Windows.Forms.RadioButton rbActiveMembers;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Label lblTotalRecs;
        private System.Windows.Forms.Label lblMemTable;
        private System.Windows.Forms.RadioButton rbAllMembers;
        private System.Windows.Forms.DataGridView gridMembers;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbFunctions;
        private System.Windows.Forms.Label lblSelectedBal;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.Label lblSelectedLname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblSelectedFname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblSelectedUname;
        private System.Windows.Forms.Label lblUName;
        private System.Windows.Forms.PictureBox pbFballField;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn hphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;

    }
}