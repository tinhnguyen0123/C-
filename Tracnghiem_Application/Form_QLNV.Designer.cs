namespace Tracnghiem_Application
{
    partial class Form_QLNV
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
            this.comboBox_ten = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_dc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_dt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ns = new System.Windows.Forms.TextBox();
            this.comboBox_cv = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_ten = new System.Windows.Forms.TextBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhân viên:";
            // 
            // comboBox_ten
            // 
            this.comboBox_ten.FormattingEnabled = true;
            this.comboBox_ten.Location = new System.Drawing.Point(162, 26);
            this.comboBox_ten.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_ten.Name = "comboBox_ten";
            this.comboBox_ten.Size = new System.Drawing.Size(320, 27);
            this.comboBox_ten.TabIndex = 1;
            this.comboBox_ten.SelectedIndexChanged += new System.EventHandler(this.comboBox_ten_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên:";
            // 
            // textBox_ma
            // 
            this.textBox_ma.Location = new System.Drawing.Point(162, 75);
            this.textBox_ma.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ma.MaxLength = 4;
            this.textBox_ma.Name = "textBox_ma";
            this.textBox_ma.Size = new System.Drawing.Size(320, 26);
            this.textBox_ma.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ:";
            // 
            // textBox_dc
            // 
            this.textBox_dc.Location = new System.Drawing.Point(162, 121);
            this.textBox_dc.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dc.Name = "textBox_dc";
            this.textBox_dc.Size = new System.Drawing.Size(320, 26);
            this.textBox_dc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địện thoại:";
            // 
            // textBox_dt
            // 
            this.textBox_dt.Location = new System.Drawing.Point(162, 168);
            this.textBox_dt.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dt.Name = "textBox_dt";
            this.textBox_dt.Size = new System.Drawing.Size(320, 26);
            this.textBox_dt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày sinh:";
            // 
            // textBox_ns
            // 
            this.textBox_ns.Location = new System.Drawing.Point(162, 216);
            this.textBox_ns.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ns.Name = "textBox_ns";
            this.textBox_ns.Size = new System.Drawing.Size(225, 26);
            this.textBox_ns.TabIndex = 9;
            // 
            // comboBox_cv
            // 
            this.comboBox_cv.FormattingEnabled = true;
            this.comboBox_cv.Location = new System.Drawing.Point(162, 262);
            this.comboBox_cv.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_cv.Name = "comboBox_cv";
            this.comboBox_cv.Size = new System.Drawing.Size(225, 27);
            this.comboBox_cv.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 266);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Chức vụ:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 216);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 262);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 26);
            this.button2.TabIndex = 13;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_ten
            // 
            this.textBox_ten.Location = new System.Drawing.Point(162, 28);
            this.textBox_ten.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ten.Name = "textBox_ten";
            this.textBox_ten.Size = new System.Drawing.Size(320, 26);
            this.textBox_ten.TabIndex = 14;
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "hnZL4ItLdNpfUF6pJmVj0Pzm3kROJpP2OpkHiQki5aIPXy98fHNhfQ== ";
            this.skinEngine1.SkinFile = null;
            // 
            // Form_QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 309);
            this.Controls.Add(this.textBox_ten);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_cv);
            this.Controls.Add(this.textBox_ns);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_dt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_dc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_ten);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_QLNV";
            this.Text = "Quản lí nhân viên";
            this.Load += new System.EventHandler(this.Form_QLNV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_dc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_dt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ns;
        private System.Windows.Forms.ComboBox comboBox_cv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_ten;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}