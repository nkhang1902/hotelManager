﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
                if (guna2TextBox1.Text =="" || guna2TextBox2.Text == "" || guna2TextBox3.Text == "" || guna2TextBox4.Text == "" || guna2TextBox5.Text == "" || guna2TextBox6.Text == "" || guna2TextBox7.Text == "" || guna2DateTimePicker1.Text.Length == 0)
                    {
                        MessageBox.Show("Xin vui lòng điền đầy đủ thông tin");
            }
        }
    }
}
