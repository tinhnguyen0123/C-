﻿using DevComponents.DotNetBar;
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
    public partial class Form_QLCH : Office2007Form
    {
        private ThiSinhBS tsbs;
        public delegate string MyGet();
        public MyGet LayGT;
        public Form_QLCH()
        {
            InitializeComponent();
        }

        private void Form_QLCH_Load(object sender, EventArgs e)
        {
            label1.Text = LayGT();
            label1.Visible = false;

            
            label_a.Visible = false;
            label_b.Visible = false;
            label_c.Visible = false;
            label_d.Visible = false;

            Radio(false);
            Enl(false);
            Data();

            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetMonThi().Tables[0];
            comboBox_mon.DisplayMember = "TenMon";
            comboBox_mon.ValueMember = "MaMon";
            comboBox_mon.DataSource = dt;
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void HienDA()
        {
            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetDapAn(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).Tables[0];
            textBox2.Text = dt.Rows[0][0].ToString();
            textBox3.Text = dt.Rows[1][0].ToString();
            textBox4.Text= dt.Rows[2][0].ToString();
            textBox5.Text= dt.Rows[3][0].ToString();

            textBox2ma.Text = dt.Rows[0][2].ToString();
            textBox3ma.Text = dt.Rows[1][2].ToString();
            textBox4ma.Text = dt.Rows[2][2].ToString();
            textBox5ma.Text = dt.Rows[3][2].ToString();

        }

        private void radioButton_a_CheckedChanged(object sender, EventArgs e)
        {
            label_a.Text = "1";
            label_b.Text = "0";
            label_c.Text = "0";
            label_d.Text = "0";
        }

        private void radioButton_b_CheckedChanged(object sender, EventArgs e)
        {
            label_a.Text = "0";
            label_b.Text = "1";
            label_c.Text = "0";
            label_d.Text = "0";
        }

        private void radioButton_c_CheckedChanged(object sender, EventArgs e)
        {
            label_a.Text = "0";
            label_b.Text = "0";
            label_c.Text = "1";
            label_d.Text = "0";
        }

        private void radioButton_d_CheckedChanged(object sender, EventArgs e)
        {
            label_a.Text = "0";
            label_b.Text = "0";
            label_c.Text = "0";
            label_d.Text = "1";
        }
        public void ClearAll()
        {
            textBox1.Text= null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text= null;
            textBox1ma.Text = null;
            textBox2ma.Text = null;
            textBox3ma.Text = null;
            textBox4ma.Text = null;
            textBox5ma.Text = null;
        }
        public void Enl(bool b)
        {
            textBox1ma.Enabled = b;
            textBox2ma.Enabled = b;
            textBox3ma.Enabled = b;
            textBox4ma.Enabled = b;
            textBox5ma.Enabled = b;
        }
        public void Radio(bool a)
        {
            radioButton_a.Enabled = a;
            radioButton_b.Enabled = a;
            radioButton_c.Enabled = a;
            radioButton_d.Enabled = a;
            button_luu.Enabled = a;
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if (button_them.Text == "Thêm câu hỏi")
            {
                Radio(true);
                Enl(true);
                ClearAll();
                button_them.Text = "Hủy";
            }
            else
            {
                Radio(false);
                button_them.Text = "Thêm câu hỏi";
                Enl(false);
            }
        }
        public void Data()
        {
            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetCauHoiNV(label1.Text).Tables[0];
            dataGridView1.DataSource = dt;

        }

      
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                textBox1ma.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                HienDA();
            }
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox1ma.Text == "" || textBox2ma.Text == "" || textBox3ma.Text == "" || textBox4ma.Text == "" || textBox5ma.Text == ""||label_a.Text=="")
            {
                MessageBox.Show("Nhập đầy đủ! Chọn câu trả lời đúng");
            }
            
           
            else
            {
                try
                {
                    tsbs = new ThiSinhBS();
                    int kq = tsbs.ThemCauHoi(textBox1ma.Text, textBox1.Text, label1.Text, comboBox_mon.SelectedValue.ToString(), textBox2ma.Text, textBox2.Text, label_a.Text, textBox3ma.Text, textBox3.Text, label_b.Text, textBox4ma.Text, textBox4.Text, label_c.Text, textBox5ma.Text, textBox5.Text, label_d.Text);
                    if (kq == 5)
                    {
                        
                        ClearAll();
                        Enl(false);
                        Radio(false);
                        radioButton_a.Checked = false;
                        radioButton_b.Checked = false;
                        radioButton_c.Checked = false;
                        radioButton_d.Checked = false;
                        label_a.Text = "";
                        label_b.Text = "";
                        label_c.Text = "";
                        label_d.Text = "";

                        button_them.Text = "Thêm câu hỏi";
                        Data();
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {

                        MessageBox.Show("Thêm thất bại");
                        ClearAll();
                        Enl(false);
                        Radio(false);
                        button_them.Text = "Thêm câu hỏi";
                        Data();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Trùng mã câu hỏi hoặc mã câu trả lời");
                }
            }
        }

       

       
    }
}