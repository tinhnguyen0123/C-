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
    public partial class Form_TTNHCH : Office2007Form
    {
        public ThiSinhBS tsbs;
        public NhanVienBS nvbs;
        public Form_TTNHCH()
        {
            InitializeComponent();
        }

        private void Form_TTNHCH_Load(object sender, EventArgs e)
        {
            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetMonThi().Tables[0];
            comboBox_mon.DisplayMember = "TenMon";
            comboBox_mon.ValueMember = "MaMon";
            comboBox_mon.DataSource = dt;

            nvbs=new NhanVienBS();
            DataTable dt2 = nvbs.GetNhanVien().Tables[0];
            comboBox_nguoitao.DisplayMember = "HoTen";
            comboBox_nguoitao.ValueMember = "MaNhanVien";
            comboBox_nguoitao.DataSource = dt2;

            tsbs = new ThiSinhBS();
            dataGridView1.DataSource = tsbs.GetCauHoi().Tables[0];
        }

        private void comboBox_mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsbs = new ThiSinhBS();
            dataGridView1.DataSource = tsbs.GetCauHoi_Mon(comboBox_mon.SelectedValue.ToString()).Tables[0];
        }

        private void comboBox_nguoitao_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsbs = new ThiSinhBS();
            dataGridView1.DataSource = tsbs.GetCauHoi_NhanVien(comboBox_nguoitao.SelectedValue.ToString()).Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                richTextBox_cauhoi.Text=dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                HienthiDA();
            }
        }
        public void HienthiDA()
        {
            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetDapAn(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).Tables[0];
            richTextBox1.Text = dt.Rows[0][0].ToString();
            richTextBox2.Text = dt.Rows[1][0].ToString();
            richTextBox3.Text = dt.Rows[2][0].ToString();
            richTextBox4.Text = dt.Rows[3][0].ToString();
            richTextBox5.Text = tsbs.GetDapAnDung(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).Tables[0].Rows[0][0].ToString();
        }
    }
}