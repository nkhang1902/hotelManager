using GiaoDienKhachHang;
using PTTK_GIaoDien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckIn checkin = new CheckIn();
            if (checkin.ShowDialog() == DialogResult.OK)
            {
                // Update the selected user's data in the DataGridView
                //selectedRow.Cells["UserName"].Value = userEditForm.UserName;
                // ...
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DichVu dichvu = new DichVu();
            if (dichvu.ShowDialog() == DialogResult.OK)
            {
                // Update the selected user's data in the DataGridView
                //selectedRow.Cells["UserName"].Value = userEditForm.UserName;
                // ...
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 nttkhach = new Form2();
            if (nttkhach.ShowDialog() == DialogResult.OK)
            {
                // Update the selected user's data in the DataGridView
                //selectedRow.Cells["UserName"].Value = userEditForm.UserName;
                // ...
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 nttdoan = new Form3();
            if (nttdoan.ShowDialog() == DialogResult.OK)
            {
                // Update the selected user's data in the DataGridView
                //selectedRow.Cells["UserName"].Value = userEditForm.UserName;
                // ...
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 datphong = new Form4();
            if (datphong.ShowDialog() == DialogResult.OK)
            {
                // Update the selected user's data in the DataGridView
                //selectedRow.Cells["UserName"].Value = userEditForm.UserName;
                // ...
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ThanhToan thanhtoan = new ThanhToan();
            if (thanhtoan.ShowDialog() == DialogResult.OK)
            {
                // Update the selected user's data in the DataGridView
                //selectedRow.Cells["UserName"].Value = userEditForm.UserName;
                // ...
            }
        }
    }
}
