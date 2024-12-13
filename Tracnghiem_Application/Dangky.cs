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
    public partial class Dangky : Office2007Form
    {
        
        ThiSinhBS tsbs;
        public Dangky()
        {
            InitializeComponent();
        }

        private void button_quay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Dangnhap dn = new Form_Dangnhap();
            dn.Show();
        }
        public void Clearall()
        {
            textBox_ma.Text = "";
            textBox_ten.Text ="";
            textBox_dc.Text = "";
            textBox_ns.Text = "";
            textBox_tendn.Text = "";
            textBox_mk.Text = "";
        }
        private void button_xacnhan_Click(object sender, EventArgs e)
        {
            if (textBox_ma.Text == "" || textBox_ten.Text == "" || textBox_dc.Text == "" || textBox_ns.Text == "" || textBox_tendn.Text == "" || textBox_mk.Text == "") 
            {
                MessageBox.Show("Nhập đầy đủ thông tin đăng kí");
                textBox_ma.Focus();
            }
            else
            {
                try
                {
                   tsbs = new ThiSinhBS();
                    tsbs.dangki(textBox_ma.Text, textBox_ten.Text, textBox_dc.Text, textBox_ns.Text, textBox_tendn.Text, textBox_mk.Text);
                    DialogResult OK;
                    OK = MessageBox.Show("Đã đăng kí thành công, Bạn muốn đăng nhập bằng tên đã đăng kí không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (OK == DialogResult.Yes)
                    {
                        Form_Dangnhap d = new Form_Dangnhap();
                        d.GetStringFromAnotherFormdn += delegate { return textBox_tendn.Text; };
                        d.Show();
                        this.Hide();
                    }
                    else
                    {
                        return;
                        
                    }
                    this.Clearall();
                }
                catch(Exception)
                {
                    MessageBox.Show("Mã thí sinh này đã tồn tại");
                }
            }
        }

        private void Dangky_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button_quay_Click(sender, e);
            }
            if(e.KeyCode==Keys.End)
            {
                button_xacnhan_Click(sender,e);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}