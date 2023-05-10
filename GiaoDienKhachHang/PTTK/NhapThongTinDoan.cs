using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK_GIaoDien
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "" || guna2TextBox2.Text == "" || guna2TextBox3.Text == "" || guna2TextBox4.Text == "")
            {
                MessageBox.Show("Xin vui lòng điền đầy đủ thông tin");
            }
            else
            {
                Connection.Connect();
                //string sql = "insert into KhachHang(CMND, DiaChiKH, EmailKH, HoTenKH, NgaySinhKH, SdtKH, SoFAX) values('" + guna2TextBox7.Text + "', '" + guna2TextBox4.Text + "', '" + guna2TextBox3.Text + "', '" + guna2TextBox1.Text + "', CONVERT(DATE,'" + guna2DateTimePicker1.Text + "' ,105)" + ", " + guna2TextBox2.Text + ", " + guna2TextBox6.Text + ");";
                try
                {
                    string sql = "SET IDENTITY_INSERT Doan ON";
                    Connection.RunSQL(sql);
                    sql = "insert into Doan(MaDoan,TenDoan,NguoiDaiDien,SoLuong) values (" + guna2TextBox1.Text + ",'" + guna2TextBox2.Text + "', '" + guna2TextBox3.Text + "', '" + guna2TextBox4.Text + "');";
                    Connection.RunSQL(sql);
                    MessageBox.Show("Them du lieu thanh cong");
                }
                catch
                {
                    string sql = "insert into Doan(MaDoan,TenDoan,NguoiDaiDien,SoLuong) values (" + guna2TextBox1.Text + ",'" + guna2TextBox2.Text + "', '" + guna2TextBox3.Text + "', '" + guna2TextBox4.Text + "');";
                    MessageBox.Show(sql);
                }
            }
        }
    }
}
