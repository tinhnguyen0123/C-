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
    public partial class Form_CapMK : Office2007Form
    {
        private NhanVienBS nvbs;
        public delegate string GetGT();
        public GetGT LayChucVu;
        public GetGT LayMaNV;
        public Form_CapMK()
        {
            InitializeComponent();
        }

        private void Form_CapMK_Load(object sender, EventArgs e)
        {
            label4.Text = LayMaNV();
            label5.Text = LayChucVu();
            if (label5.Text.ToString().Trim() == "Nhan Vien")
            {
                label6.Text = "3";
            }
            else
            {
                label6.Text = "2";
            }
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (textBox_ma.Text == "" || textBox_tendn.Text == "" || textBox_mk.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    nvbs = new NhanVienBS();
                    int kq = nvbs.ThemTaiKhoan(textBox_ma.Text, textBox_tendn.Text, textBox_mk.Text, label6.Text, label4.Text);
                    if (kq == 1)
                    {
                        MessageBox.Show("Đã tạo tài khoản mới");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Trùng mã tài khoản");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Trùng mã tài khoản");
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}