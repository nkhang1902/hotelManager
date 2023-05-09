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
                string sql = " select * from Phong where LoaiPhong = '" + guna2ComboBox1.Text + "'";
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
    }
}
