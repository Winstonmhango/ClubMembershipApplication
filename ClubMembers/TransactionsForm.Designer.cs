namespace ClubMembers
{
    partial class TransactionsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsForm));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnMemberTrans = new System.Windows.Forms.Button();
            this.cbMembers = new System.Windows.Forms.ComboBox();
            this.gbFunct = new System.Windows.Forms.GroupBox();
            this.btnChrgFees = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveDep = new System.Windows.Forms.Button();
            this.btnDeposits = new System.Windows.Forms.Button();
            this.rbActiveMembers = new System.Windows.Forms.RadioButton();
            this.rbAllMembers = new System.Windows.Forms.RadioButton();
            this.gbOps = new System.Windows.Forms.GroupBox();
            this.txtTotalRecs = new System.Windows.Forms.TextBox();
            this.lblTotalRecs = new System.Windows.Forms.Label();
            this.lblTableLoaded = new System.Windows.Forms.Label();
            this.gridTransactions = new System.Windows.Forms.DataGridView();
            this.TransNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbAdvanced = new System.Windows.Forms.GroupBox();
            this.cbDepNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnNow = new System.Windows.Forms.Button();
            this.lblActualID = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.rtbDescr = new System.Windows.Forms.RichTextBox();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbUsernames = new System.Windows.Forms.ComboBox();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtCheckNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTransID = new System.Windows.Forms.Label();
            this.txtDepID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDepDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDepResult = new System.Windows.Forms.Label();
            this.gbFunct.SuspendLayout();
            this.gbOps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).BeginInit();
            this.gbAdvanced.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(419, 72);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(122, 23);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnMemberTrans
            // 
            this.btnMemberTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberTrans.ForeColor = System.Drawing.Color.Black;
            this.btnMemberTrans.Location = new System.Drawing.Point(200, 71);
            this.btnMemberTrans.Name = "btnMemberTrans";
            this.btnMemberTrans.Size = new System.Drawing.Size(147, 23);
            this.btnMemberTrans.TabIndex = 21;
            this.btnMemberTrans.Text = "Member Transactions";
            this.btnMemberTrans.UseVisualStyleBackColor = true;
            this.btnMemberTrans.Click += new System.EventHandler(this.btnMemberTrans_Click);
            // 
            // cbMembers
            // 
            this.cbMembers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMembers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMembers.FormattingEnabled = true;
            this.cbMembers.ItemHeight = 13;
            this.cbMembers.Location = new System.Drawing.Point(200, 44);
            this.cbMembers.Name = "cbMembers";
            this.cbMembers.Size = new System.Drawing.Size(147, 21);
            this.cbMembers.TabIndex = 3;
            // 
            // gbFunct
            // 
            this.gbFunct.Controls.Add(this.btnChrgFees);
            this.gbFunct.Controls.Add(this.btnSave);
            this.gbFunct.Controls.Add(this.btnDelete);
            this.gbFunct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbFunct.Location = new System.Drawing.Point(12, 377);
            this.gbFunct.Name = "gbFunct";
            this.gbFunct.Size = new System.Drawing.Size(226, 81);
            this.gbFunct.TabIndex = 4;
            this.gbFunct.TabStop = false;
            this.gbFunct.Text = "Functions";
            // 
            // btnChrgFees
            // 
            this.btnChrgFees.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnChrgFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChrgFees.ForeColor = System.Drawing.Color.Black;
            this.btnChrgFees.Location = new System.Drawing.Point(10, 19);
            this.btnChrgFees.Name = "btnChrgFees";
            this.btnChrgFees.Size = new System.Drawing.Size(98, 50);
            this.btnChrgFees.TabIndex = 12;
            this.btnChrgFees.Text = "Charge \r\nMembership\r\nFees...";
            this.btnChrgFees.UseVisualStyleBackColor = true;
            this.btnChrgFees.Click += new System.EventHandler(this.btnChrgFees_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Green;
            this.btnSave.Location = new System.Drawing.Point(118, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Location = new System.Drawing.Point(118, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Row...";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveDep
            // 
            this.btnSaveDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDep.ForeColor = System.Drawing.Color.Black;
            this.btnSaveDep.Location = new System.Drawing.Point(87, 64);
            this.btnSaveDep.Name = "btnSaveDep";
            this.btnSaveDep.Size = new System.Drawing.Size(129, 23);
            this.btnSaveDep.TabIndex = 17;
            this.btnSaveDep.Text = "Save Deposit";
            this.btnSaveDep.UseVisualStyleBackColor = true;
            this.btnSaveDep.Click += new System.EventHandler(this.btnSaveDep_Click);
            // 
            // btnDeposits
            // 
            this.btnDeposits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposits.ForeColor = System.Drawing.Color.Black;
            this.btnDeposits.Location = new System.Drawing.Point(419, 44);
            this.btnDeposits.Name = "btnDeposits";
            this.btnDeposits.Size = new System.Drawing.Size(122, 23);
            this.btnDeposits.TabIndex = 22;
            this.btnDeposits.Text = "Show Deposits";
            this.btnDeposits.UseVisualStyleBackColor = true;
            this.btnDeposits.Click += new System.EventHandler(this.btnDeposits_Click);
            // 
            // rbActiveMembers
            // 
            this.rbActiveMembers.AutoSize = true;
            this.rbActiveMembers.ForeColor = System.Drawing.Color.Black;
            this.rbActiveMembers.Location = new System.Drawing.Point(8, 71);
            this.rbActiveMembers.Name = "rbActiveMembers";
            this.rbActiveMembers.Size = new System.Drawing.Size(131, 17);
            this.rbActiveMembers.TabIndex = 19;
            this.rbActiveMembers.Text = "Show Active Members";
            this.rbActiveMembers.UseVisualStyleBackColor = true;
            // 
            // rbAllMembers
            // 
            this.rbAllMembers.AutoSize = true;
            this.rbAllMembers.Checked = true;
            this.rbAllMembers.ForeColor = System.Drawing.Color.Black;
            this.rbAllMembers.Location = new System.Drawing.Point(8, 48);
            this.rbAllMembers.Name = "rbAllMembers";
            this.rbAllMembers.Size = new System.Drawing.Size(112, 17);
            this.rbAllMembers.TabIndex = 18;
            this.rbAllMembers.TabStop = true;
            this.rbAllMembers.Text = "Show All Members";
            this.rbAllMembers.UseVisualStyleBackColor = true;
            // 
            // gbOps
            // 
            this.gbOps.Controls.Add(this.txtTotalRecs);
            this.gbOps.Controls.Add(this.rbActiveMembers);
            this.gbOps.Controls.Add(this.btnDeposits);
            this.gbOps.Controls.Add(this.btnRefresh);
            this.gbOps.Controls.Add(this.cbMembers);
            this.gbOps.Controls.Add(this.btnMemberTrans);
            this.gbOps.Controls.Add(this.lblTotalRecs);
            this.gbOps.Controls.Add(this.lblTableLoaded);
            this.gbOps.Controls.Add(this.rbAllMembers);
            this.gbOps.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbOps.Location = new System.Drawing.Point(259, 12);
            this.gbOps.Name = "gbOps";
            this.gbOps.Size = new System.Drawing.Size(547, 104);
            this.gbOps.TabIndex = 5;
            this.gbOps.TabStop = false;
            this.gbOps.Text = "Table Operations";
            // 
            // txtTotalRecs
            // 
            this.txtTotalRecs.Location = new System.Drawing.Point(511, 13);
            this.txtTotalRecs.Name = "txtTotalRecs";
            this.txtTotalRecs.ReadOnly = true;
            this.txtTotalRecs.Size = new System.Drawing.Size(30, 20);
            this.txtTotalRecs.TabIndex = 9;
            this.txtTotalRecs.TabStop = false;
            // 
            // lblTotalRecs
            // 
            this.lblTotalRecs.AutoSize = true;
            this.lblTotalRecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecs.ForeColor = System.Drawing.Color.Black;
            this.lblTotalRecs.Location = new System.Drawing.Point(416, 16);
            this.lblTotalRecs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalRecs.Name = "lblTotalRecs";
            this.lblTotalRecs.Size = new System.Drawing.Size(90, 13);
            this.lblTotalRecs.TabIndex = 8;
            this.lblTotalRecs.Text = "Total records: ";
            // 
            // lblTableLoaded
            // 
            this.lblTableLoaded.AutoSize = true;
            this.lblTableLoaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableLoaded.ForeColor = System.Drawing.Color.Black;
            this.lblTableLoaded.Location = new System.Drawing.Point(5, 20);
            this.lblTableLoaded.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTableLoaded.Name = "lblTableLoaded";
            this.lblTableLoaded.Size = new System.Drawing.Size(217, 13);
            this.lblTableLoaded.TabIndex = 0;
            this.lblTableLoaded.Text = "Data loaded from table: Transactions";
            // 
            // gridTransactions
            // 
            this.gridTransactions.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gridTransactions.AllowUserToAddRows = false;
            this.gridTransactions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransNo,
            this.Username,
            this.type,
            this.TransDate,
            this.DepID,
            this.ckNum,
            this.Amount});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTransactions.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridTransactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridTransactions.Location = new System.Drawing.Point(259, 124);
            this.gridTransactions.Name = "gridTransactions";
            this.gridTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTransactions.Size = new System.Drawing.Size(547, 437);
            this.gridTransactions.TabIndex = 6;
            this.gridTransactions.TabStop = false;
            this.gridTransactions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTransactions_CellClick);
            this.gridTransactions.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // TransNo
            // 
            this.TransNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TransNo.DataPropertyName = "transNo";
            this.TransNo.HeaderText = "ID";
            this.TransNo.Name = "TransNo";
            this.TransNo.ReadOnly = true;
            this.TransNo.Width = 43;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Username.DataPropertyName = "username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 80;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 56;
            // 
            // TransDate
            // 
            this.TransDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TransDate.DataPropertyName = "transdate";
            this.TransDate.HeaderText = "Date";
            this.TransDate.Name = "TransDate";
            this.TransDate.ReadOnly = true;
            this.TransDate.Width = 55;
            // 
            // DepID
            // 
            this.DepID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DepID.DataPropertyName = "depositnumber";
            this.DepID.HeaderText = "DepositID";
            this.DepID.Name = "DepID";
            this.DepID.ReadOnly = true;
            this.DepID.Width = 79;
            // 
            // ckNum
            // 
            this.ckNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ckNum.DataPropertyName = "checknumber";
            this.ckNum.HeaderText = "Check No";
            this.ckNum.Name = "ckNum";
            this.ckNum.ReadOnly = true;
            this.ckNum.Width = 80;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Amount.DataPropertyName = "amount";
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle3;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 68;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(146, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbAdvanced
            // 
            this.gbAdvanced.Controls.Add(this.cbDepNo);
            this.gbAdvanced.Controls.Add(this.label1);
            this.gbAdvanced.Controls.Add(this.btnNew);
            this.gbAdvanced.Controls.Add(this.lblResult);
            this.gbAdvanced.Controls.Add(this.btnNow);
            this.gbAdvanced.Controls.Add(this.lblActualID);
            this.gbAdvanced.Controls.Add(this.dtpDate);
            this.gbAdvanced.Controls.Add(this.label8);
            this.gbAdvanced.Controls.Add(this.btnClear);
            this.gbAdvanced.Controls.Add(this.label14);
            this.gbAdvanced.Controls.Add(this.rtbDescr);
            this.gbAdvanced.Controls.Add(this.txtAmt);
            this.gbAdvanced.Controls.Add(this.label13);
            this.gbAdvanced.Controls.Add(this.cbUsernames);
            this.gbAdvanced.Controls.Add(this.cbSemester);
            this.gbAdvanced.Controls.Add(this.cbType);
            this.gbAdvanced.Controls.Add(this.txtCheckNo);
            this.gbAdvanced.Controls.Add(this.label12);
            this.gbAdvanced.Controls.Add(this.label11);
            this.gbAdvanced.Controls.Add(this.label9);
            this.gbAdvanced.Controls.Add(this.label7);
            this.gbAdvanced.Controls.Add(this.lblTransID);
            this.gbAdvanced.Controls.Add(this.btnUpdate);
            this.gbAdvanced.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbAdvanced.Location = new System.Drawing.Point(12, 12);
            this.gbAdvanced.Name = "gbAdvanced";
            this.gbAdvanced.Size = new System.Drawing.Size(226, 359);
            this.gbAdvanced.TabIndex = 14;
            this.gbAdvanced.TabStop = false;
            this.gbAdvanced.Text = "Advanced";
            // 
            // cbDepNo
            // 
            this.cbDepNo.FormattingEnabled = true;
            this.cbDepNo.Items.AddRange(new object[] {
            "Charge",
            "Credit",
            "Payment",
            "Refund"});
            this.cbDepNo.Location = new System.Drawing.Point(87, 193);
            this.cbDepNo.Name = "cbDepNo";
            this.cbDepNo.Size = new System.Drawing.Size(129, 21);
            this.cbDepNo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Deposit No.";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Green;
            this.btnNew.Location = new System.Drawing.Point(163, 323);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(55, 23);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New...";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Maroon;
            this.lblResult.Location = new System.Drawing.Point(10, 333);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 23;
            // 
            // btnNow
            // 
            this.btnNow.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNow.ForeColor = System.Drawing.Color.Black;
            this.btnNow.Location = new System.Drawing.Point(173, 107);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(44, 23);
            this.btnNow.TabIndex = 4;
            this.btnNow.Text = "Now";
            this.btnNow.UseVisualStyleBackColor = false;
            this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // lblActualID
            // 
            this.lblActualID.AutoSize = true;
            this.lblActualID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblActualID.Location = new System.Drawing.Point(88, 22);
            this.lblActualID.Name = "lblActualID";
            this.lblActualID.Size = new System.Drawing.Size(0, 16);
            this.lblActualID.TabIndex = 21;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(89, 108);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(81, 20);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.Value = new System.DateTime(2012, 4, 3, 11, 37, 2, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Date";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(90, 323);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(55, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(10, 255);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Description";
            // 
            // rtbDescr
            // 
            this.rtbDescr.Location = new System.Drawing.Point(87, 255);
            this.rtbDescr.Name = "rtbDescr";
            this.rtbDescr.Size = new System.Drawing.Size(130, 62);
            this.rtbDescr.TabIndex = 9;
            this.rtbDescr.Text = "";
            // 
            // txtAmt
            // 
            this.txtAmt.Location = new System.Drawing.Point(89, 74);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(128, 20);
            this.txtAmt.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(10, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Amount";
            // 
            // cbUsernames
            // 
            this.cbUsernames.FormattingEnabled = true;
            this.cbUsernames.Location = new System.Drawing.Point(89, 48);
            this.cbUsernames.Name = "cbUsernames";
            this.cbUsernames.Size = new System.Drawing.Size(129, 21);
            this.cbUsernames.TabIndex = 1;
            // 
            // cbSemester
            // 
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Location = new System.Drawing.Point(88, 166);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(129, 21);
            this.cbSemester.TabIndex = 6;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Charge",
            "Credit",
            "Payment",
            "Refund"});
            this.cbType.Location = new System.Drawing.Point(89, 140);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(129, 21);
            this.cbType.TabIndex = 5;
            // 
            // txtCheckNo
            // 
            this.txtCheckNo.Location = new System.Drawing.Point(87, 220);
            this.txtCheckNo.Name = "txtCheckNo";
            this.txtCheckNo.Size = new System.Drawing.Size(129, 20);
            this.txtCheckNo.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(10, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(10, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Semester";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(10, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Check No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Username";
            // 
            // lblTransID
            // 
            this.lblTransID.AutoSize = true;
            this.lblTransID.ForeColor = System.Drawing.Color.Black;
            this.lblTransID.Location = new System.Drawing.Point(10, 25);
            this.lblTransID.Name = "lblTransID";
            this.lblTransID.Size = new System.Drawing.Size(77, 13);
            this.lblTransID.TabIndex = 0;
            this.lblTransID.Text = "Transaction ID";
            // 
            // txtDepID
            // 
            this.txtDepID.Location = new System.Drawing.Point(87, 12);
            this.txtDepID.Name = "txtDepID";
            this.txtDepID.Size = new System.Drawing.Size(129, 20);
            this.txtDepID.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(7, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Deposit ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // lblDepDate
            // 
            this.lblDepDate.AutoSize = true;
            this.lblDepDate.ForeColor = System.Drawing.Color.Black;
            this.lblDepDate.Location = new System.Drawing.Point(7, 44);
            this.lblDepDate.Name = "lblDepDate";
            this.lblDepDate.Size = new System.Drawing.Size(69, 13);
            this.lblDepDate.TabIndex = 27;
            this.lblDepDate.Text = "Deposit Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDepResult);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnSaveDep);
            this.groupBox1.Controls.Add(this.txtDepID);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblDepDate);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 461);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 100);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deposits";
            // 
            // lblDepResult
            // 
            this.lblDepResult.AutoSize = true;
            this.lblDepResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepResult.ForeColor = System.Drawing.Color.Maroon;
            this.lblDepResult.Location = new System.Drawing.Point(10, 69);
            this.lblDepResult.Name = "lblDepResult";
            this.lblDepResult.Size = new System.Drawing.Size(0, 13);
            this.lblDepResult.TabIndex = 30;
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(823, 592);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbFunct);
            this.Controls.Add(this.gbAdvanced);
            this.Controls.Add(this.gridTransactions);
            this.Controls.Add(this.gbOps);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(839, 630);
            this.MinimumSize = new System.Drawing.Size(839, 630);
            this.Name = "TransactionsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.TransactionsForm_Load);
            this.gbFunct.ResumeLayout(false);
            this.gbOps.ResumeLayout(false);
            this.gbOps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).EndInit();
            this.gbAdvanced.ResumeLayout(false);
            this.gbAdvanced.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnMemberTrans;
        private System.Windows.Forms.ComboBox cbMembers;
        private System.Windows.Forms.GroupBox gbFunct;
        private System.Windows.Forms.RadioButton rbActiveMembers;
        private System.Windows.Forms.RadioButton rbAllMembers;
        private System.Windows.Forms.GroupBox gbOps;
        private System.Windows.Forms.DataGridView gridTransactions;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTotalRecs;
        private System.Windows.Forms.Label lblTableLoaded;
        private System.Windows.Forms.GroupBox gbAdvanced;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTransID;
        private System.Windows.Forms.Button btnDeposits;
        private System.Windows.Forms.TextBox txtTotalRecs;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbUsernames;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txtCheckNo;
        private System.Windows.Forms.TextBox txtDepID;
        private System.Windows.Forms.Label lblActualID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox rtbDescr;
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSaveDep;
        private System.Windows.Forms.ComboBox cbDepNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDepDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChrgFees;
        private System.Windows.Forms.Label lblDepResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}