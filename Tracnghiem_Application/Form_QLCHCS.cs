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
    public partial class Form_QLCHCS : Office2007Form
    {
        private ThiSinhBS tsbs;
        public delegate string MyGet();
        public MyGet Laygt;
        public Form_QLCHCS()
        {
            InitializeComponent();
            tsbs = new ThiSinhBS();
        }

        private void Form_QLCHCS_Load(object sender, EventArgs e)
        {
            label1.Text = Laygt();
            label1.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetMonThi().Tables[0];
            comboBox_mon.DisplayMember = "TenMon";
            comboBox_mon.ValueMember = "MaMon";
            comboBox_mon.DataSource = dt;

            Data();
        }
        public void Data()
        {
            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetCauHoiNV(label1.Text).Tables[0];
            dataGridView1.DataSource = dt;

        }
        public void ClearAll()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            
        }
        public void HienDA()
        {
            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetDapAn(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).Tables[0];
            textBox2.Text = dt.Rows[0][0].ToString();
            textBox3.Text = dt.Rows[1][0].ToString();
            textBox4.Text = dt.Rows[2][0].ToString();
            textBox5.Text = dt.Rows[3][0].ToString();

            label6.Text = dt.Rows[0][2].ToString();
            label7.Text = dt.Rows[1][2].ToString();
            label8.Text = dt.Rows[2][2].ToString();
            label9.Text = dt.Rows[3][2].ToString();


           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                label4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                HienDA();
            }
        }

        private void comboBox_mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetCauHoiNV_Mon(label1.Text,comboBox_mon.SelectedValue.ToString()).Tables[0];
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Chọn câu hỏi cần sửa");
            }
            else
            {
                tsbs = new ThiSinhBS();
                int kq = tsbs.UpdateCauHoi(textBox1.Text, label1.Text,label4.Text,textBox2.Text,label6.Text,textBox3.Text,label7.Text,textBox4.Text,label8.Text,textBox5.Text,label9.Text);
                if (kq!=0)
                {
                    MessageBox.Show("Đã cập nhật câu hỏi");
                    Data();
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }
    }
}