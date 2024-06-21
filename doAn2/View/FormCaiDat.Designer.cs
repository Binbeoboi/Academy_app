namespace doAn2.View
{
    partial class FormCaiDat
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSuaTaiKhoan = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnThemTaiKhoan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoaTaiKhoan = new System.Windows.Forms.Button();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTaiKhoanMatKhau = new System.Windows.Forms.DataGridView();
            this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemMonHoc = new System.Windows.Forms.Button();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.btnXoaMonHoc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSuaMonHoc = new System.Windows.Forms.Button();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.dgvTheLoai = new System.Windows.Forms.DataGridView();
            this.ColuSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLuongCoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thốngKếĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêCôngNợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanMatKhau)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.dgvTaiKhoanMatKhau);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.dgvTheLoai);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1466, 712);
            this.splitContainer1.SplitterDistance = 723;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSuaTaiKhoan);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.btnThemTaiKhoan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnXoaTaiKhoan);
            this.groupBox1.Controls.Add(this.txtTaiKhoan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 344);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xử lý thông tin tài khoản";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSuaTaiKhoan
            // 
            this.btnSuaTaiKhoan.Location = new System.Drawing.Point(525, 157);
            this.btnSuaTaiKhoan.Name = "btnSuaTaiKhoan";
            this.btnSuaTaiKhoan.Size = new System.Drawing.Size(108, 55);
            this.btnSuaTaiKhoan.TabIndex = 7;
            this.btnSuaTaiKhoan.Text = "Sửa";
            this.btnSuaTaiKhoan.UseVisualStyleBackColor = true;
            this.btnSuaTaiKhoan.Click += new System.EventHandler(this.btnSuaTaiKhoan_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(525, 54);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(140, 27);
            this.txtMatKhau.TabIndex = 4;
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(78, 157);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(108, 55);
            this.btnThemTaiKhoan.TabIndex = 5;
            this.btnThemTaiKhoan.Text = "Thêm";
            this.btnThemTaiKhoan.UseVisualStyleBackColor = true;
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(302, 157);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(108, 55);
            this.btnXoaTaiKhoan.TabIndex = 6;
            this.btnXoaTaiKhoan.Text = "Xóa";
            this.btnXoaTaiKhoan.UseVisualStyleBackColor = true;
            this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(148, 54);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(135, 27);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản";
            // 
            // dgvTaiKhoanMatKhau
            // 
            this.dgvTaiKhoanMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTaiKhoanMatKhau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoanMatKhau.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dgvTaiKhoanMatKhau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoanMatKhau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSTT,
            this.ColTaiKhoan,
            this.ColMatKhau});
            this.dgvTaiKhoanMatKhau.Location = new System.Drawing.Point(0, 35);
            this.dgvTaiKhoanMatKhau.Name = "dgvTaiKhoanMatKhau";
            this.dgvTaiKhoanMatKhau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoanMatKhau.Size = new System.Drawing.Size(723, 333);
            this.dgvTaiKhoanMatKhau.TabIndex = 0;
            this.dgvTaiKhoanMatKhau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoanMatKhau_CellClick);
            // 
            // ColSTT
            // 
            this.ColSTT.HeaderText = "Số thư tự";
            this.ColSTT.Name = "ColSTT";
            this.ColSTT.ReadOnly = true;
            // 
            // ColTaiKhoan
            // 
            this.ColTaiKhoan.HeaderText = "Tài khoản";
            this.ColTaiKhoan.Name = "ColTaiKhoan";
            // 
            // ColMatKhau
            // 
            this.ColMatKhau.HeaderText = "Mật khẩu";
            this.ColMatKhau.Name = "ColMatKhau";
            this.ColMatKhau.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnThemMonHoc);
            this.groupBox2.Controls.Add(this.txtLuongCB);
            this.groupBox2.Controls.Add(this.btnXoaMonHoc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnSuaMonHoc);
            this.groupBox2.Controls.Add(this.txtTenMonHoc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMaMonHoc);
            this.groupBox2.Location = new System.Drawing.Point(0, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 344);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xử lý thông tin môn học";
            // 
            // btnThemMonHoc
            // 
            this.btnThemMonHoc.Location = new System.Drawing.Point(82, 157);
            this.btnThemMonHoc.Name = "btnThemMonHoc";
            this.btnThemMonHoc.Size = new System.Drawing.Size(108, 55);
            this.btnThemMonHoc.TabIndex = 9;
            this.btnThemMonHoc.Text = "Thêm";
            this.btnThemMonHoc.UseVisualStyleBackColor = true;
            this.btnThemMonHoc.Click += new System.EventHandler(this.btnThemMonHoc_Click);
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Location = new System.Drawing.Point(563, 48);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(119, 27);
            this.txtLuongCB.TabIndex = 13;
            // 
            // btnXoaMonHoc
            // 
            this.btnXoaMonHoc.Location = new System.Drawing.Point(317, 157);
            this.btnXoaMonHoc.Name = "btnXoaMonHoc";
            this.btnXoaMonHoc.Size = new System.Drawing.Size(108, 55);
            this.btnXoaMonHoc.TabIndex = 10;
            this.btnXoaMonHoc.Text = "Xóa";
            this.btnXoaMonHoc.UseVisualStyleBackColor = true;
            this.btnXoaMonHoc.Click += new System.EventHandler(this.btnXoaMonHoc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(486, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lương";
            // 
            // btnSuaMonHoc
            // 
            this.btnSuaMonHoc.Location = new System.Drawing.Point(563, 157);
            this.btnSuaMonHoc.Name = "btnSuaMonHoc";
            this.btnSuaMonHoc.Size = new System.Drawing.Size(108, 55);
            this.btnSuaMonHoc.TabIndex = 11;
            this.btnSuaMonHoc.Text = "Sửa";
            this.btnSuaMonHoc.UseVisualStyleBackColor = true;
            this.btnSuaMonHoc.Click += new System.EventHandler(this.btnSuaMonHoc_Click);
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Location = new System.Drawing.Point(308, 50);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(119, 27);
            this.txtTenMonHoc.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên";
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Location = new System.Drawing.Point(79, 51);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(121, 27);
            this.txtMaMonHoc.TabIndex = 6;
            // 
            // dgvTheLoai
            // 
            this.dgvTheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTheLoai.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColuSTT,
            this.ColMaMon,
            this.ColTenMon,
            this.ColLuongCoBan});
            this.dgvTheLoai.Location = new System.Drawing.Point(0, 35);
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheLoai.Size = new System.Drawing.Size(739, 333);
            this.dgvTheLoai.TabIndex = 1;
            this.dgvTheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheLoai_CellClick);
            this.dgvTheLoai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheLoai_CellContentClick);
            // 
            // ColuSTT
            // 
            this.ColuSTT.DataPropertyName = "STT";
            this.ColuSTT.HeaderText = "Số thứ tự";
            this.ColuSTT.Name = "ColuSTT";
            this.ColuSTT.ReadOnly = true;
            // 
            // ColMaMon
            // 
            this.ColMaMon.DataPropertyName = "Ma";
            this.ColMaMon.HeaderText = "Mã môn học";
            this.ColMaMon.Name = "ColMaMon";
            this.ColMaMon.ReadOnly = true;
            // 
            // ColTenMon
            // 
            this.ColTenMon.DataPropertyName = "Ten";
            this.ColTenMon.HeaderText = "Tên môn học";
            this.ColTenMon.Name = "ColTenMon";
            this.ColTenMon.ReadOnly = true;
            // 
            // ColLuongCoBan
            // 
            this.ColLuongCoBan.DataPropertyName = "LuongCB";
            this.ColLuongCoBan.HeaderText = "Lương cơ bản";
            this.ColLuongCoBan.Name = "ColLuongCoBan";
            this.ColLuongCoBan.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKếĐiểmToolStripMenuItem,
            this.thốngKêCôngNợToolStripMenuItem,
            this.thốngKêHọcSinhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thốngKếĐiểmToolStripMenuItem
            // 
            this.thốngKếĐiểmToolStripMenuItem.Name = "thốngKếĐiểmToolStripMenuItem";
            this.thốngKếĐiểmToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.thốngKếĐiểmToolStripMenuItem.Text = "Thống kế điểm";
            this.thốngKếĐiểmToolStripMenuItem.Click += new System.EventHandler(this.thốngKếĐiểmToolStripMenuItem_Click);
            // 
            // thốngKêCôngNợToolStripMenuItem
            // 
            this.thốngKêCôngNợToolStripMenuItem.Name = "thốngKêCôngNợToolStripMenuItem";
            this.thốngKêCôngNợToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.thốngKêCôngNợToolStripMenuItem.Text = "Thống kê công nợ";
            this.thốngKêCôngNợToolStripMenuItem.Click += new System.EventHandler(this.thốngKêCôngNợToolStripMenuItem_Click);
            // 
            // thốngKêHọcSinhToolStripMenuItem
            // 
            this.thốngKêHọcSinhToolStripMenuItem.Name = "thốngKêHọcSinhToolStripMenuItem";
            this.thốngKêHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.thốngKêHọcSinhToolStripMenuItem.Text = "Thống kê học sinh";
            this.thốngKêHọcSinhToolStripMenuItem.Click += new System.EventHandler(this.thốngKêHọcSinhToolStripMenuItem_Click);
            // 
            // FormCaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1466, 712);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCaiDat";
            this.Text = "FormCaiDat";
            this.Load += new System.EventHandler(this.FormCaiDat_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanMatKhau)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvTaiKhoanMatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMatKhau;
        private System.Windows.Forms.DataGridView dgvTheLoai;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSuaTaiKhoan;
        private System.Windows.Forms.Button btnXoaTaiKhoan;
        private System.Windows.Forms.Button btnThemTaiKhoan;
        private System.Windows.Forms.Button btnSuaMonHoc;
        private System.Windows.Forms.Button btnXoaMonHoc;
        private System.Windows.Forms.Button btnThemMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLuongCoBan;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thốngKếĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêCôngNợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêHọcSinhToolStripMenuItem;
    }
}