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
    public partial class Form_TTDSKQ : Office2007Form
    {
        private ThiSinhBS tsbs;
        public Form_TTDSKQ()
        {
            InitializeComponent();
        }

        private void Form_TTDSKQ_Load(object sender, EventArgs e)
        {
            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetMonThi().Tables[0];
            comboBox1.DisplayMember = "TenMon";
            comboBox1.ValueMember = "MaMon";
            comboBox1.DataSource = dt;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tsbs = new ThiSinhBS();
            dataGridView1.DataSource = tsbs.GetKetQua().Tables[0];
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tsbs = new ThiSinhBS();
            dataGridView1.DataSource = tsbs.GetKetQuaDiemCN(comboBox1.SelectedValue.ToString()).Tables[0];
        }

        

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tsbs = new ThiSinhBS();
            dataGridView1.DataSource = tsbs.GetKetQuaDiemTN(comboBox1.SelectedValue.ToString()).Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            tsbs = new ThiSinhBS();
            dataGridView1.DataSource = tsbs.GetKetQuaCSDL(comboBox1.SelectedValue.ToString()).Tables[0];
        }
    }
}