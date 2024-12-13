namespace Tracnghiem_Application
{
    partial class Form_Dangnhap
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
            this.radioButton_thisinh = new System.Windows.Forms.RadioButton();
            this.radioButton_quanli = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_pa = new System.Windows.Forms.TextBox();
            this.textBox_dn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_dn = new System.Windows.Forms.Button();
            this.button_thoat = new System.Windows.Forms.Button();
            this.button_doimk = new System.Windows.Forms.Button();
            this.button_dk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_dn2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_thisinh
            // 
            this.radioButton_thisinh.AutoSize = true;
            this.radioButton_thisinh.Location = new System.Drawing.Point(36, 26);
            this.radioButton_thisinh.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_thisinh.Name = "radioButton_thisinh";
            this.radioButton_thisinh.Size = new System.Drawing.Size(235, 26);
            this.radioButton_thisinh.TabIndex = 0;
            this.radioButton_thisinh.TabStop = true;
            this.radioButton_thisinh.Text = "Đăng nhập thi trắc nghiệm";
            this.radioButton_thisinh.UseVisualStyleBackColor = true;
            this.radioButton_thisinh.CheckedChanged += new System.EventHandler(this.radioButton_thisinh_CheckedChanged);
            // 
            // radioButton_quanli
            // 
            this.radioButton_quanli.AutoSize = true;
            this.radioButton_quanli.Location = new System.Drawing.Point(341, 26);
            this.radioButton_quanli.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_quanli.Name = "radioButton_quanli";
            this.radioButton_quanli.Size = new System.Drawing.Size(228, 26);
            this.radioButton_quanli.TabIndex = 1;
            this.radioButton_quanli.TabStop = true;
            this.radioButton_quanli.Text = "Đăng nhập quyền quản lý";
            this.radioButton_quanli.UseVisualStyleBackColor = true;
            this.radioButton_quanli.CheckedChanged += new System.EventHandler(this.radioButton_quanli_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_pa);
            this.groupBox1.Controls.Add(this.textBox_dn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(489, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thí sinh";
            // 
            // textBox_pa
            // 
            this.textBox_pa.Location = new System.Drawing.Point(171, 108);
            this.textBox_pa.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_pa.Name = "textBox_pa";
            this.textBox_pa.PasswordChar = '*';
            this.textBox_pa.Size = new System.Drawing.Size(282, 30);
            this.textBox_pa.TabIndex = 3;
            this.textBox_pa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_pa_KeyDown);
            // 
            // textBox_dn
            // 
            this.textBox_dn.Location = new System.Drawing.Point(171, 48);
            this.textBox_dn.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dn.Name = "textBox_dn";
            this.textBox_dn.Size = new System.Drawing.Size(282, 30);
            this.textBox_dn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thí sinh:";
            // 
            // button_dn
            // 
            this.button_dn.Location = new System.Drawing.Point(295, 259);
            this.button_dn.Margin = new System.Windows.Forms.Padding(4);
            this.button_dn.Name = "button_dn";
            this.button_dn.Size = new System.Drawing.Size(113, 29);
            this.button_dn.TabIndex = 3;
            this.button_dn.Text = "Đăng nhập";
            this.button_dn.UseVisualStyleBackColor = true;
            this.button_dn.Click += new System.EventHandler(this.button_dn_Click);
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(416, 259);
            this.button_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(105, 29);
            this.button_thoat.TabIndex = 4;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // button_doimk
            // 
            this.button_doimk.Location = new System.Drawing.Point(31, 259);
            this.button_doimk.Margin = new System.Windows.Forms.Padding(4);
            this.button_doimk.Name = "button_doimk";
            this.button_doimk.Size = new System.Drawing.Size(109, 29);
            this.button_doimk.TabIndex = 5;
            this.button_doimk.Text = "Đổi mật khẩu";
            this.button_doimk.UseVisualStyleBackColor = true;
            this.button_doimk.Click += new System.EventHandler(this.button_doimk_Click);
            // 
            // button_dk
            // 
            this.button_dk.Location = new System.Drawing.Point(148, 260);
            this.button_dk.Margin = new System.Windows.Forms.Padding(4);
            this.button_dk.Name = "button_dk";
            this.button_dk.Size = new System.Drawing.Size(109, 29);
            this.button_dk.TabIndex = 6;
            this.button_dk.Text = "Đăng kí";
            this.button_dk.UseVisualStyleBackColor = true;
            this.button_dk.Click += new System.EventHandler(this.button_dk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên đăng nhập:";
            // 
            // textBox_dn2
            // 
            this.textBox_dn2.Location = new System.Drawing.Point(202, 39);
            this.textBox_dn2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dn2.Name = "textBox_dn2";
            this.textBox_dn2.Size = new System.Drawing.Size(282, 30);
            this.textBox_dn2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(33, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quên mật khẩu?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "hnZL4ItLdNpfUF6pJmVj0Pzm3kROJpP2OpkHiQki5aIPXy98fHNhfQ==";
            this.skinEngine1.SkinFile = null;
            // 
            // Form_Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(555, 306);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_dn2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_dk);
            this.Controls.Add(this.button_doimk);
            this.Controls.Add(this.button_thoat);
            this.Controls.Add(this.button_dn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton_quanli);
            this.Controls.Add(this.radioButton_thisinh);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Dangnhap";
            this.Text = "Chương trình thi trắc nghiệm";
            this.Load += new System.EventHandler(this.Form_Dangnhap_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_Dangnhap_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_thisinh;
        private System.Windows.Forms.RadioButton radioButton_quanli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_pa;
        private System.Windows.Forms.TextBox textBox_dn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_dn;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.Button button_doimk;
        private System.Windows.Forms.Button button_dk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_dn2;
        private System.Windows.Forms.Label label4;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}

