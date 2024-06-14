namespace ApartmentMini_Management_System
{
    partial class thongTinKh
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.aPARTMENTDataSet = new ApartmentMini_Management_System.APARTMENTDataSet();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGTableAdapter = new ApartmentMini_Management_System.APARTMENTDataSetTableAdapters.KHACHHANGTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hdButton4 = new CustomControls.RJControls.HDButton();
            this.hdButton3 = new CustomControls.RJControls.HDButton();
            this.hdButton2 = new CustomControls.RJControls.HDButton();
            this.hdButton1 = new CustomControls.RJControls.HDButton();
            ((System.ComponentModel.ISupportInitialize)(this.aPARTMENTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // aPARTMENTDataSet
            // 
            this.aPARTMENTDataSet.DataSetName = "APARTMENTDataSet";
            this.aPARTMENTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.aPARTMENTDataSet;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 526);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.mAKHDataGridViewTextBoxColumn,
            this.hOTENDataGridViewTextBoxColumn,
            this.nSDataGridViewTextBoxColumn,
            this.cCCDDataGridViewTextBoxColumn,
            this.dTDataGridViewTextBoxColumn,
            this.dCDataGridViewTextBoxColumn,
            this.gTDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.kHACHHANGBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(-67, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1218, 525);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            this.sTTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTTDataGridViewTextBoxColumn.Width = 73;
            // 
            // mAKHDataGridViewTextBoxColumn
            // 
            this.mAKHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mAKHDataGridViewTextBoxColumn.DataPropertyName = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.HeaderText = "Mã Khách hàng";
            this.mAKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAKHDataGridViewTextBoxColumn.Name = "mAKHDataGridViewTextBoxColumn";
            this.mAKHDataGridViewTextBoxColumn.Width = 174;
            // 
            // hOTENDataGridViewTextBoxColumn
            // 
            this.hOTENDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hOTENDataGridViewTextBoxColumn.DataPropertyName = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.hOTENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hOTENDataGridViewTextBoxColumn.Name = "hOTENDataGridViewTextBoxColumn";
            this.hOTENDataGridViewTextBoxColumn.Width = 99;
            // 
            // nSDataGridViewTextBoxColumn
            // 
            this.nSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nSDataGridViewTextBoxColumn.DataPropertyName = "NS";
            this.nSDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.nSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nSDataGridViewTextBoxColumn.Name = "nSDataGridViewTextBoxColumn";
            this.nSDataGridViewTextBoxColumn.Width = 126;
            // 
            // cCCDDataGridViewTextBoxColumn
            // 
            this.cCCDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cCCDDataGridViewTextBoxColumn.DataPropertyName = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.HeaderText = "Số CCCD";
            this.cCCDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cCCDDataGridViewTextBoxColumn.Name = "cCCDDataGridViewTextBoxColumn";
            this.cCCDDataGridViewTextBoxColumn.Width = 111;
            // 
            // dTDataGridViewTextBoxColumn
            // 
            this.dTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dTDataGridViewTextBoxColumn.DataPropertyName = "DT";
            this.dTDataGridViewTextBoxColumn.HeaderText = "Dân tộc";
            this.dTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dTDataGridViewTextBoxColumn.Name = "dTDataGridViewTextBoxColumn";
            this.dTDataGridViewTextBoxColumn.Width = 107;
            // 
            // dCDataGridViewTextBoxColumn
            // 
            this.dCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dCDataGridViewTextBoxColumn.DataPropertyName = "DC";
            this.dCDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.dCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dCDataGridViewTextBoxColumn.Name = "dCDataGridViewTextBoxColumn";
            this.dCDataGridViewTextBoxColumn.Width = 99;
            // 
            // gTDataGridViewCheckBoxColumn
            // 
            this.gTDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gTDataGridViewCheckBoxColumn.DataPropertyName = "GT";
            this.gTDataGridViewCheckBoxColumn.HeaderText = "Giới tính";
            this.gTDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.gTDataGridViewCheckBoxColumn.Name = "gTDataGridViewCheckBoxColumn";
            this.gTDataGridViewCheckBoxColumn.Width = 91;
            // 
            // hdButton4
            // 
            this.hdButton4.BackColor = System.Drawing.Color.White;
            this.hdButton4.BackgroundColor = System.Drawing.Color.White;
            this.hdButton4.BorderColor = System.Drawing.Color.White;
            this.hdButton4.BorderRadius = 0;
            this.hdButton4.BorderSize = 0;
            this.hdButton4.FlatAppearance.BorderSize = 0;
            this.hdButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hdButton4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.hdButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(106)))), ((int)(((byte)(130)))));
            this.hdButton4.Location = new System.Drawing.Point(726, -2);
            this.hdButton4.Name = "hdButton4";
            this.hdButton4.Size = new System.Drawing.Size(232, 47);
            this.hdButton4.TabIndex = 33;
            this.hdButton4.Text = "Thêm hợp đồng";
            this.hdButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(106)))), ((int)(((byte)(130)))));
            this.hdButton4.UseVisualStyleBackColor = false;
            this.hdButton4.Click += new System.EventHandler(this.hdButton4_Click);
            // 
            // hdButton3
            // 
            this.hdButton3.BackColor = System.Drawing.Color.White;
            this.hdButton3.BackgroundColor = System.Drawing.Color.White;
            this.hdButton3.BorderColor = System.Drawing.Color.White;
            this.hdButton3.BorderRadius = 0;
            this.hdButton3.BorderSize = 0;
            this.hdButton3.FlatAppearance.BorderSize = 0;
            this.hdButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hdButton3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.hdButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(106)))), ((int)(((byte)(130)))));
            this.hdButton3.Location = new System.Drawing.Point(488, -2);
            this.hdButton3.Name = "hdButton3";
            this.hdButton3.Size = new System.Drawing.Size(232, 47);
            this.hdButton3.TabIndex = 32;
            this.hdButton3.Text = "Thêm phòng";
            this.hdButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(106)))), ((int)(((byte)(130)))));
            this.hdButton3.UseVisualStyleBackColor = false;
            this.hdButton3.Click += new System.EventHandler(this.hdButton3_Click);
            this.hdButton3.MouseEnter += new System.EventHandler(this.hdButton3_MouseEnter);
            this.hdButton3.MouseHover += new System.EventHandler(this.hdButton3_MouseHover);
            // 
            // hdButton2
            // 
            this.hdButton2.BackColor = System.Drawing.Color.White;
            this.hdButton2.BackgroundColor = System.Drawing.Color.White;
            this.hdButton2.BorderColor = System.Drawing.Color.White;
            this.hdButton2.BorderRadius = 0;
            this.hdButton2.BorderSize = 0;
            this.hdButton2.FlatAppearance.BorderSize = 0;
            this.hdButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hdButton2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.hdButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(106)))), ((int)(((byte)(130)))));
            this.hdButton2.Location = new System.Drawing.Point(250, -2);
            this.hdButton2.Name = "hdButton2";
            this.hdButton2.Size = new System.Drawing.Size(232, 47);
            this.hdButton2.TabIndex = 31;
            this.hdButton2.Text = "Thêm khách hàng";
            this.hdButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(106)))), ((int)(((byte)(130)))));
            this.hdButton2.UseVisualStyleBackColor = false;
            this.hdButton2.Click += new System.EventHandler(this.hdButton2_Click);
            this.hdButton2.MouseEnter += new System.EventHandler(this.hdButton2_MouseEnter);
            this.hdButton2.MouseLeave += new System.EventHandler(this.hdButton2_MouseLeave);
            // 
            // hdButton1
            // 
            this.hdButton1.BackColor = System.Drawing.Color.White;
            this.hdButton1.BackgroundColor = System.Drawing.Color.White;
            this.hdButton1.BorderColor = System.Drawing.Color.White;
            this.hdButton1.BorderRadius = 0;
            this.hdButton1.BorderSize = 0;
            this.hdButton1.FlatAppearance.BorderSize = 0;
            this.hdButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hdButton1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hdButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(106)))), ((int)(((byte)(130)))));
            this.hdButton1.Location = new System.Drawing.Point(12, -2);
            this.hdButton1.Name = "hdButton1";
            this.hdButton1.Size = new System.Drawing.Size(232, 47);
            this.hdButton1.TabIndex = 1;
            this.hdButton1.Text = "Danh sách khách hàng";
            this.hdButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(106)))), ((int)(((byte)(130)))));
            this.hdButton1.UseVisualStyleBackColor = false;
            this.hdButton1.Click += new System.EventHandler(this.hdButton1_Click);
            this.hdButton1.MouseEnter += new System.EventHandler(this.hdButton1_MouseEnter);
            this.hdButton1.MouseLeave += new System.EventHandler(this.hdButton1_MouseLeave);
            // 
            // thongTinKh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1181, 708);
            this.Controls.Add(this.hdButton4);
            this.Controls.Add(this.hdButton3);
            this.Controls.Add(this.hdButton2);
            this.Controls.Add(this.hdButton1);
            this.Controls.Add(this.panel1);
            this.Name = "thongTinKh";
            this.Text = "thongTinKh";
            this.Load += new System.EventHandler(this.thongTinKh_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.thongTinKh_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.aPARTMENTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private APARTMENTDataSet aPARTMENTDataSet;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private APARTMENTDataSetTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControls.RJControls.HDButton hdButton1;
        private CustomControls.RJControls.HDButton hdButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gTDataGridViewCheckBoxColumn;
        public CustomControls.RJControls.HDButton hdButton3;
        public CustomControls.RJControls.HDButton hdButton4;
    }
}