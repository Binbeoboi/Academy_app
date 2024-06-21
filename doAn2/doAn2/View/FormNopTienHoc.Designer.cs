namespace doAn2.View
{
    partial class FormNopTienHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNopTienHoc));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBody = new System.Windows.Forms.Panel();
            this.btnNop = new System.Windows.Forms.Button();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtSoTienNop = new System.Windows.Forms.TextBox();
            this.lblSoTienCanNop = new System.Windows.Forms.Label();
            this.lblTongCongNo = new System.Windows.Forms.Label();
            this.cbbSinhVien = new System.Windows.Forms.ComboBox();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBody.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1466, 712);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelBody
            // 
            this.panelBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.panelBody.Controls.Add(this.btnNop);
            this.panelBody.Controls.Add(this.btnKiemTra);
            this.panelBody.Controls.Add(this.label4);
            this.panelBody.Controls.Add(this.label3);
            this.panelBody.Controls.Add(this.label);
            this.panelBody.Controls.Add(this.txtSoTienNop);
            this.panelBody.Controls.Add(this.lblSoTienCanNop);
            this.panelBody.Controls.Add(this.lblTongCongNo);
            this.panelBody.Controls.Add(this.cbbSinhVien);
            this.panelBody.Controls.Add(this.cbbLop);
            this.panelBody.Controls.Add(this.label1);
            this.panelBody.Location = new System.Drawing.Point(8, 6);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(825, 538);
            this.panelBody.TabIndex = 1;
            this.panelBody.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnNop
            // 
            this.btnNop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.btnNop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNop.ForeColor = System.Drawing.Color.White;
            this.btnNop.Location = new System.Drawing.Point(286, 423);
            this.btnNop.Name = "btnNop";
            this.btnNop.Size = new System.Drawing.Size(259, 55);
            this.btnNop.TabIndex = 10;
            this.btnNop.Text = "Nộp tiền";
            this.btnNop.UseVisualStyleBackColor = false;
            this.btnNop.Click += new System.EventHandler(this.btnNop_Click);
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKiemTra.BackColor = System.Drawing.Color.Firebrick;
            this.btnKiemTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiemTra.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemTra.ForeColor = System.Drawing.Color.White;
            this.btnKiemTra.Location = new System.Drawing.Point(431, 194);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(114, 42);
            this.btnKiemTra.TabIndex = 9;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = false;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(167, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số tiền nộp";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(189, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Học viên";
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(229, 69);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 25);
            this.label.TabIndex = 6;
            this.label.Text = "Lớp";
            // 
            // txtSoTienNop
            // 
            this.txtSoTienNop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoTienNop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoTienNop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienNop.Location = new System.Drawing.Point(284, 371);
            this.txtSoTienNop.Name = "txtSoTienNop";
            this.txtSoTienNop.Size = new System.Drawing.Size(259, 33);
            this.txtSoTienNop.TabIndex = 5;
            // 
            // lblSoTienCanNop
            // 
            this.lblSoTienCanNop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoTienCanNop.AutoSize = true;
            this.lblSoTienCanNop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTienCanNop.ForeColor = System.Drawing.Color.White;
            this.lblSoTienCanNop.Location = new System.Drawing.Point(282, 301);
            this.lblSoTienCanNop.Name = "lblSoTienCanNop";
            this.lblSoTienCanNop.Size = new System.Drawing.Size(80, 25);
            this.lblSoTienCanNop.TabIndex = 4;
            this.lblSoTienCanNop.Text = "Phải trả";
            // 
            // lblTongCongNo
            // 
            this.lblTongCongNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTongCongNo.AutoSize = true;
            this.lblTongCongNo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongCongNo.ForeColor = System.Drawing.Color.White;
            this.lblTongCongNo.Location = new System.Drawing.Point(282, 256);
            this.lblTongCongNo.Name = "lblTongCongNo";
            this.lblTongCongNo.Size = new System.Drawing.Size(138, 25);
            this.lblTongCongNo.TabIndex = 3;
            this.lblTongCongNo.Text = "Tổng công nợ";
            // 
            // cbbSinhVien
            // 
            this.cbbSinhVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbSinhVien.DisplayMember = "Ten";
            this.cbbSinhVien.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSinhVien.FormattingEnabled = true;
            this.cbbSinhVien.Location = new System.Drawing.Point(286, 131);
            this.cbbSinhVien.Name = "cbbSinhVien";
            this.cbbSinhVien.Size = new System.Drawing.Size(259, 33);
            this.cbbSinhVien.TabIndex = 2;
            this.cbbSinhVien.ValueMember = "Ma";
            this.cbbSinhVien.TextChanged += new System.EventHandler(this.cbbSinhVien_TextChanged);
            // 
            // cbbLop
            // 
            this.cbbLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbLop.DisplayMember = "Ten";
            this.cbbLop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(286, 69);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(259, 33);
            this.cbbLop.TabIndex = 1;
            this.cbbLop.ValueMember = "Ma";
            this.cbbLop.TextChanged += new System.EventHandler(this.cbbLop_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "XỬ LÝ CÔNG NỢ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panelBody);
            this.panel1.Location = new System.Drawing.Point(318, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 550);
            this.panel1.TabIndex = 2;
            // 
            // FormNopTienHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1466, 712);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormNopTienHoc";
            this.Text = "FormNopTienHoc";
            this.Load += new System.EventHandler(this.FormNopTienHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label lblSoTienCanNop;
        private System.Windows.Forms.Label lblTongCongNo;
        private System.Windows.Forms.ComboBox cbbSinhVien;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoTienNop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Button btnNop;
        private System.Windows.Forms.Panel panel1;
    }
}