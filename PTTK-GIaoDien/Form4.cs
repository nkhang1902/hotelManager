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
                
                string sql = "insert DatPhong ( MaPhong, CMND, NgayDP, SoDemLuuTru,MaDoan, SoLuongNguoi, TienCoc) values ( '" + textBox1.Text + "', '" + textBox7.Text + "', CONVERT(DATE, '" + guna2DateTimePicker1.Text + "', 120), " + "(SELECT DATEDIFF(day, '"+ guna2DateTimePicker1.Text +"' , '" + guna2DateTimePicker2.Text + "') AS difference)," +"'" + textBox8.Text +"'," + textBox6.Text + ", (SELECT " + textBox4.Text +"*"+ " (SELECT DATEDIFF(day, '" + guna2DateTimePicker1.Text + "' , '" + guna2DateTimePicker2.Text + "') AS difference)" + " * (0.5) AS result) );";
                MessageBox.Show(sql);
                Connection.RunSQL(sql);
                sql = "UPDATE Phong SET TrangThaiDat = 1 WHERE MaPhong = " + textBox1.Text + ";";
                Connection.RunSQL(sql);
                dataGridView1.DataSource = Connection.GetDataToTable("select * from Phong where TrangThaiDat = '0'");
                MessageBox.Show(sql);
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
                string sql = " select * from Phong where LoaiPhong = '" + guna2ComboBox1.Text + "' and TrangThaiDat ='0'";
                string check = Connection.GetFieldValues(sql);
                if (check == "")
                {
                    MessageBox.Show("Loại phòng này đã hết");
                }
                else dataGridView1.DataSource = Connection.GetDataToTable(sql);
            }
           
            

            
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString(); // mã ID
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString(); // LoaiPhong
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString(); // TrangThaiDat
            textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString(); // Trạng thái vệ sinh
            textBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString(); // Giá
            textBox6.Text = dataGridView1.Rows[i].Cells[5].Value.ToString(); // Số lượng người
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            if(textBox7.Text =="")
            {
                MessageBox.Show("Vui điền vào cmnd");
            }
            else
            {
                Connection.Connect();
                string sql = " select * from DatPhong where CMND = '" + textBox7.Text + "'";
                dataGridView2.DataSource = Connection.GetDataToTable(sql);
                Connection.Disconnect();
            }
                
                


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dataGridView2.CurrentRow.Index;
            textBox9.Text = dataGridView2.Rows[i].Cells[0].Value.ToString(); // mã DatPhòng
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Connection.Connect();
            if (textBox7.Text == "")
            {
                MessageBox.Show("Vui điền vào mã hủy đặt phòng");
            }
            else {
                string sql = "delete DatPhong where MADP = '" + textBox9.Text + "'";
                Connection.RunSQL(sql);
                sql = "UPDATE Phong SET TrangThaiDat = 0 WHERE MaPhong = (select MaPhong from DatPhong where MaDP = '" + textBox9.Text + "'); ";
                MessageBox.Show("Hủy đặt phòng thành công");
            }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
