namespace Electricity.Forms
{
    partial class FormConnectionFee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgManageCustomer = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.picSearch1 = new System.Windows.Forms.PictureBox();
            this.picExit1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgManageCustomer)).BeginInit();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgManageCustomer
            // 
            this.dtgManageCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgManageCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgManageCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgManageCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgManageCustomer.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgManageCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgManageCustomer.GridColor = System.Drawing.SystemColors.Control;
            this.dtgManageCustomer.Location = new System.Drawing.Point(0, 47);
            this.dtgManageCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.dtgManageCustomer.Name = "dtgManageCustomer";
            this.dtgManageCustomer.ReadOnly = true;
            this.dtgManageCustomer.RowHeadersVisible = false;
            this.dtgManageCustomer.RowHeadersWidth = 51;
            this.dtgManageCustomer.RowTemplate.Height = 100;
            this.dtgManageCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgManageCustomer.Size = new System.Drawing.Size(1167, 601);
            this.dtgManageCustomer.TabIndex = 86;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "អាំងតង់ស៊ីតេ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ហ្វា";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ថ្លែភ្ជាប់ចរន្ត";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(75, 9);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(154, 28);
            this.txtSearch.TabIndex = 80;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ស្វែងរក";
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.linkLabel4);
            this.pnHeader.Controls.Add(this.picSearch1);
            this.pnHeader.Controls.Add(this.picExit1);
            this.pnHeader.Controls.Add(this.txtSearch);
            this.pnHeader.Controls.Add(this.label1);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1167, 47);
            this.pnHeader.TabIndex = 85;
            // 
            // linkLabel4
            // 
            this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkColor = System.Drawing.Color.Black;
            this.linkLabel4.Location = new System.Drawing.Point(1089, 9);
            this.linkLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(44, 25);
            this.linkLabel4.TabIndex = 278;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "កែប្រែ";
            // 
            // picSearch1
            // 
            this.picSearch1.BackColor = System.Drawing.Color.White;
            this.picSearch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearch1.Image = global::Electricity.Properties.Resources.loupe;
            this.picSearch1.Location = new System.Drawing.Point(205, 15);
            this.picSearch1.Margin = new System.Windows.Forms.Padding(2);
            this.picSearch1.Name = "picSearch1";
            this.picSearch1.Size = new System.Drawing.Size(22, 16);
            this.picSearch1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch1.TabIndex = 84;
            this.picSearch1.TabStop = false;
            // 
            // picExit1
            // 
            this.picExit1.BackColor = System.Drawing.Color.White;
            this.picExit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit1.Image = global::Electricity.Properties.Resources.reject1;
            this.picExit1.Location = new System.Drawing.Point(207, 13);
            this.picExit1.Margin = new System.Windows.Forms.Padding(2);
            this.picExit1.Name = "picExit1";
            this.picExit1.Size = new System.Drawing.Size(20, 19);
            this.picExit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit1.TabIndex = 83;
            this.picExit1.TabStop = false;
            this.picExit1.Click += new System.EventHandler(this.picExit1_Click);
            // 
            // FormConnectionFee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1167, 648);
            this.Controls.Add(this.dtgManageCustomer);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormConnectionFee";
            this.Text = "FormConnectionFee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtgManageCustomer)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgManageCustomer;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.PictureBox picSearch1;
        private System.Windows.Forms.PictureBox picExit1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}