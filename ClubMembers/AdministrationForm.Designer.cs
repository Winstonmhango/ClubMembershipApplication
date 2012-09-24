namespace ClubMembers
{
    partial class AdministrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationForm));
            this.btnDone = new System.Windows.Forms.Button();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNewSemesterResult = new System.Windows.Forms.Label();
            this.btnAddNewSemester = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDone.Location = new System.Drawing.Point(10, 146);
            this.btnDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(67, 23);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(14, 28);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(68, 17);
            this.lblSemester.TabIndex = 25;
            this.lblSemester.Text = "Semester";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(15, 58);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 17);
            this.lblYear.TabIndex = 26;
            this.lblYear.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(102, 56);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(147, 23);
            this.txtYear.TabIndex = 2;
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(102, 25);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(147, 23);
            this.txtSemester.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResult);
            this.groupBox2.Controls.Add(this.lblNewSemesterResult);
            this.groupBox2.Controls.Add(this.btnAddNewSemester);
            this.groupBox2.Controls.Add(this.lblSemester);
            this.groupBox2.Controls.Add(this.lblYear);
            this.groupBox2.Controls.Add(this.txtSemester);
            this.groupBox2.Controls.Add(this.txtYear);
            this.groupBox2.Location = new System.Drawing.Point(10, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 129);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Semester";
            // 
            // lblNewSemesterResult
            // 
            this.lblNewSemesterResult.AutoSize = true;
            this.lblNewSemesterResult.Location = new System.Drawing.Point(14, 94);
            this.lblNewSemesterResult.Name = "lblNewSemesterResult";
            this.lblNewSemesterResult.Size = new System.Drawing.Size(0, 17);
            this.lblNewSemesterResult.TabIndex = 29;
            // 
            // btnAddNewSemester
            // 
            this.btnAddNewSemester.Location = new System.Drawing.Point(241, 94);
            this.btnAddNewSemester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewSemester.Name = "btnAddNewSemester";
            this.btnAddNewSemester.Size = new System.Drawing.Size(67, 26);
            this.btnAddNewSemester.TabIndex = 3;
            this.btnAddNewSemester.Text = "Add";
            this.btnAddNewSemester.UseVisualStyleBackColor = true;
            this.btnAddNewSemester.Click += new System.EventHandler(this.btnAddNewSemester_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.Maroon;
            this.lblResult.Location = new System.Drawing.Point(15, 99);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 30;
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButton = this.btnDone;
            this.ClientSize = new System.Drawing.Size(336, 175);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDone);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministrationForm";
            this.Text = "Administration";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddNewSemester;
        private System.Windows.Forms.Label lblNewSemesterResult;
        private System.Windows.Forms.Label lblResult;
    }
}