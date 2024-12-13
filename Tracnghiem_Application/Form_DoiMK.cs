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
    public partial class Form_DoiMK : Office2007Form
    {
        private NhanVienBS nvbs;
        public delegate string MyMK();
        public MyMK GetMK;
        public Form_DoiMK()
        {
            InitializeComponent();
        }

        private void Form_DoiMK_Load(object sender, EventArgs e)
        {
            label5.Text = GetMK();
            label5.Visible = false;
            nvbs = new NhanVienBS();
            DataTable dt=nvbs.GetTensTendn(label5.Text).Tables[0];
            label_ten.Text = dt.Rows[0][1].ToString();
            label_tendn.Text = dt.Rows[0][0].ToString();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (textBox_mkcu.Text == "" || textBox_mkmoi.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else
            {
                nvbs = new NhanVienBS();
                int kq=nvbs.DoiMatKhau(label_tendn.Text, textBox_mkcu.Text, textBox_mkmoi.Text);
                if (kq == 1)
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu hiện tại!");
                }
            }
        }
    }
}