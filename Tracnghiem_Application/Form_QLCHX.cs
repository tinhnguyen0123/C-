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
    public partial class Form_QLCHX : Office2007Form
    {
        private ThiSinhBS tsbs;
        public delegate string MyGet();
        public MyGet Laygt;
        public Form_QLCHX()
        {
            InitializeComponent();
            tsbs = new ThiSinhBS();
        }

        private void Form_QLCHX_Load(object sender, EventArgs e)
        {
            label1.Text = Laygt();
            label1.Visible = false;
            label4.Visible = false;

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
            DataTable dt = tsbs.GetCauHoiNV_Mon(label1.Text, comboBox_mon.SelectedValue.ToString()).Tables[0];
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
       
           if (textBox1.Text == "")
           {
               MessageBox.Show("Chọn câu hỏi muốn xóa");
           }
           else
           {
               try
               {
                   tsbs = new ThiSinhBS();
                   int kq = tsbs.DeleteCauHoi(label4.Text);
                   if (kq !=0)
                   {
                       MessageBox.Show("Xóa thành công");
                       ClearAll();
                       Data();
                   }
                   else
                   {

                       MessageBox.Show("Không xóa được");
                       ClearAll();
                       Data();
                   }
               }
               catch (Exception)
               {
                   MessageBox.Show("Không xóa được");
               }
           }
       }

    }
}