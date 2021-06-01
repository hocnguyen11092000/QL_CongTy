using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;
using System.Windows.Controls;

namespace QLCongTy
{
    public partial class Form4 : Form
    {
        
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-G1RDP8M\SQLEXPRESS;Initial Catalog=QLcongty;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Form4()
        {
            InitializeComponent();
           
        }
        Func<ChartPoint, string> lablePoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
        private void button1_Click(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            // cb_thongke.SelectedText = "";
            // MessageBox.Show(cb_thongke.Text);
            if (cb_thongke.Text == "GioiTinh")
            {
                command.CommandText = "select GioiTinh, count(GioiTinh) as soluong from ThongTinNhanVIen group by GioiTinh";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
              //  table.Rows.Clear();
                dgv_thongke.DataSource = table;
            }
            else if(cb_thongke.Text == "ChucVu")
            {
                command.CommandText = "select ChucVu, count(ChucVu) as soluong from ThongTinNhanVIen group by ChucVu";
                adapter.SelectCommand = command;
                table.Clear();
                table.Rows.Clear();
                adapter.Fill(table);
                dgv_thongke.DataSource = table;
            }
            else if (cb_thongke.Text == "TienLuong")
            {
                command.CommandText = "select TienLuong, count(TienLuong) as soluong from ThongTinNhanVIen group by TienLuong";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgv_thongke.DataSource = table;
            }
            if (table.Rows.Count > 0)
            {
                int i;
                for (i = 0; i < table.Rows.Count; i++)
                {
                    if (cb_thongke.Text == "GioiTinh")
                    {
                        series.Add(new PieSeries() { Title = table.Rows[i]["Gioitinh"].ToString(), Values = new ChartValues<int> { Convert.ToInt32(table.Rows[i]["soluong"].ToString()) }, DataLabels = true, LabelPoint = lablePoint });
                    }
                    else if(cb_thongke.Text == "ChucVu")
                    {
                        series.Add(new PieSeries() { Title = table.Rows[i]["ChucVu"].ToString(), Values = new ChartValues<int> { Convert.ToInt32(table.Rows[i]["soluong"].ToString()) }, DataLabels = true, LabelPoint = lablePoint });
                    }
                    else if (cb_thongke.Text == "TienLuong")
                    {
                        series.Add(new PieSeries() { Title = table.Rows[i]["TienLuong"].ToString(), Values = new ChartValues<int> { Convert.ToInt32(table.Rows[i]["soluong"].ToString()) }, DataLabels = true, LabelPoint = lablePoint });
                    }

                }
                pieChart1.Series = series;
               
            }    
            
                
            
        }
        void loadata()
        {
            cb_thongke.SelectedText = "GioiTinh";
            command = connection.CreateCommand();
            if(cb_thongke.Text == "GioiTinh")
            {
                command.CommandText = "select GioiTinh, count(GioiTinh) as soluong from ThongTinNhanVIen group by GioiTinh";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgv_thongke.DataSource = table;
            }
            else if (cb_thongke.Text == "ChucVu")
            {
                command.CommandText = "select ChucVu, count(ChucVu) as soluong from ThongTinNhanVIen group by ChucVu";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgv_thongke.DataSource = table;
            }
            else if (cb_thongke.Text == "TienLuong")
            {
                command.CommandText = "select TienLuong, count(TienLuong) as soluong from ThongTinNhanVIen group by TienLuong";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgv_thongke.DataSource = table;
            }

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            
            connection = new SqlConnection(str);
            connection.Open();
            /*
            command = connection.CreateCommand();
            cb_thongke.SelectedText = "GioiTinh";
            command.CommandText = "select GioiTinh, count(GioiTinh) as soluong from ThongTinNhanVIen group by GioiTinh";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_thongke.DataSource = table;
            */
            loadata();
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }
    }
}
