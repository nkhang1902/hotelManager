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
    }
}
