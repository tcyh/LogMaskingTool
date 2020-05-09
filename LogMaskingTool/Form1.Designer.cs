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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbLogs = new System.Windows.Forms.ListBox();
            this.btnRunMasking = new System.Windows.Forms.Button();
            this.tbOutbox = new System.Windows.Forms.TextBox();
            this.lblOutbox = new System.Windows.Forms.Label();
            this.tbInbox = new System.Windows.Forms.TextBox();
            this.lblInbox = new System.Windows.Forms.Label();
            this.btnBrowseOutDir = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Orignal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Replaced = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnBrowseLogDir.Location = new System.Drawing.Point(1343, 23);
            this.btnBrowseLogDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseLogDir.Name = "btnBrowseLogDir";
            this.btnBrowseLogDir.Size = new System.Drawing.Size(116, 34);
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
            this.dgvTerms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Orignal,
            this.Replaced});
            this.dgvTerms.Location = new System.Drawing.Point(12, 27);
            this.dgvTerms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTerms.Name = "dgvTerms";
            this.dgvTerms.Size = new System.Drawing.Size(1447, 277);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1466, 104);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Directory of Log Files:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbLogs);
            this.groupBox2.Location = new System.Drawing.Point(12, 494);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1466, 204);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logs";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRunMasking);
            this.groupBox3.Controls.Add(this.dgvTerms);
            this.groupBox3.Location = new System.Drawing.Point(12, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1466, 366);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Terms";
            // 
            // lbLogs
            // 
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.ItemHeight = 20;
            this.lbLogs.Location = new System.Drawing.Point(6, 25);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(1453, 164);
            this.lbLogs.TabIndex = 0;
            // 
            // btnRunMasking
            // 
            this.btnRunMasking.Location = new System.Drawing.Point(1319, 312);
            this.btnRunMasking.Name = "btnRunMasking";
            this.btnRunMasking.Size = new System.Drawing.Size(140, 48);
            this.btnRunMasking.TabIndex = 3;
            this.btnRunMasking.Text = "Run";
            this.btnRunMasking.UseVisualStyleBackColor = true;
            // 
            // tbOutbox
            // 
            this.tbOutbox.Enabled = false;
            this.tbOutbox.Location = new System.Drawing.Point(108, 64);
            this.tbOutbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbOutbox.Name = "tbOutbox";
            this.tbOutbox.ReadOnly = true;
            this.tbOutbox.Size = new System.Drawing.Size(1226, 26);
            this.tbOutbox.TabIndex = 19;
            // 
            // lblOutbox
            // 
            this.lblOutbox.AutoSize = true;
            this.lblOutbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutbox.Location = new System.Drawing.Point(8, 58);
            this.lblOutbox.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOutbox.Name = "lblOutbox";
            this.lblOutbox.Size = new System.Drawing.Size(98, 29);
            this.lblOutbox.TabIndex = 18;
            this.lblOutbox.Text = "OutBox:";
            // 
            // tbInbox
            // 
            this.tbInbox.Enabled = false;
            this.tbInbox.Location = new System.Drawing.Point(108, 26);
            this.tbInbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbInbox.Name = "tbInbox";
            this.tbInbox.ReadOnly = true;
            this.tbInbox.Size = new System.Drawing.Size(1226, 26);
            this.tbInbox.TabIndex = 17;
            // 
            // lblInbox
            // 
            this.lblInbox.AutoSize = true;
            this.lblInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInbox.Location = new System.Drawing.Point(21, 23);
            this.lblInbox.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInbox.Name = "lblInbox";
            this.lblInbox.Size = new System.Drawing.Size(77, 29);
            this.lblInbox.TabIndex = 16;
            this.lblInbox.Text = "Inbox:";
            // 
            // btnBrowseOutDir
            // 
            this.btnBrowseOutDir.Location = new System.Drawing.Point(1343, 60);
            this.btnBrowseOutDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseOutDir.Name = "btnBrowseOutDir";
            this.btnBrowseOutDir.Size = new System.Drawing.Size(116, 34);
            this.btnBrowseOutDir.TabIndex = 20;
            this.btnBrowseOutDir.Text = "Browse";
            this.btnBrowseOutDir.UseVisualStyleBackColor = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Orignal
            // 
            this.Orignal.HeaderText = "Orignal";
            this.Orignal.Name = "Orignal";
            // 
            // Replaced
            // 
            this.Replaced.HeaderText = "Replaced";
            this.Replaced.Name = "Replaced";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 710);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orignal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Replaced;
    }
}

