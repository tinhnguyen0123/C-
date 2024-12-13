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
    public partial class Form_Dieuhanh : Office2007Form
    {
        private NhanVienBS nvbs;
        private ThiSinhBS tsbs;
        public delegate string Mydlg();
        public Mydlg GetStringFromAnotherFormdn;
        public Mydlg GetStringFromAnotherFormdn2;
        public int sl;
        public int flag=0;
        public Form_Dieuhanh()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void Form_Dieuhanh_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            label3.Text = GetStringFromAnotherFormdn2();
            quảnLýToolStripMenuItem.Enabled = false;
            toolStripButton5.Enabled = false;
            toolStripButton6.Enabled = false;
            toolStripButton7.Enabled = false;
           
            label1.Visible = false;
            label3.Visible = false;
            label1.Text = GetStringFromAnotherFormdn();
            
            nvbs = new NhanVienBS();
            DataTable dt = new DataTable();
            dt = nvbs.ThongTinNV(label1.Text).Tables[0];
            DataRow dr;
            dr = dt.Rows[0];
            label2.Text = "Tên nhân viên: " + dr[1].ToString() ;
            label4.Text = dr[6].ToString();
            label12.Text = dr[0].ToString();
            label11.Visible = false;
            label12.Visible = false;
            label4.Visible = false;
            if (label3.Text.ToString().Trim() == "Dieu Hanh")
            {
                quảnLýToolStripMenuItem.Enabled = true;
                toolStripButton5.Enabled = true;
                toolStripButton6.Enabled = true;
                toolStripButton7.Enabled = true;
                label11.Text = "Điều hành";
                
                
            }
            if (label3.Text.ToString().Trim() == "Quan Li")
            {
                
                label11.Text = "Quản lý";
            }
            if (label3.Text.ToString().Trim() == "Nhan Vien")
            {
                label11.Text = "Nhân viên";
            }
            label_luu.Enabled = false;
            TimKQ();
            
        }
        Boolean KiemTraTonTai(string Frmname)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(Frmname))
                {
                    frm.Activate();
                    return true;
                }
            }
            return false;
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Dangnhap f = new Form_Dangnhap();
            f.Show();
            this.Hide();
        }

       
        private void QLNGCHToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_TTNHCH") == false)
            {
                Form_QLCH f = new Form_QLCH();
                f.Name = "Form_TTNHCH";
                f.MdiParent = this;
                f.Show();
            }
        }

        private void quảnLíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ngânHàngCâuHỏiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_TTNHCH") ==false)
            {
                Form_TTNHCH f = new Form_TTNHCH();
                f.Name = "Form_TTNHCH";
                f.MdiParent = this;
                f.Show();
            }
        }

        private void danhSáchThíSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_TTDSTS") == false)
            {
                Form_TTDSTS f = new Form_TTDSTS();
                f.Name = "Form_TTDSTS";
                f.MdiParent = this;
                f.Show();
            }
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_TTDSNV") == false)
            {
                Form_TTDSNV f = new Form_TTDSNV();
                f.Name = "Form_TTDSNV";
                f.MdiParent = this;
                f.Show();
            }
        }

        private void danhSáchKếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_TTDSKQ") == false)
            {
                Form_TTDSKQ f = new Form_TTDSKQ();
                f.Name = "Form_TTDSKQ";
                f.MdiParent = this;
                f.Show();
            }
        }

      

       

       

       

        private void label_doimk_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_DoiMK") == false)
            {
                Form_DoiMK f = new Form_DoiMK();
                f.Name = "Form_DoiMK";
                f.MdiParent = this;
                f.GetMK += delegate { return label1.Text; };
                f.Show();
                label_doimk.Enabled = false;
            }
        }

        private void QLNGCHToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_QLCH") == false)
            {
                Form_QLCH f = new Form_QLCH();
                f.Name = "Form_QLCH";
                f.MdiParent = this;
                f.LayGT += delegate { return label4.Text; };
                f.Show();
            }
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_QLCHCS") == false)
            {
                Form_QLCHCS f = new Form_QLCHCS();
                f.Name = "Form_QLCHCS";
                f.MdiParent = this;
                f.Laygt += delegate { return label4.Text; };
                f.Show();
            }
        }

        private void thíSinhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_QLCHX") == false)
            {
                Form_QLCHX f = new Form_QLCHX();
                f.Name = "Form_QLCHX";
                f.MdiParent = this;
                f.Laygt += delegate { return label4.Text; };
                f.Show();
            }
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_QLNV") == false)
            {
                Form_QLNV f = new Form_QLNV();
                f.Name = "Form_QLNV";
                f.MdiParent = this;
                f.Show();
            }
        }

        private void label_tt_Click(object sender, EventArgs e)
        {
            if (label_tt.Text == "Hiện thông tin cá nhân")
            {
                panel1.Visible = true;
                label_tt.Text = "Ẩn thông tin cá nhân";
                HienTTNV();
                TextBoxF();
            }
            else
            {
                panel1.Visible = false;
                label_tt.Text ="Hiện thông tin cá nhân";
                TextBoxF();
            }
        }
        public void HienTTNV()
        {
            nvbs = new NhanVienBS();
            DataTable dt = nvbs.GetNhanVien_Ma(label12.Text).Tables[0];
            textBox_ma.Text = dt.Rows[0][0].ToString();
            textBox_ten.Text = dt.Rows[0][1].ToString();
            textBox_dc.Text = dt.Rows[0][2].ToString();
            textBox_sdt.Text=dt.Rows[0][3].ToString();
            textBox_ns.Text = dt.Rows[0][4].ToString();
            if (label3.Text.ToString().Trim() == "Dieu Hanh")
            {
               
                textBox_cv.Text = "Điều hành";
            }
            if (label3.Text.ToString().Trim() == "Quan Li")
            {

                textBox_cv.Text = "Quản lý";
            }
            if (label3.Text.ToString().Trim() == "Nhan Vien")
            {
                textBox_cv.Text = "Nhân viên";
            }
        }
        public void TextBox()
        {
            
            textBox_dc.BorderStyle = BorderStyle.FixedSingle;
            textBox_sdt.BorderStyle= BorderStyle.FixedSingle;
            textBox_ns.BorderStyle = BorderStyle.FixedSingle;
        }
        public void TextBoxF()
        {
            
            textBox_dc.BorderStyle = BorderStyle.None;
            textBox_sdt.BorderStyle = BorderStyle.None;
            textBox_ns.BorderStyle = BorderStyle.None;
        }

        private void label1_cs_Click(object sender, EventArgs e)
        {
            if (label1_cs.Text == "Chỉnh sửa")
            {
                TextBox();
                label1_cs.Text = "Hủy thao tác";
                label_luu.Enabled= true;
            }
            else
            {
                TextBoxF();
                HienTTNV();
                label1_cs.Text = "Chỉnh sửa";
                label_luu.Enabled= false;
            }
        }

        private void label_luu_Click(object sender, EventArgs e)
        {
            nvbs = new NhanVienBS();
            int kq = nvbs.UpdateNhanvien(textBox_dc.Text.ToString().Trim(), textBox_sdt.Text.ToString().Trim(), textBox_ns.Text.ToString().Trim(), textBox_ma.Text.ToString().Trim());
            if (kq == 1)
            {
                MessageBox.Show("Đã cập nhật thao tác");
                label_luu.Enabled = false;
                label1_cs.Text = "Chỉnh sửa";
                TextBoxF();
                HienTTNV();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (label_tk.Text == "Tìm kiếm")
            {
                 tsbs = new ThiSinhBS();
                DataTable dt = tsbs.GetCauHoi_Ghichu(textBox_timkiem.Text).Tables[0];
                sl = dt.Rows.Count;
                if(sl!=0)
                {
                panel2.Visible = true;
                KetQua(0);
                label_tk.Text = "Hủy";
                TimKQ();
                Label(true);
                }
                else
                {
                    panel2.Visible = true;
                    label_ts.Text = "0";
                    label_tk.Text = "Hủy";
                    label_ndcauhoi.Text = "Không tìm thấy câu hỏi có nội dung liên quan!";
                    Label(false);

                }
            }
            else
            {
                panel2.Visible = false;
                label_tk.Text = "Tìm kiếm";
                textBox_timkiem.Text = "";
            }
        }
        public void KetQua(int i)
        {
            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetCauHoi_Ghichu(textBox_timkiem.Text).Tables[0];
            DataRow dr = dt.Rows[i];
            label_ndcauhoi.Text ="Nội dung câu hỏi "+(i+1)+ ": "+ dr[0].ToString();
        }
        public void TimKQ()
        {
            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetCauHoi_Ghichu(textBox_timkiem.Text).Tables[0];
            sl = dt.Rows.Count;
            
            label_ts.Text = sl.ToString();
           
        }

        private void label_dautien_Click(object sender, EventArgs e)
        {
            KetQua(0);
            flag = 0;
        }

        private void label_truoc_Click(object sender, EventArgs e)
        {
            if (this.flag == 0)
            {
                KetQua(0);
            }
            else
            {
                this.flag--;
                KetQua(flag);
            }
        }

        private void label_sau_Click(object sender, EventArgs e)
        {
            if (this.flag == (this.sl) - 1)
            {
                KetQua(this.sl - 1);
            }
            else
            {
                this.flag++;
                KetQua(flag);
            }
        }

        private void label_cuoicung_Click(object sender, EventArgs e)
        {
            KetQua(sl - 1);
            flag = sl - 1;
        }
        public void Label(bool a)
        {
            label_dautien.Enabled = a;
            label_cuoicung.Enabled = a;
            label_sau.Enabled = a;
            label_truoc.Enabled = a;
        }

        private void xóaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_XoaNV") == false)
            {
                Form_XoaNV f = new Form_XoaNV();
                f.Name = "Form_XoaNV";
                f.MdiParent = this;
                f.Show();
            }
        }

        private void mônThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_QLMT") == false)
            {
                Form_QLMT f = new Form_QLMT();
                f.Name = "Form_QLMT";
                f.MdiParent = this;
                f.Show();
            }
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_LienHe") == false)
            {
                Form_LienHe f = new Form_LienHe();
                f.Name = "Form_LienHe";
                f.MdiParent = this;
                f.Show();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_TTNHCH") == false)
            {
                Form_TTNHCH f = new Form_TTNHCH();
                f.Name = "Form_TTNHCH";
                f.MdiParent = this;
                f.Show();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_TTDSTS") == false)
            {
                Form_TTDSTS f = new Form_TTDSTS();
                f.Name = "Form_TTDSTS";
                f.MdiParent = this;
                f.Show();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_TTDSNV") == false)
            {
                Form_TTDSNV f = new Form_TTDSNV();
                f.Name = "Form_TTDSNV";
                f.MdiParent = this;
                f.Show();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_TTDSKQ") == false)
            {
                Form_TTDSKQ f = new Form_TTDSKQ();
                f.Name = "Form_TTDSKQ";
                f.MdiParent = this;
                f.Show();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_QLNV") == false)
            {
                Form_QLNV f = new Form_QLNV();
                f.Name = "Form_QLNV";
                f.MdiParent = this;
                f.Show();
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_XoaNV") == false)
            {
                Form_XoaNV f = new Form_XoaNV();
                f.Name = "Form_XoaNV";
                f.MdiParent = this;
                f.Show();
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_QLMT") == false)
            {
                Form_QLMT f = new Form_QLMT();
                f.Name = "Form_QLMT";
                f.MdiParent = this;
                f.Show();
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_QLCH") == false)
            {
                Form_QLCH f = new Form_QLCH();
                f.Name = "Form_QLCH";
                f.MdiParent = this;
                f.LayGT += delegate { return label4.Text; };
                f.Show();
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_QLCHX") == false)
            {
                Form_QLCHX f = new Form_QLCHX();
                f.Name = "Form_QLCHX";
                f.MdiParent = this;
                f.Laygt += delegate { return label4.Text; };
                f.Show();
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("Form_QLCHCS") == false)
            {
                Form_QLCHCS f = new Form_QLCHCS();
                f.Name = "Form_QLCHCS";
                f.MdiParent = this;
                f.Laygt += delegate { return label4.Text; };
                f.Show();
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
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

        private void Form_Dieuhanh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                toolStripButton11_Click(sender, e);
            }
            if (e.KeyCode == Keys.F1)
            {
                liênHệToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.Home)
            {
                label_tt_Click(sender, e);
            }
            if (e.KeyCode == Keys.F2)
            {
                label_doimk_Click(sender, e);
            }
            if (e.KeyCode == Keys.End)
            {
                đăngNhậpToolStripMenuItem_Click(sender, e);
            }
        }

        private void textBox_timkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                label14_Click(sender, e);
            }
        }

       
    }
}