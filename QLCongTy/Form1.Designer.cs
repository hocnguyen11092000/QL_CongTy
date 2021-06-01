
namespace QLCongTy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.tb_tienluong = new System.Windows.Forms.TextBox();
            this.tb_chucvu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtime_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.tb_tennv = new System.Windows.Forms.TextBox();
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_khoitao = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.cbsapxep = new System.Windows.Forms.ComboBox();
            this.bt_sapxep = new System.Windows.Forms.Button();
            this.bt_tongluong = new System.Windows.Forms.Button();
            this.tb_tongluong = new System.Windows.Forms.TextBox();
            this.bt_in = new System.Windows.Forms.Button();
            this.bt_thongke = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(242, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng thông tin nhân viên";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 35);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(785, 258);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.cb_gioitinh);
            this.groupBox2.Controls.Add(this.tb_tienluong);
            this.groupBox2.Controls.Add(this.tb_chucvu);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtime_ngaysinh);
            this.groupBox2.Controls.Add(this.tb_tennv);
            this.groupBox2.Controls.Add(this.tb_manv);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(242, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chỉnh sửa thông tin nhân viên";
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gioitinh.Location = new System.Drawing.Point(125, 131);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(139, 24);
            this.cb_gioitinh.TabIndex = 11;
            this.cb_gioitinh.SelectedIndexChanged += new System.EventHandler(this.cb_gioitinh_SelectedIndexChanged);
            // 
            // tb_tienluong
            // 
            this.tb_tienluong.Location = new System.Drawing.Point(385, 131);
            this.tb_tienluong.Name = "tb_tienluong";
            this.tb_tienluong.Size = new System.Drawing.Size(200, 22);
            this.tb_tienluong.TabIndex = 10;
            this.tb_tienluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tienluong_KeyPress);
            // 
            // tb_chucvu
            // 
            this.tb_chucvu.Location = new System.Drawing.Point(385, 84);
            this.tb_chucvu.Name = "tb_chucvu";
            this.tb_chucvu.Size = new System.Drawing.Size(200, 22);
            this.tb_chucvu.TabIndex = 9;
            this.tb_chucvu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_chucvu_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tien Luong";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Chuc Vu";
            // 
            // dtime_ngaysinh
            // 
            this.dtime_ngaysinh.Location = new System.Drawing.Point(385, 40);
            this.dtime_ngaysinh.Name = "dtime_ngaysinh";
            this.dtime_ngaysinh.Size = new System.Drawing.Size(200, 22);
            this.dtime_ngaysinh.TabIndex = 2;
            // 
            // tb_tennv
            // 
            this.tb_tennv.Location = new System.Drawing.Point(125, 84);
            this.tb_tennv.Name = "tb_tennv";
            this.tb_tennv.Size = new System.Drawing.Size(139, 22);
            this.tb_tennv.TabIndex = 5;
            this.tb_tennv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tennv_KeyPress);
            // 
            // tb_manv
            // 
            this.tb_manv.Location = new System.Drawing.Point(125, 40);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(139, 22);
            this.tb_manv.TabIndex = 4;
            this.tb_manv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_manv_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gioi Tinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngaysinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "TenNV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaNV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(650, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 11;
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.White;
            this.bt_them.Location = new System.Drawing.Point(926, 381);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(101, 31);
            this.bt_them.TabIndex = 12;
            this.bt_them.Text = "them";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_khoitao
            // 
            this.bt_khoitao.BackColor = System.Drawing.Color.White;
            this.bt_khoitao.Location = new System.Drawing.Point(926, 532);
            this.bt_khoitao.Name = "bt_khoitao";
            this.bt_khoitao.Size = new System.Drawing.Size(101, 34);
            this.bt_khoitao.TabIndex = 13;
            this.bt_khoitao.Text = "khoi tao";
            this.bt_khoitao.UseVisualStyleBackColor = false;
            this.bt_khoitao.Click += new System.EventHandler(this.bt_khoitao_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.White;
            this.bt_xoa.Location = new System.Drawing.Point(926, 481);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(101, 31);
            this.bt_xoa.TabIndex = 14;
            this.bt_xoa.Text = "xoa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.White;
            this.bt_sua.Location = new System.Drawing.Point(926, 428);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(101, 31);
            this.bt_sua.TabIndex = 15;
            this.bt_sua.Text = "sua";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(242, 339);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(150, 22);
            this.tb_timkiem.TabIndex = 16;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.White;
            this.bt_timkiem.Location = new System.Drawing.Point(435, 337);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(90, 29);
            this.bt_timkiem.TabIndex = 17;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.UseVisualStyleBackColor = false;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // cbsapxep
            // 
            this.cbsapxep.FormattingEnabled = true;
            this.cbsapxep.Items.AddRange(new object[] {
            "A->Z",
            "Z->A",
            "Tăng",
            "Giảm"});
            this.cbsapxep.Location = new System.Drawing.Point(926, 337);
            this.cbsapxep.Name = "cbsapxep";
            this.cbsapxep.Size = new System.Drawing.Size(101, 24);
            this.cbsapxep.TabIndex = 18;
            this.cbsapxep.SelectedIndexChanged += new System.EventHandler(this.cbsapxep_SelectedIndexChanged);
            // 
            // bt_sapxep
            // 
            this.bt_sapxep.BackColor = System.Drawing.Color.White;
            this.bt_sapxep.Location = new System.Drawing.Point(766, 334);
            this.bt_sapxep.Name = "bt_sapxep";
            this.bt_sapxep.Size = new System.Drawing.Size(101, 29);
            this.bt_sapxep.TabIndex = 19;
            this.bt_sapxep.Text = "sắp xếp";
            this.bt_sapxep.UseVisualStyleBackColor = false;
            this.bt_sapxep.Click += new System.EventHandler(this.bt_sapxep_Click);
            // 
            // bt_tongluong
            // 
            this.bt_tongluong.BackColor = System.Drawing.Color.White;
            this.bt_tongluong.Location = new System.Drawing.Point(725, 598);
            this.bt_tongluong.Name = "bt_tongluong";
            this.bt_tongluong.Size = new System.Drawing.Size(133, 27);
            this.bt_tongluong.TabIndex = 20;
            this.bt_tongluong.Text = "Tổng lương";
            this.bt_tongluong.UseVisualStyleBackColor = false;
            this.bt_tongluong.Click += new System.EventHandler(this.bt_tongluong_Click);
            // 
            // tb_tongluong
            // 
            this.tb_tongluong.Location = new System.Drawing.Point(553, 602);
            this.tb_tongluong.Name = "tb_tongluong";
            this.tb_tongluong.ReadOnly = true;
            this.tb_tongluong.Size = new System.Drawing.Size(137, 22);
            this.tb_tongluong.TabIndex = 21;
            this.tb_tongluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_in
            // 
            this.bt_in.BackColor = System.Drawing.Color.White;
            this.bt_in.Location = new System.Drawing.Point(242, 598);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(101, 29);
            this.bt_in.TabIndex = 22;
            this.bt_in.Text = "in hóa đơn";
            this.bt_in.UseVisualStyleBackColor = false;
            this.bt_in.Click += new System.EventHandler(this.bt_in_Click);
            // 
            // bt_thongke
            // 
            this.bt_thongke.BackColor = System.Drawing.Color.White;
            this.bt_thongke.Location = new System.Drawing.Point(926, 595);
            this.bt_thongke.Name = "bt_thongke";
            this.bt_thongke.Size = new System.Drawing.Size(101, 29);
            this.bt_thongke.TabIndex = 23;
            this.bt_thongke.Text = "Thống kê";
            this.bt_thongke.UseVisualStyleBackColor = false;
            this.bt_thongke.Click += new System.EventHandler(this.bt_thongke_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.BackColor = System.Drawing.Color.White;
            this.bt_clear.Location = new System.Drawing.Point(387, 598);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(98, 27);
            this.bt_clear.TabIndex = 24;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = false;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1284, 648);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.cbsapxep);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_sapxep);
            this.Controls.Add(this.bt_thongke);
            this.Controls.Add(this.bt_in);
            this.Controls.Add(this.tb_tongluong);
            this.Controls.Add(this.bt_tongluong);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_khoitao);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtime_ngaysinh;
        private System.Windows.Forms.TextBox tb_tennv;
        private System.Windows.Forms.TextBox tb_manv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tienluong;
        private System.Windows.Forms.TextBox tb_chucvu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_khoitao;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.ComboBox cb_gioitinh;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.ComboBox cbsapxep;
        private System.Windows.Forms.Button bt_sapxep;
        private System.Windows.Forms.Button bt_tongluong;
        private System.Windows.Forms.TextBox tb_tongluong;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.Button bt_thongke;
        private System.Windows.Forms.Button bt_clear;
    }
}

