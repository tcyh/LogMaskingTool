namespace LogMaskingTool
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowseLogDir = new System.Windows.Forms.Button();
            this.dgvTerms = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseOutDir = new System.Windows.Forms.Button();
            this.tbOutbox = new System.Windows.Forms.TextBox();
            this.lblOutbox = new System.Windows.Forms.Label();
            this.tbInbox = new System.Windows.Forms.TextBox();
            this.lblInbox = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbLogs = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRunMasking = new System.Windows.Forms.Button();
            this.TermType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            //this.Orignal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //this.Replacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerms)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // btnBrowseLogDir
            // 
            this.btnBrowseLogDir.Location = new System.Drawing.Point(1791, 29);
            this.btnBrowseLogDir.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnBrowseLogDir.Name = "btnBrowseLogDir";
            this.btnBrowseLogDir.Size = new System.Drawing.Size(155, 42);
            this.btnBrowseLogDir.TabIndex = 1;
            this.btnBrowseLogDir.Text = "Browse";
            this.btnBrowseLogDir.UseVisualStyleBackColor = true;
            this.btnBrowseLogDir.Click += new System.EventHandler(this.btnBrowseLogDir_Click);
            // 
            // dgvTerms
            // 
            this.dgvTerms.AllowUserToResizeColumns = false;
            this.dgvTerms.AllowUserToResizeRows = false;
            this.dgvTerms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTerms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.dgvTerms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            //this.TermType,
            //this.Orignal,
            //this.Replacement
            //});
            this.dgvTerms.Location = new System.Drawing.Point(16, 34);
            this.dgvTerms.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvTerms.Name = "dgvTerms";
            this.dgvTerms.Size = new System.Drawing.Size(1929, 346);
            this.dgvTerms.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowseOutDir);
            this.groupBox1.Controls.Add(this.tbOutbox);
            this.groupBox1.Controls.Add(this.lblOutbox);
            this.groupBox1.Controls.Add(this.btnBrowseLogDir);
            this.groupBox1.Controls.Add(this.tbInbox);
            this.groupBox1.Controls.Add(this.lblInbox);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1955, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Directory of Log Files:";
            // 
            // btnBrowseOutDir
            // 
            this.btnBrowseOutDir.Location = new System.Drawing.Point(1791, 75);
            this.btnBrowseOutDir.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnBrowseOutDir.Name = "btnBrowseOutDir";
            this.btnBrowseOutDir.Size = new System.Drawing.Size(155, 42);
            this.btnBrowseOutDir.TabIndex = 20;
            this.btnBrowseOutDir.Text = "Browse";
            this.btnBrowseOutDir.UseVisualStyleBackColor = true;
            // 
            // tbOutbox
            // 
            this.tbOutbox.Enabled = false;
            this.tbOutbox.Location = new System.Drawing.Point(144, 80);
            this.tbOutbox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tbOutbox.Name = "tbOutbox";
            this.tbOutbox.ReadOnly = true;
            this.tbOutbox.Size = new System.Drawing.Size(1633, 31);
            this.tbOutbox.TabIndex = 19;
            // 
            // lblOutbox
            // 
            this.lblOutbox.AutoSize = true;
            this.lblOutbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutbox.Location = new System.Drawing.Point(11, 72);
            this.lblOutbox.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblOutbox.Name = "lblOutbox";
            this.lblOutbox.Size = new System.Drawing.Size(132, 37);
            this.lblOutbox.TabIndex = 18;
            this.lblOutbox.Text = "OutBox:";
            // 
            // tbInbox
            // 
            this.tbInbox.Enabled = false;
            this.tbInbox.Location = new System.Drawing.Point(144, 32);
            this.tbInbox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tbInbox.Name = "tbInbox";
            this.tbInbox.ReadOnly = true;
            this.tbInbox.Size = new System.Drawing.Size(1633, 31);
            this.tbInbox.TabIndex = 17;
            // 
            // lblInbox
            // 
            this.lblInbox.AutoSize = true;
            this.lblInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInbox.Location = new System.Drawing.Point(28, 29);
            this.lblInbox.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblInbox.Name = "lblInbox";
            this.lblInbox.Size = new System.Drawing.Size(103, 37);
            this.lblInbox.TabIndex = 16;
            this.lblInbox.Text = "Inbox:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbLogs);
            this.groupBox2.Location = new System.Drawing.Point(16, 618);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1955, 255);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logs";
            // 
            // lbLogs
            // 
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.ItemHeight = 25;
            this.lbLogs.Location = new System.Drawing.Point(8, 31);
            this.lbLogs.Margin = new System.Windows.Forms.Padding(4);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(1936, 204);
            this.lbLogs.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRunMasking);
            this.groupBox3.Controls.Add(this.dgvTerms);
            this.groupBox3.Location = new System.Drawing.Point(16, 152);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1955, 458);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Terms";
            // 
            // btnRunMasking
            // 
            this.btnRunMasking.Location = new System.Drawing.Point(1759, 390);
            this.btnRunMasking.Margin = new System.Windows.Forms.Padding(4);
            this.btnRunMasking.Name = "btnRunMasking";
            this.btnRunMasking.Size = new System.Drawing.Size(187, 60);
            this.btnRunMasking.TabIndex = 3;
            this.btnRunMasking.Text = "Run";
            this.btnRunMasking.UseVisualStyleBackColor = true;
            // 
            // TermType
            // 
            this.TermType.HeaderText = "TermType";
            this.TermType.Name = "TermType";
            //// 
            //// Orignal
            //// 
            //this.Orignal.HeaderText = "Orignal";
            //this.Orignal.Name = "Orignal";
            //// 
            //// Replacement
            //// 
            //this.Replacement.HeaderText = "Replacement";
            //this.Replacement.Name = "Replacement";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1987, 888);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "LogMaskingTool";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerms)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnBrowseLogDir;
        private System.Windows.Forms.DataGridView dgvTerms;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseOutDir;
        private System.Windows.Forms.TextBox tbOutbox;
        private System.Windows.Forms.Label lblOutbox;
        private System.Windows.Forms.TextBox tbInbox;
        private System.Windows.Forms.Label lblInbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbLogs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRunMasking;
        private System.Windows.Forms.DataGridViewComboBoxColumn TermType;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Orignal;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Replacement;
    }
}

