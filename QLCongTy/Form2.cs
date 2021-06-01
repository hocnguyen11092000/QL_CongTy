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
    public partial class Form2 : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public Form2()
        {
            InitializeComponent();
            connection.ConnectionString = @"Data Source=DESKTOP-G1RDP8M\SQLEXPRESS;Initial Catalog=QLcongty;Integrated Security=True";
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            string sql = @"select * from dangnhap where taikhoan = '" + tb_taikhoan.Text + "' and matkhau = '" + tb_matkhau.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);//conn là cái SqlConnection của bạn ấy nhé
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Form1 f1 = new Form1();
                f1.Show();
               // this.Close();
            }
            else
            {
                DialogResult tb = MessageBox.Show("Đăng nhập không thành công", "Thông báo",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                tb_matkhau.Focus();
                tb_matkhau.SelectAll();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_taikhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
