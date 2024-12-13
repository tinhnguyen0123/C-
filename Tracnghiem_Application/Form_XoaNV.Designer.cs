namespace Tracnghiem_Application
{
    partial class Form_XoaNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_hoten = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_cv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_dc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_dt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ns = new System.Windows.Forms.TextBox();
            this.textBox_soch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_xoa = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhân viên:";
            // 
            // comboBox_hoten
            // 
            this.comboBox_hoten.FormattingEnabled = true;
            this.comboBox_hoten.Location = new System.Drawing.Point(115, 14);
            this.comboBox_hoten.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_hoten.Name = "comboBox_hoten";
            this.comboBox_hoten.Size = new System.Drawing.Size(306, 30);
            this.comboBox_hoten.TabIndex = 1;
            this.comboBox_hoten.SelectedIndexChanged += new System.EventHandler(this.comboBox_hoten_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chức vụ:";
            // 
            // textBox_cv
            // 
            this.textBox_cv.Location = new System.Drawing.Point(520, 15);
            this.textBox_cv.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_cv.Name = "textBox_cv";
            this.textBox_cv.Size = new System.Drawing.Size(136, 30);
            this.textBox_cv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã nhân viên:";
            // 
            // textBox_ma
            // 
            this.textBox_ma.Location = new System.Drawing.Point(115, 49);
            this.textBox_ma.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ma.Name = "textBox_ma";
            this.textBox_ma.Size = new System.Drawing.Size(168, 30);
            this.textBox_ma.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ:";
            // 
            // textBox_dc
            // 
            this.textBox_dc.Location = new System.Drawing.Point(425, 49);
            this.textBox_dc.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dc.Name = "textBox_dc";
            this.textBox_dc.Size = new System.Drawing.Size(231, 30);
            this.textBox_dc.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Điện thoại:";
            // 
            // textBox_dt
            // 
            this.textBox_dt.Location = new System.Drawing.Point(115, 83);
            this.textBox_dt.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dt.Name = "textBox_dt";
            this.textBox_dt.Size = new System.Drawing.Size(199, 30);
            this.textBox_dt.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(312, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số câu hỏi có trong ngân hàng câu hỏi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ngày sinh:";
            // 
            // textBox_ns
            // 
            this.textBox_ns.Location = new System.Drawing.Point(425, 83);
            this.textBox_ns.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ns.Name = "textBox_ns";
            this.textBox_ns.Size = new System.Drawing.Size(231, 30);
            this.textBox_ns.TabIndex = 14;
            // 
            // textBox_soch
            // 
            this.textBox_soch.Location = new System.Drawing.Point(267, 117);
            this.textBox_soch.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_soch.Name = "textBox_soch";
            this.textBox_soch.Size = new System.Drawing.Size(75, 30);
            this.textBox_soch.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(427, 132);
            this.label9.TabIndex = 16;
            this.label9.Text = "Lưu ý:  Nếu nhân viên bị xóa thì :\r\n\r\n          - Thông tin của nhân viên sẽ bị x" +
    "óa.\r\n          - Tài khoản đăng nhập của nhân viên sẽ bị xóa.\r\n          \r\n\r\n";
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(539, 214);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(117, 26);
            this.button_xoa.TabIndex = 17;
            this.button_xoa.Text = "Xóa nhân viên";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "hnZL4ItLdNpfUF6pJmVj0Pzm3kROJpP2OpkHiQki5aIPXy98fHNhfQ==";
            this.skinEngine1.SkinFile = null;
            // 
            // Form_XoaNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(672, 254);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_soch);
            this.Controls.Add(this.textBox_ns);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_dt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_dc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_ma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_cv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_hoten);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_XoaNV";
            this.Text = "Xóa nhân viên";
            this.Load += new System.EventHandler(this.Form_XoaNV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_hoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_cv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_dc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_dt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ns;
        private System.Windows.Forms.TextBox textBox_soch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_xoa;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}