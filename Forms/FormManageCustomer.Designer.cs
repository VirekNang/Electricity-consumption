namespace Electricity.Forms
{
    partial class FormManageCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.cmbPowerConnection = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.picSearch1 = new System.Windows.Forms.PictureBox();
            this.picExit1 = new System.Windows.Forms.PictureBox();
            this.dtgManageCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgManageCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ស្វែងរក";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(80, 11);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 28);
            this.txtSearch.TabIndex = 80;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.linkLabel4);
            this.pnHeader.Controls.Add(this.cmbPowerConnection);
            this.pnHeader.Controls.Add(this.cmbCategory);
            this.pnHeader.Controls.Add(this.picSearch1);
            this.pnHeader.Controls.Add(this.picExit1);
            this.pnHeader.Controls.Add(this.txtSearch);
            this.pnHeader.Controls.Add(this.label1);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1556, 48);
            this.pnHeader.TabIndex = 83;
            // 
            // linkLabel4
            // 
            this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkColor = System.Drawing.Color.Black;
            this.linkLabel4.Location = new System.Drawing.Point(1453, 11);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(44, 25);
            this.linkLabel4.TabIndex = 278;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "កែប្រែ";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // cmbPowerConnection
            // 
            this.cmbPowerConnection.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPowerConnection.FormattingEnabled = true;
            this.cmbPowerConnection.Items.AddRange(new object[] {
            "គ្រប់ប្រភេទ"});
            this.cmbPowerConnection.Location = new System.Drawing.Point(399, 11);
            this.cmbPowerConnection.Name = "cmbPowerConnection";
            this.cmbPowerConnection.Size = new System.Drawing.Size(139, 30);
            this.cmbPowerConnection.TabIndex = 86;
            this.cmbPowerConnection.Text = "គ្រប់ប្រភេទភ្ជាប់ចរន្ត";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "គ្រប់ប្រភេទ"});
            this.cmbCategory.Location = new System.Drawing.Point(254, 11);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(139, 30);
            this.cmbCategory.TabIndex = 85;
            this.cmbCategory.Text = "គ្រប់ប្រភេទ";
            // 
            // picSearch1
            // 
            this.picSearch1.BackColor = System.Drawing.Color.White;
            this.picSearch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearch1.Image = global::Electricity.Properties.Resources.loupe;
            this.picSearch1.Location = new System.Drawing.Point(223, 18);
            this.picSearch1.Margin = new System.Windows.Forms.Padding(2);
            this.picSearch1.Name = "picSearch1";
            this.picSearch1.Size = new System.Drawing.Size(19, 15);
            this.picSearch1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch1.TabIndex = 84;
            this.picSearch1.TabStop = false;
            // 
            // picExit1
            // 
            this.picExit1.BackColor = System.Drawing.Color.White;
            this.picExit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit1.Image = global::Electricity.Properties.Resources.reject1;
            this.picExit1.Location = new System.Drawing.Point(223, 18);
            this.picExit1.Margin = new System.Windows.Forms.Padding(2);
            this.picExit1.Name = "picExit1";
            this.picExit1.Size = new System.Drawing.Size(19, 15);
            this.picExit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit1.TabIndex = 83;
            this.picExit1.TabStop = false;
            this.picExit1.Click += new System.EventHandler(this.picExit_Click);
            // 
            // dtgManageCustomer
            // 
            this.dtgManageCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgManageCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgManageCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgManageCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column3,
            this.HiredDate,
            this.Address});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgManageCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgManageCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgManageCustomer.GridColor = System.Drawing.SystemColors.Control;
            this.dtgManageCustomer.Location = new System.Drawing.Point(0, 48);
            this.dtgManageCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.dtgManageCustomer.Name = "dtgManageCustomer";
            this.dtgManageCustomer.ReadOnly = true;
            this.dtgManageCustomer.RowHeadersVisible = false;
            this.dtgManageCustomer.RowHeadersWidth = 51;
            this.dtgManageCustomer.RowTemplate.Height = 100;
            this.dtgManageCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgManageCustomer.Size = new System.Drawing.Size(1556, 796);
            this.dtgManageCustomer.TabIndex = 84;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ល.រ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ឈ្មោះអតិថិជន";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ការភ្ជាប់ចរន្ត";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "តំបន់";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "បង្គោល";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // HiredDate
            // 
            this.HiredDate.HeaderText = "នាឡិកាស្ទង់";
            this.HiredDate.MinimumWidth = 6;
            this.HiredDate.Name = "HiredDate";
            this.HiredDate.ReadOnly = true;
            this.HiredDate.Width = 200;
            // 
            // Address
            // 
            this.Address.HeaderText = "លេខទូរស័ព្ទ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 200;
            // 
            // FormManageCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1556, 844);
            this.Controls.Add(this.dtgManageCustomer);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManageCustomer";
            this.Text = "FormManageCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgManageCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.DataGridView dtgManageCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn HiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.PictureBox picSearch1;
        private System.Windows.Forms.PictureBox picExit1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbPowerConnection;
        private System.Windows.Forms.LinkLabel linkLabel4;
    }
}