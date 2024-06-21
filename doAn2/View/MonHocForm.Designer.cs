namespace doAn2.View
{
    partial class MonHocForm
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
            this.dgvTheLoai = new System.Windows.Forms.DataGridView();
            this.ColuSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLuongCoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvTheLoai.Location = new System.Drawing.Point(-1, 1);
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheLoai.Size = new System.Drawing.Size(761, 383);
            this.dgvTheLoai.TabIndex = 2;
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
            this.groupBox2.Location = new System.Drawing.Point(-1, 390);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 344);
            this.groupBox2.TabIndex = 15;
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
            this.txtLuongCB.Size = new System.Drawing.Size(119, 20);
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
            this.label5.Location = new System.Drawing.Point(486, 42);
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
            this.txtTenMonHoc.Size = new System.Drawing.Size(119, 20);
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
            this.txtMaMonHoc.Size = new System.Drawing.Size(121, 20);
            this.txtMaMonHoc.TabIndex = 6;
            // 
            // MonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 688);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvTheLoai);
            this.Name = "MonHocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonHocForm";
            this.Load += new System.EventHandler(this.MonHocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColuSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLuongCoBan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemMonHoc;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Button btnXoaMonHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSuaMonHoc;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaMonHoc;
    }
}