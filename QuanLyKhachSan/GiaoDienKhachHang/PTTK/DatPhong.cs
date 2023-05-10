using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PTTK_GIaoDien
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Connection.Connect();
            if (guna2ComboBox1.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần tìm");
            }
            else
            {
                //insert DatPhong ( MaPhong, CMND, NgayDP, SoDemLuuTru,MaDoan, SoLuongNguoi) values ( '103', '0987', 350000,CONVERT(DATE,'27-04-2002' ,105), (SELECT DATEDIFF(day, '2023/07/02', '2023/05/09') AS difference),'2',6);
                //MessageBox.Show("???");
                string test = "select * from Doan where MaDoan = " + textBox8.Text;
                string result_MaDoan;
                try
                {
                    result_MaDoan = Connection.GetFieldValues(test);
                }
                catch
                {
                    result_MaDoan = "";
                }

                //MessageBox.Show("???");
                if (result_MaDoan == "")
                {
                    try
                    {
                        string ngayDat = guna2DateTimePicker1.Text;
                        string phong = textBox1.Text.Trim();
                        DateTime dat = DateTime.Parse(ngayDat);
                        ngayDat = dat.ToString("yyyy-MM-dd");
                        String time_check = "SELECT COUNT(*) FROM DatPhong WHERE ( NgayDP = '" + ngayDat + "' AND MaPhong ='" + phong + "')";
                        SqlCommand timecheck = new SqlCommand(time_check, Connection.Con);
                        int count = (int)timecheck.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Đã có khách đặt chưa trả phòng vào ngày này.");
                            return;
                        }

                        string sql = "insert DatPhong ( MaPhong, CMND, NgayDP, SoDemLuuTru, SoLuongNguoi, TienCoc) values ( '" + textBox1.Text + "', '" + textBox7.Text + "', CONVERT(DATE, '" + guna2DateTimePicker1.Text + "', 120), " + "(SELECT DATEDIFF(day, '" + guna2DateTimePicker1.Text + "' , '" + guna2DateTimePicker2.Text + "') AS difference)," + textBox6.Text + ", (SELECT " + textBox4.Text + " * " + " (SELECT DATEDIFF(day, '" + guna2DateTimePicker1.Text + "' , '" + guna2DateTimePicker2.Text + "') AS difference)" + " * (0.5) AS result) );";
                        // MessageBox.Show(sql);
                        Connection.RunSQL(sql);

                    }
                    catch
                    {
                        MessageBox.Show("Thêm dữ liệu không thành công ");
                    }
                }
                else
                {
                    try
                    {
                        string ngayDat = guna2DateTimePicker1.Text;
                        string phong = textBox1.Text.Trim();
                        DateTime dat = DateTime.Parse(ngayDat);
                        ngayDat = dat.ToString("yyyy-MM-dd");
                        String time_check = "SELECT COUNT(*) FROM DatPhong WHERE ( NgayDP = '" + ngayDat + "' AND MaPhong ='" + phong + "')";
                        SqlCommand timecheck = new SqlCommand(time_check, Connection.Con);
                        int count = (int)timecheck.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Đã có khách đặt chưa trả phòng vào ngày này.");
                            return;
                        }
                        string sql = "insert DatPhong ( MaPhong, CMND,MaDoan, NgayDP, SoDemLuuTru, SoLuongNguoi, TienCoc) values ( '" + textBox1.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "' , CONVERT(DATE, '" + guna2DateTimePicker1.Text + "', 120), " + "(SELECT DATEDIFF(day, '" + guna2DateTimePicker1.Text + "' , '" + guna2DateTimePicker2.Text + "') AS difference)," + textBox6.Text + ", (SELECT " + textBox4.Text + "*" + " (SELECT DATEDIFF(day, '" + guna2DateTimePicker1.Text + "' , '" + guna2DateTimePicker2.Text + "') AS difference)" + " * (0.5) AS result) );";
                        //MessageBox.Show(sql);
                        Connection.RunSQL(sql);

                    }
                    catch
                    {
                        MessageBox.Show("Thêm dữ liệu không thành công ");
                    }
                }


            }


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Connection.Connect();
            if (guna2ComboBox1.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần tìm");
            }
            else
            {
                if (guna2NumericUpDown1.Value == 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng người vào");
                }
                else
                {
                    string sql = " select * from Phong where LoaiPhong = '" + guna2ComboBox1.Text + "' and SoLuongNguoi >= " + guna2NumericUpDown1.Value;
                    //" and TrangThaiDat = '0'";
                    string check = Connection.GetFieldValues(sql);
                    //MessageBox.Show(sql);
                    if (check == "")
                    {
                        MessageBox.Show("Loại phòng này đã hết");
                    }
                    else dataGridView1.DataSource = Connection.GetDataToTable(sql);

                }
            }





        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;


            //textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString(); // mã ID
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();

            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString(); // LoaiPhong
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString(); // TrangThaiDat
            textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString(); // Trạng thái vệ sinh
            textBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString(); // Giá
            textBox6.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();




            /*textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString(); // mã ID
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString(); // LoaiPhong
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString(); // TrangThaiDat
            textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString(); // Trạng thái vệ sinh
            textBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString(); // Giá
            textBox6.Text = dataGridView1.Rows[i].Cells[5].Value.ToString(); // Số lượng người*/
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Vui điền vào cmnd");
            }
            else
            {
                try
                {
                    Connection.Connect();
                    string sql = " select * from DatPhong where CMND = '" + textBox7.Text + "'";
                    dataGridView2.DataSource = Connection.GetDataToTable(sql);
                    Connection.Disconnect();
                }
                catch
                {

                }

            }




        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dataGridView2.CurrentRow.Index;
            textBox1.Text = dataGridView2.Rows[i].Cells[0].Value.ToString(); // mã DatPhòng
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

            Connection.Connect();
            try
            {
                string sql = "UPDATE Phong SET TrangThaiDat = 0 WHERE MaPhong = (select MaPhong from DatPhong where MaDP = '" + textBox1.Text + "'); ";

                Connection.RunSQL(sql);
                sql = "delete DatPhong where MADP = '" + textBox1.Text + "'";
                Connection.RunSQL(sql);
                MessageBox.Show("Hủy đặt phòng thành công");
            }

            catch
            {
                MessageBox.Show("Lỗi đặt phòng không thành công");
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
