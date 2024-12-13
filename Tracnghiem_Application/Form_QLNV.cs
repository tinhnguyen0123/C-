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
    public partial class Form_QLNV : Office2007Form
    {
        private NhanVienBS nvbs;
        public Form_QLNV()
        {
            InitializeComponent();
        }

        private void Form_QLNV_Load(object sender, EventArgs e)
        {
            LoadComBo();
            textBox_ten.Visible = false;
            Clear();
        }
        public void LoadComBo()
        {
            nvbs = new NhanVienBS();
            DataTable dt = nvbs.GetNhanVienL2().Tables[0];
            comboBox_ten.DisplayMember = "HoTen";
            comboBox_ten.ValueMember = "MaNhanVien";
            comboBox_ten.DataSource = dt;
        }
        public void LoadData()
        {
            nvbs = new NhanVienBS();
            DataTable dt = nvbs.GetNhanVien_Ma(comboBox_ten.SelectedValue.ToString()).Tables[0];
            textBox_ma.Text = dt.Rows[0][0].ToString();
            textBox_dc.Text = dt.Rows[0][2].ToString();
            textBox_dt.Text = dt.Rows[0][3].ToString();
            textBox_ns.Text = dt.Rows[0][4].ToString();
            comboBox_cv.Text = dt.Rows[0][5].ToString();
        }

        private void comboBox_ten_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        public void Status()
        {
            textBox_ten.Visible = true;
            comboBox_ten.Visible = false;
            textBox_ten.Text ="";
            textBox_ma.Text ="";
            textBox_dc.Text = "";
            textBox_dt.Text ="";
            textBox_ns.Text ="";
            nvbs = new NhanVienBS();
            DataTable dt = nvbs.GetNhanVienL2().Tables[0];
            comboBox_cv.DisplayMember = "ChucVu";
            comboBox_cv.ValueMember = "ChucVu";
            comboBox_cv.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Thêm")
            {
                Status();
                button1.Text = "Hủy";
               
            }
            else
            {
                comboBox_ten.Visible = true;
                textBox_ten.Visible = false;
                LoadComBo();
                comboBox_cv.Text = "";
                Clear();
                button1.Text = "Thêm";
                
            }
        }
        public void Clear()
        {
            textBox_ma.Text = "";
            textBox_dc.Text = "";
            textBox_dt.Text = "";
            textBox_ns.Text = "";
            comboBox_cv.Text = "";
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            
                if (textBox_ten.Text == "" || textBox_ma.Text == "" || textBox_dc.Text == "" || textBox_ns.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    try
                    {
                        nvbs = new NhanVienBS();
                        int kq = nvbs.ThemNV(textBox_ma.Text, textBox_ten.Text, textBox_dc.Text, textBox_dt.Text, textBox_ns.Text, comboBox_cv.SelectedValue.ToString());
                        if (kq == 1)
                        {
                            MessageBox.Show("Đã thêm nhân viên mới");

                            Form_CapMK f = new Form_CapMK();

                            f.LayChucVu += delegate { return comboBox_cv.SelectedValue.ToString(); };
                            f.LayMaNV += delegate { return textBox_ma.Text; };
                            f.Show();




                            comboBox_ten.Visible = true;
                            textBox_ten.Visible = false;
                            Clear();
                            LoadComBo();
                            button1.Text = "Thêm";

                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Trùng mã nhân viên");
                            comboBox_ten.Visible = true;
                            textBox_ten.Visible = false;
                            Clear();
                            LoadComBo();
                            button1.Text = "Thêm";

                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Trùng mã nhân viên");
                    }
                }
            
        }
    }
}