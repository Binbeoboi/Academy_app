namespace doAn2.View
{
    partial class FormChiTietLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietLopHoc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbNhapThongTinSV = new System.Windows.Forms.GroupBox();
            this.nudBuoiNghi = new System.Windows.Forms.NumericUpDown();
            this.cbbSinhVien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCongNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThongTinSV = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTuyChon = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbbTimKiemLop = new System.Windows.Forms.ComboBox();
            this.dgvChiTietLopHoc = new System.Windows.Forms.DataGridView();
            this.ColMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBuoiNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbNhapThongTinSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuoiNghi)).BeginInit();
            this.gbThongTinSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNhapThongTinSV
            // 
            this.gbNhapThongTinSV.Controls.Add(this.nudBuoiNghi);
            this.gbNhapThongTinSV.Controls.Add(this.cbbSinhVien);
            this.gbNhapThongTinSV.Controls.Add(this.label3);
            this.gbNhapThongTinSV.Controls.Add(this.cbbLop);
            this.gbNhapThongTinSV.Controls.Add(this.label8);
            this.gbNhapThongTinSV.Controls.Add(this.btnBaoCao);
            this.gbNhapThongTinSV.Controls.Add(this.btnExcel);
            this.gbNhapThongTinSV.Controls.Add(this.btnSua);
            this.gbNhapThongTinSV.Controls.Add(this.btnXoa);
            this.gbNhapThongTinSV.Controls.Add(this.btnThem);
            this.gbNhapThongTinSV.Controls.Add(this.label6);
            this.gbNhapThongTinSV.Controls.Add(this.txtCongNo);
            this.gbNhapThongTinSV.Controls.Add(this.label5);
            this.gbNhapThongTinSV.Controls.Add(this.txtMa);
            this.gbNhapThongTinSV.Controls.Add(this.label1);
            this.gbNhapThongTinSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbNhapThongTinSV.Location = new System.Drawing.Point(0, 0);
            this.gbNhapThongTinSV.Name = "gbNhapThongTinSV";
            this.gbNhapThongTinSV.Size = new System.Drawing.Size(1466, 230);
            this.gbNhapThongTinSV.TabIndex = 3;
            this.gbNhapThongTinSV.TabStop = false;
            this.gbNhapThongTinSV.Text = "Xử lý thông tin";
            // 
            // nudBuoiNghi
            // 
            this.nudBuoiNghi.Location = new System.Drawing.Point(718, 135);
            this.nudBuoiNghi.Name = "nudBuoiNghi";
            this.nudBuoiNghi.Size = new System.Drawing.Size(59, 27);
            this.nudBuoiNghi.TabIndex = 24;
            // 
            // cbbSinhVien
            // 
            this.cbbSinhVien.DisplayMember = "Ten";
            this.cbbSinhVien.FormattingEnabled = true;
            this.cbbSinhVien.Location = new System.Drawing.Point(365, 68);
            this.cbbSinhVien.Name = "cbbSinhVien";
            this.cbbSinhVien.Size = new System.Drawing.Size(169, 28);
            this.cbbSinhVien.TabIndex = 23;
            this.cbbSinhVien.ValueMember = "Ma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Học viên(*):";
            // 
            // cbbLop
            // 
            this.cbbLop.DisplayMember = "Ten";
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(364, 130);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(169, 28);
            this.cbbLop.TabIndex = 21;
            this.cbbLop.ValueMember = "Ma";
            this.cbbLop.SelectedIndexChanged += new System.EventHandler(this.cbbLop_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Lớp(*):";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaoCao.FlatAppearance.BorderSize = 3;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.ForeColor = System.Drawing.Color.Red;
            this.btnBaoCao.Location = new System.Drawing.Point(1214, 107);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(165, 35);
            this.btnBaoCao.TabIndex = 17;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.FlatAppearance.BorderSize = 3;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.ForeColor = System.Drawing.Color.Green;
            this.btnExcel.Location = new System.Drawing.Point(1214, 38);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(165, 35);
            this.btnExcel.TabIndex = 16;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSua.FlatAppearance.BorderSize = 3;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(974, 176);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(165, 35);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnXoa.FlatAppearance.BorderSize = 3;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(974, 107);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(165, 35);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnThem.FlatAppearance.BorderSize = 3;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(974, 38);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(165, 35);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Buổi nghỉ";
            // 
            // txtCongNo
            // 
            this.txtCongNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCongNo.Location = new System.Drawing.Point(711, 68);
            this.txtCongNo.Name = "txtCongNo";
            this.txtCongNo.Size = new System.Drawing.Size(160, 27);
            this.txtCongNo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(635, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Công nợ";
            // 
            // txtMa
            // 
            this.txtMa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(111, 70);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(52, 27);
            this.txtMa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã(*):";
            // 
            // gbThongTinSV
            // 
            this.gbThongTinSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbThongTinSV.Controls.Add(this.label4);
            this.gbThongTinSV.Controls.Add(this.cbbTuyChon);
            this.gbThongTinSV.Controls.Add(this.pictureBox1);
            this.gbThongTinSV.Controls.Add(this.label2);
            this.gbThongTinSV.Controls.Add(this.txtTimKiem);
            this.gbThongTinSV.Controls.Add(this.cbbTimKiemLop);
            this.gbThongTinSV.Controls.Add(this.dgvChiTietLopHoc);
            this.gbThongTinSV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinSV.Location = new System.Drawing.Point(0, 228);
            this.gbThongTinSV.Name = "gbThongTinSV";
            this.gbThongTinSV.Size = new System.Drawing.Size(1466, 484);
            this.gbThongTinSV.TabIndex = 4;
            this.gbThongTinSV.TabStop = false;
            this.gbThongTinSV.Text = "Bảng học viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tùy chọn";
            // 
            // cbbTuyChon
            // 
            this.cbbTuyChon.DisplayMember = "Ten";
            this.cbbTuyChon.FormattingEnabled = true;
            this.cbbTuyChon.Items.AddRange(new object[] {
            "Chưa hoàn tất công nợ",
            "Hoàn tất công nợ",
            "có nghỉ",
            "không nghỉ"});
            this.cbbTuyChon.Location = new System.Drawing.Point(601, 23);
            this.cbbTuyChon.Name = "cbbTuyChon";
            this.cbbTuyChon.Size = new System.Drawing.Size(209, 25);
            this.cbbTuyChon.TabIndex = 29;
            this.cbbTuyChon.ValueMember = "Ma";
            this.cbbTuyChon.SelectedIndexChanged += new System.EventHandler(this.cbTuyChon_SelectedIndexChanged);
            this.cbbTuyChon.TextChanged += new System.EventHandler(this.cbbTuyChon_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1252, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Lớp";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Location = new System.Drawing.Point(1300, 23);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(160, 25);
            this.txtTimKiem.TabIndex = 23;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cbbTimKiemLop
            // 
            this.cbbTimKiemLop.DisplayMember = "Ten";
            this.cbbTimKiemLop.FormattingEnabled = true;
            this.cbbTimKiemLop.Location = new System.Drawing.Point(46, 22);
            this.cbbTimKiemLop.Name = "cbbTimKiemLop";
            this.cbbTimKiemLop.Size = new System.Drawing.Size(149, 25);
            this.cbbTimKiemLop.TabIndex = 22;
            this.cbbTimKiemLop.ValueMember = "Ma";
            this.cbbTimKiemLop.TextChanged += new System.EventHandler(this.cbbTimKiemLop_SelectedIndexChanged);
            // 
            // dgvChiTietLopHoc
            // 
            this.dgvChiTietLopHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietLopHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChiTietLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMa,
            this.ColSV,
            this.ColLop,
            this.ColBuoiNghi,
            this.ColCongNo});
            this.dgvChiTietLopHoc.EnableHeadersVisualStyles = false;
            this.dgvChiTietLopHoc.Location = new System.Drawing.Point(3, 53);
            this.dgvChiTietLopHoc.Name = "dgvChiTietLopHoc";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietLopHoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChiTietLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietLopHoc.Size = new System.Drawing.Size(1460, 428);
            this.dgvChiTietLopHoc.TabIndex = 0;
            this.dgvChiTietLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietLopHoc_CellClick);
            // 
            // ColMa
            // 
            this.ColMa.DataPropertyName = "Ma";
            this.ColMa.HeaderText = "Mã";
            this.ColMa.Name = "ColMa";
            this.ColMa.ReadOnly = true;
            // 
            // ColSV
            // 
            this.ColSV.DataPropertyName = "TenSV";
            this.ColSV.HeaderText = "Học viên";
            this.ColSV.Name = "ColSV";
            this.ColSV.ReadOnly = true;
            // 
            // ColLop
            // 
            this.ColLop.DataPropertyName = "TenLop";
            this.ColLop.HeaderText = "Lớp học";
            this.ColLop.Name = "ColLop";
            this.ColLop.ReadOnly = true;
            // 
            // ColBuoiNghi
            // 
            this.ColBuoiNghi.DataPropertyName = "BuoiNghi";
            this.ColBuoiNghi.HeaderText = "Buổi nghỉ";
            this.ColBuoiNghi.Name = "ColBuoiNghi";
            this.ColBuoiNghi.ReadOnly = true;
            // 
            // ColCongNo
            // 
            this.ColCongNo.DataPropertyName = "CongNo";
            this.ColCongNo.HeaderText = "Công nợ";
            this.ColCongNo.Name = "ColCongNo";
            this.ColCongNo.ReadOnly = true;
            // 
            // FormChiTietLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1466, 712);
            this.Controls.Add(this.gbThongTinSV);
            this.Controls.Add(this.gbNhapThongTinSV);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormChiTietLopHoc";
            this.Text = "FormChiTietLopHoc";
            this.Load += new System.EventHandler(this.FormChiTietLopHoc_Load);
            this.gbNhapThongTinSV.ResumeLayout(false);
            this.gbNhapThongTinSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuoiNghi)).EndInit();
            this.gbThongTinSV.ResumeLayout(false);
            this.gbThongTinSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietLopHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNhapThongTinSV;
        private System.Windows.Forms.ComboBox cbbSinhVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCongNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbThongTinSV;
        private System.Windows.Forms.ComboBox cbbTimKiemLop;
        private System.Windows.Forms.DataGridView dgvChiTietLopHoc;
        private System.Windows.Forms.NumericUpDown nudBuoiNghi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTuyChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBuoiNghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCongNo;
    }
}