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
    public partial class Form_TTDSTS : Office2007Form
    {
        private ThiSinhBS tsbs;
        public Form_TTDSTS()
        {
            InitializeComponent();
        }

        private void Form_TTDSTS_Load(object sender, EventArgs e)
        {
            tsbs = new ThiSinhBS();
            DataTable dt = new DataTable();
            dt = tsbs.GetThiSinh().Tables[0];
            comboBox_ten.DisplayMember = "HoTen";
            comboBox_ten.ValueMember = "MaThiSinh";
            comboBox_ten.DataSource = dt;
            comboBox_ma.DisplayMember = "MaThiSinh";
            comboBox_ma.ValueMember = "MaThiSinh";
            comboBox_ma.DataSource = dt;
            dataGridView1.DataSource = dt;
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                comboBox_ma.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                comboBox_ten.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                label_dc.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                label_ns.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void comboBox_ten_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*tsbs = new ThiSinhBS();
            DataRow dr = tsbs.GetThiSinhMa(comboBox_ma.SelectedValue.ToString()).Tables[0].Rows[0];
           
            label_dc.Text = dr[2].ToString();
            label_ns.Text = dr[3].ToString();*/
        }

        private void comboBox_ma_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsbs = new ThiSinhBS();
            DataRow dr = tsbs.GetThiSinhMa(comboBox_ma.SelectedValue.ToString()).Tables[0].Rows[0];
            
            label_dc.Text = dr[2].ToString();
            label_ns.Text = dr[3].ToString();

        }
    }
}