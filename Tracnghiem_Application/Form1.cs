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
    public partial class Form_Dangnhap : Office2007Form
    {
        private ThiSinhBS tsbs;
        private NhanVienBS nvbs;
        public delegate string Mydlg();
        public Mydlg GetStringFromAnotherFormdn;
        
        public Form_Dangnhap()
        {
            InitializeComponent();
        }
        
        private void radioButton_quanli_CheckedChanged(object sender, EventArgs e)
        {
            textBox_dn.Text = "";
            textBox_pa.Text = "";
            label1.Text = "Tên người quản lý:";
            groupBox1.Text = "Thông tin người quản lý";
            button_doimk.Visible = false;
            button_dk.Visible = false;
            label4.Visible = false;
        }

        private void radioButton_thisinh_CheckedChanged(object sender, EventArgs e)
        {
            textBox_dn.Text = "";
            textBox_pa.Text = "";
            label1.Text = "Tên thí sinh:";
            groupBox1.Text = "Thông tin thí sinh:";
            button_doimk.Visible = true;
            button_dk.Visible = true;
            label4.Visible = true;
        }

        private void Form_Dangnhap_Load(object sender, EventArgs e)
        {
            textBox_dn.Focus();
            button_doimk.Visible = true;
            button_dk.Visible = true;
            label3.Visible = false;
            textBox_dn2.Visible = false;
            
            
        }
      
        private void button_dn_Click(object sender, EventArgs e)
        {

            if (radioButton_thisinh.Checked == true)
            {
                if (textBox_dn.Text == "" || textBox_pa.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin của thí sinh");
                    textBox_dn.Focus();
                }
                else
                {
                    tsbs = new ThiSinhBS();
                    DataTable dt = new DataTable();
                    dt = tsbs.GetThiSinhDN(textBox_dn.Text, textBox_pa.Text).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        ThongtinTS ts = new ThongtinTS();
                        ts.GetStringFromAnotherForm += delegate { return textBox_pa.Text; };
                        ts.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không tồn tại");
                    }
                    
                    
                }
            }
            else
            {
                if (textBox_dn.Text == "" || textBox_pa.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin của người quản lý");
                    textBox_dn.Focus();
                }
                else
                {
                    nvbs = new NhanVienBS();
                    DataTable dt = new DataTable();
                    dt = nvbs.DangNhapNV(textBox_dn.Text, textBox_pa.Text).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr;
                        dr=dt.Rows[0];
                        Form_Dieuhanh d = new Form_Dieuhanh();
                        d.GetStringFromAnotherFormdn += delegate { return textBox_pa.Text; };
                        d.GetStringFromAnotherFormdn2 += delegate { return dr[10].ToString(); };
                        d.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                    }
                }
            }
        }
        
        private void button_thoat_Click(object sender, EventArgs e)
        {
            DialogResult OK;
            OK = MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (OK == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                return;
        }

        private void button_doimk_Click(object sender, EventArgs e)
        {
            if (button_doimk.Text == "Đổi mật khẩu")
            {
                textBox_dn.Text ="";
                textBox_pa.Text = "";
                radioButton_quanli.Visible = false;
                radioButton_thisinh.Visible = false;
                button_thoat.Visible = false;
                button_dn.Visible = false;
                label1.Text = "Mật khẩu cũ:";
                label2.Text = "Mật khẩu mới:";
                groupBox1.Text = "Thông tin mật khẩu";
                button_dk.Text = "Xác nhận";
                button_doimk.Text = "Quay lại";
                label3.Visible = true;
                textBox_dn2.Visible = true ;
                label4.Visible = false;
            }
            else
            {
                this.status();
            }
        }
        public void status()
        {
            textBox_dn.Text = "";
            textBox_pa.Text = "";
            textBox_dn2.Text = "";
            radioButton_quanli.Visible = true;
            radioButton_thisinh.Visible = true;
            button_thoat.Visible = true;
            button_dn.Visible = true;
            label1.Text = "Tên thí sinh:";
            label2.Text = "Mật khẩu:";
            groupBox1.Text = "Thông tin thí sinh";
            button_dk.Text = "Đăng kí";
            button_doimk.Text = "Đổi mật khẩu";
            label3.Visible = false;
            textBox_dn2.Visible = false;
            label4.Visible = true;
        }

        private void button_dk_Click(object sender, EventArgs e)
        {
            if (button_dk.Text == "Đăng kí")
            {
                this.Hide();
                Dangky dk = new Dangky();
                dk.Show();
            }
            if (button_dk.Text == "Xác nhận")
            {
                if (textBox_dn2.Text == "" || textBox_dn.Text == "" || textBox_pa.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    try
                    {
                        tsbs = new ThiSinhBS();

                        int a=tsbs.DoiMatKhau(textBox_dn2.Text, textBox_dn.Text, textBox_pa.Text);
                        if (a == 1)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công");
                            textBox_dn2.Clear();
                            textBox_dn.Clear();
                            textBox_pa.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Thông tin sai");
                        }
                    }
                    catch (Exception)
                    {
                        throw new Exception("Thông tin sai!");
                    }
                }
            }
            if (button_dk.Text == "Lấy mật khẩu")
            {
                if (textBox_dn.Text == "" || textBox_pa.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    tsbs = new ThiSinhBS();
                    DataTable dt = new DataTable();
                    dt = tsbs.GetMatKhau(textBox_pa.Text, textBox_dn.Text).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr;
                        dr = dt.Rows[0];
                        MessageBox.Show("Chào bạn: "+dr[1].ToString()+"    Mật khẩu của bạn là: " + dr[5].ToString());
                        
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc Mã thí sinh không tồn tại");
                    }
                }
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox_dn.Text = "";
            textBox_pa.Text = "";
            radioButton_quanli.Visible = false;
            radioButton_thisinh.Visible = false;
            button_thoat.Visible = false;
            button_dn.Visible = false;
            label1.Text = "Tên đăng nhập:";
            label2.Text = "Mã thí sinh:";
            groupBox1.Text = "Lấy lại mật khẩu";
            button_dk.Text = "Lấy mật khẩu";
            button_doimk.Text = "Quay lại";
            label3.Visible = false;
            textBox_dn2.Visible = false;
            label4.Visible = false;
        }

        private void textBox_pa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                button_dn_Click(sender, e);
            }
        }

        private void Form_Dangnhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button_thoat_Click(sender, e);
            }
            if (e.KeyCode == Keys.F11)
            {
                radioButton_quanli_CheckedChanged(sender, e);
                radioButton_quanli.Checked = true;
                textBox_dn.Focus();
            }
            if (e.KeyCode == Keys.F12)
            {
                radioButton_thisinh_CheckedChanged(sender, e);
                radioButton_thisinh.Checked = true;
                textBox_dn.Focus();
            }
            if (e.KeyCode == Keys.F1)
            {
                label4_Click(sender, e);
            }
            if (e.KeyCode == Keys.F2)
            {
                button_doimk_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
                button_dk_Click(sender, e);

            }
        }
    }
}