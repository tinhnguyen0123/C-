using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tracnghiem_Business;

namespace Tracnghiem_Application
{
    public partial class Form_TTDSNV : Office2007Form
    {
        private NhanVienBS nvbs;
        public Form_TTDSNV()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nvbs = new NhanVienBS();
            dataGridView1.DataSource = nvbs.GetNhanVien().Tables[0];
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nvbs = new NhanVienBS();
            dataGridView1.DataSource = nvbs.GetNhanVienCV("Dieu Hanh").Tables[0];
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            nvbs = new NhanVienBS();
            dataGridView1.DataSource = nvbs.GetNhanVienCV("Quan Li").Tables[0];
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            nvbs = new NhanVienBS();
            dataGridView1.DataSource = nvbs.GetNhanVienCV("Nhan Vien").Tables[0];
        }
    }
}