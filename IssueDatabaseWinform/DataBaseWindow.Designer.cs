namespace IssueDatabaseWinform
{
    partial class DataBaseWindow
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

        public void AddIssue(Ticket t)
        {
            DatabaseDataGrid.Rows.Add(t.m_isssue_IDnumber.ToString(), t.m_summary, t.m_severityGrade.ToString(), t.m_ticketStatus.ToString(), t.m_submittedByName);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DatabaseDataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Severity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmittedByName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewIssue_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DatabaseDataGrid
            // 
            this.DatabaseDataGrid.AllowUserToAddRows = false;
            this.DatabaseDataGrid.AllowUserToDeleteRows = false;
            this.DatabaseDataGrid.AllowUserToOrderColumns = true;
            this.DatabaseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatabaseDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Summary,
            this.Severity,
            this.Status,
            this.SubmittedByName});
            this.DatabaseDataGrid.Location = new System.Drawing.Point(12, 35);
            this.DatabaseDataGrid.Name = "DatabaseDataGrid";
            this.DatabaseDataGrid.ReadOnly = true;
            this.DatabaseDataGrid.Size = new System.Drawing.Size(724, 349);
            this.DatabaseDataGrid.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Summary
            // 
            this.Summary.HeaderText = "Summary";
            this.Summary.Name = "Summary";
            this.Summary.ReadOnly = true;
            this.Summary.Width = 300;
            // 
            // Severity
            // 
            this.Severity.HeaderText = "Severity";
            this.Severity.Name = "Severity";
            this.Severity.ReadOnly = true;
            this.Severity.Width = 75;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // SubmittedByName
            // 
            this.SubmittedByName.HeaderText = "Submitted By";
            this.SubmittedByName.Name = "SubmittedByName";
            this.SubmittedByName.ReadOnly = true;
            // 
            // NewIssue_Button
            // 
            this.NewIssue_Button.Location = new System.Drawing.Point(12, 6);
            this.NewIssue_Button.Name = "NewIssue_Button";
            this.NewIssue_Button.Size = new System.Drawing.Size(75, 23);
            this.NewIssue_Button.TabIndex = 1;
            this.NewIssue_Button.Text = "New Issue";
            this.NewIssue_Button.UseVisualStyleBackColor = true;
            this.NewIssue_Button.Click += new System.EventHandler(this.NewIssue_Button_Click);
            // 
            // DataBaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 396);
            this.Controls.Add(this.NewIssue_Button);
            this.Controls.Add(this.DatabaseDataGrid);
            this.Name = "DataBaseWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DatabaseDataGrid;
        private System.Windows.Forms.Button NewIssue_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Severity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubmittedByName;
    }
}

