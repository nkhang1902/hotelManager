using QuanLyKhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private QuanLyPhong formB;
        private QuanLyDatPhong formA;
        private QuanLyKH formC;
        public MainForm()
        {
            InitializeComponent();
            formA = new QuanLyDatPhong();
            formB = new QuanLyPhong();
            formC = new QuanLyKH();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formB.Show();
        }

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formA.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formC.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
