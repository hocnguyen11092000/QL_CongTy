using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLCongTy
{
    public partial class Form1 : Form
    {
      //  object cmd;
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-G1RDP8M\SQLEXPRESS;Initial Catalog=QLcongty;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadata()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * from ThongTinNhanVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadata();
           // SqlCommand cmd = new SqlCommand("select sum(TienLuong) from ThongTinNhanVien");
            //cmd.Connection = connection;
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
           // {
            //    tb_tongluong.Text = tb_tongluong.Text + dr.GetInt32(0);
            //}
            cbsapxep.SelectedText = "A->Z";
            cb_gioitinh.SelectedText = "Nam";
        }


        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //tb_manv.ReadOnly = true;
            int i;
            i = dgv.CurrentRow.Index;
            tb_manv.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_tennv.Text = dgv.Rows[i].Cells[1].Value.ToString();
            cb_gioitinh.Text = dgv.Rows[i].Cells[3].Value.ToString();
            dtime_ngaysinh.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tb_chucvu.Text = dgv.Rows[i].Cells[4].Value.ToString();
            tb_tienluong.Text = dgv.Rows[i].Cells[5].Value.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if(tb_manv.Text == "" || tb_tennv.Text == "" || cb_gioitinh.Text == "" || tb_chucvu.Text == "" || tb_tienluong.Text == "")
            {
                DialogResult tb = MessageBox.Show("Phải điền đầy đủ các trường!", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            else
            {
                
                string sql = @"select MaNV from ThongTinNhanVien";
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                bool check = true;
                if (dt.Rows.Count > 0)
                {
                    int i;
                    //tb_tongluong.Text = dt.Rows[0]["tongluong"].ToString().Trim();
                   for(i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["MaNV"].ToString().Trim() == tb_manv.Text)
                        {
                            MessageBox.Show("Mã nhân viên không được trùng");
                            tb_manv.Focus();
                            check = false;
                        }
                    }
                    
                }
                if(check != false){
                    
                    command = connection.CreateCommand();
                    command.CommandText = "insert into ThongTinNhanVien values('" + tb_manv.Text + "',N'" + tb_tennv.Text + "','" + Convert.ToDateTime(dtime_ngaysinh.Text) + "',N'" + cb_gioitinh.Text + "',N'" + tb_chucvu.Text + "','" + Convert.ToDouble(tb_tienluong.Text) + "')";
                    command.ExecuteNonQuery();
                    DialogResult tb = MessageBox.Show("Thêm thành công", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    loadata();
                }
                
                


            }
            
        }

        private void cb_gioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (tb_manv.Text == "" || tb_tennv.Text == "" || cb_gioitinh.Text == "" || tb_chucvu.Text == "" || tb_tienluong.Text == "")
            {
                DialogResult tb2 = MessageBox.Show("Phải điền đầy đủ các trường!", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
           
            else
            {
                DialogResult tb4 = MessageBox.Show("Bạn chắc chắn xóa?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (tb4 == DialogResult.OK)
                {
                    command = connection.CreateCommand();
                    command.CommandText = "delete from ThongTinNhanVien where MaNV= '" + tb_manv.Text + "'";
                    command.ExecuteNonQuery();
                    DialogResult tb = MessageBox.Show("Xóa thành công", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    loadata();
                }
                else return;
            }
            
           
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (tb_manv.Text == "" || tb_tennv.Text == "" || cb_gioitinh.Text == "" || tb_chucvu.Text == "" || tb_tienluong.Text == "")
            {
                DialogResult tb3 = MessageBox.Show("Phải điền đầy đủ các trường!", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "update ThongtinNhanVien set TenNV = N'" + tb_tennv.Text + "',Ngaysinh= '" + Convert.ToDateTime(dtime_ngaysinh.Text) + "',GioiTinh= N'" + cb_gioitinh.Text + "',ChucVu = N'" + tb_chucvu.Text + "',TienLuong= " + tb_tienluong.Text + " where MaNV = '" + tb_manv.Text + "'";
                command.ExecuteNonQuery();
                DialogResult tb = MessageBox.Show("Sửa thành công", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                loadata();
            }
            
        }

        private void bt_khoitao_Click(object sender, EventArgs e)
        {
            tb_manv.Text = "";
            tb_tennv.Text = "";
            dtime_ngaysinh.Text = "1/1/2000";
            cb_gioitinh.Text = "";
            tb_chucvu.Text = "";
            tb_tienluong.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from ThongTinNhanVien where TenNV like N'%"+tb_timkiem.Text+ "%' or GioiTinh like N'%" + tb_timkiem.Text + "%' or ChucVu like N'%" + tb_timkiem.Text + "%' or MaNV like N'%" + tb_timkiem.Text + "%' or TienLuong like N'%" + tb_timkiem.Text + "%'";
           
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }

        private void cbsapxep_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }

        private void bt_sapxep_Click(object sender, EventArgs e)
        {

            command = connection.CreateCommand();
            string a = cbsapxep.SelectedItem.ToString();
            if (a == "A->Z")
            {
                command.CommandText = "select * from ThongTinNhanVIen order by TenNV";
                DialogResult tb = MessageBox.Show("Sắp xếp nhân theo tên từ A->Z", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }    
            else if(a == "Z->A")
            {
                command.CommandText = "select * from ThongTinNhanVIen order by TenNV desc";
                DialogResult tb = MessageBox.Show("Sắp xếp nhân theo tên từ Z->A", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }    
            else if(a == "Tăng")
            {
                command.CommandText = "select * from ThongTinNhanVIen order by TienLuong";
                DialogResult tb = MessageBox.Show("Sắp xếp tiền lương tăng dần", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }    
            else if(a == "Giảm")
            {
                command.CommandText = "select * from ThongTinNhanVIen order by TienLuong desc";
                DialogResult tb = MessageBox.Show("Sắp xếp tiền lương giảm dần", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;

            
        }

        private void bt_tongluong_Click(object sender, EventArgs e)
        {
            /*
            SqlCommand cmd = new SqlCommand("select sum(TienLuong) from ThongTinNhanVien");
            cmd.Connection = connection;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tb_tongluong.Text = tb_tongluong.Text + dr.GetInt32(0);
            }
            */
            string sql = @"select format((select sum(TienLuong) as tongluong from ThongTinNhanVien), 'N0') as tongluong;";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);//conn là cái SqlConnection của bạn ấy nhé
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                tb_tongluong.Text = (dt.Rows[0]["tongluong"].ToString().Trim())+" VNĐ";
             //   lb_test.Text = dt.Rows[0]["tongluong"].ToString().Trim();
            }
            else
            {
                MessageBox.Show("fail");
            }
        }

        private void dgv_tongtien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
           // this.Close();
        }

        private void bt_thongke_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            tb_tongluong.Text = "";
        }

        private void tb_tienluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                DialogResult tb6 = MessageBox.Show("Nhập sai định dạng!", "Thông báo",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                e.Handled = true;
            }
        }

        private void tb_manv_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tb_tennv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                DialogResult tb6 = MessageBox.Show("Nhập sai định dạng!", "Thông báo",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                e.Handled = true;
            }
        }

        private void tb_chucvu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                DialogResult tb6 = MessageBox.Show("Nhập sai định dạng!", "Thông báo",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                e.Handled = true;
            }
        }
    }
}
