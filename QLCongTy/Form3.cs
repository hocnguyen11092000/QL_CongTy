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
    public partial class Form3 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-G1RDP8M\SQLEXPRESS;Initial Catalog=QLcongty;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select MaNV from ThongTinNhanVien";
            adapter.SelectCommand = command;
            adapter.Fill(table);
            adapter.Dispose();
            cb_manv_f3.DataSource = table;
            cb_manv_f3.DisplayMember = "MaNV";
            cb_manv_f3.ValueMember = "MaNV";

        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cb_manv_f3.Text);
            string sql = @"select * from ThongTinNhanVien where MaNV = N'" + cb_manv_f3.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);//conn là cái SqlConnection của bạn ấy nhé
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lb_manv.Text = dt.Rows[0]["MaNV"].ToString().Trim();
                lb_tennv.Text = dt.Rows[0]["TenNV"].ToString().Trim();
                string sql2 = @"select (YEAR(GETDATE()) - YEAR(Ngaysinh)) as tuoi from ThongTinNhanVIen where MaNV = N'" + cb_manv_f3.Text + "'";
                SqlDataAdapter da2 = new SqlDataAdapter(sql2, connection);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                if (dt2.Rows.Count > 0)
                {
                    lb_tuoi.Text = dt2.Rows[0]["tuoi"].ToString().Trim();
                }
                lb_chucvu.Text = dt.Rows[0]["ChucVu"].ToString().Trim();
                lb_tienluong.Text = dt.Rows[0]["TienLuong"].ToString().Trim();
                string sql3 = @"select GETDATE() as ngaythang";
                SqlDataAdapter da3 = new SqlDataAdapter(sql3, connection);//conn là cái SqlConnection của bạn ấy nhé
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                if (dt3.Rows.Count > 0)
                {
                    lb_thoigian.Text = "Ngày thực hiện: "+ dt3.Rows[0]["ngaythang"].ToString().Trim();
                }
                else
                {
                    MessageBox.Show("fail");
                }
            }
            /*
        private void label7_Click(object sender, EventArgs e)
        {

        }
            */
        }

    }
}
