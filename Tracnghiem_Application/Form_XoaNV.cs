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
    public partial class Form_XoaNV : Office2007Form
    {
        private NhanVienBS nvbs;
        public Form_XoaNV()
        {
            InitializeComponent();
        }
        public void LoadCombo()
        {
            nvbs = new NhanVienBS();
            DataTable dt = nvbs.GetNhanVienL2().Tables[0];
            
            comboBox_hoten.DisplayMember = "HoTen";
            comboBox_hoten.ValueMember = "MaNhanVien";
            comboBox_hoten.DataSource = dt;
        }
        public void LoadText()
        {
            nvbs = new NhanVienBS();
            DataTable dt = nvbs.GetNhanVien_Ma(comboBox_hoten.SelectedValue.ToString()).Tables[0];
            textBox_ma.Text = dt.Rows[0][1].ToString();
            textBox_dc.Text = dt.Rows[0][2].ToString();
            textBox_dt.Text = dt.Rows[0][3].ToString();
            textBox_ns.Text = dt.Rows[0][4].ToString();
            if (dt.Rows[0][5].ToString().Trim()== "Nhan Vien")
            {
                textBox_cv.Text = "Nhân viên";
            }
            else
            {
                textBox_cv.Text = "Quản lý";
            }
            LaySoCH();
        }
        public void LaySoCH()
        {
            nvbs = new NhanVienBS();
            DataTable dt = nvbs.GetSoCH_MaNV(comboBox_hoten.SelectedValue.ToString()).Tables[0];
            textBox_soch.Text = dt.Rows[0][0].ToString();
        }
        public void Cleartext()
        {
            textBox_cv.Text = "";
            textBox_dc.Text = "";
            textBox_dt.Text = "";
            textBox_ma.Text = "";
            textBox_ns.Text = "";
            textBox_soch.Text = "";
        }
        private void Form_XoaNV_Load(object sender, EventArgs e)
        {
            LoadCombo();
            Cleartext();
        }

        private void comboBox_hoten_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadText();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (textBox_ma.Text == "")
            {
                MessageBox.Show("Chọn nhân viên muốn xóa");
            }
            else
            {
                if (textBox_soch.Text != "0")
                {
                    MessageBox.Show("Nhân viên: "+comboBox_hoten.Text+"Nhân viên này có: "+textBox_soch.Text+" câu hỏi trong ngân hàng câu hỏi. Bạn không thể xóa nhân viên này!");
                    Cleartext();
                }
                else
                {
                    DialogResult OK;
                    OK = MessageBox.Show("Nhân viên: " + comboBox_hoten.Text + "Nhân viên này không có câu hỏi nào trong ngân hàng câu hỏi. Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (OK == DialogResult.Yes)
                    {
                        nvbs = new NhanVienBS();
                        int kq = nvbs.DeleteNhanVien_0(comboBox_hoten.SelectedValue.ToString());
                        if (kq != 0)
                        {
                            MessageBox.Show("Đã xóa nhân viên có tên: " + comboBox_hoten.Text);
                            
                            LoadCombo();
                            Cleartext();
                        }
                    }
                    else
                    {
                        Cleartext();
                        return;

                    }
                }
            }
        }
    }
}