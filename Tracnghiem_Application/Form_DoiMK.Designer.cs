namespace Tracnghiem_Application
{
    partial class Form_DoiMK
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_ten = new System.Windows.Forms.Label();
            this.label_tendn = new System.Windows.Forms.Label();
            this.textBox_mkcu = new System.Windows.Forms.TextBox();
            this.textBox_mkmoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu hiện tại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // label_ten
            // 
            this.label_ten.AutoSize = true;
            this.label_ten.Location = new System.Drawing.Point(165, 23);
            this.label_ten.Name = "label_ten";
            this.label_ten.Size = new System.Drawing.Size(0, 19);
            this.label_ten.TabIndex = 4;
            // 
            // label_tendn
            // 
            this.label_tendn.AutoSize = true;
            this.label_tendn.Location = new System.Drawing.Point(165, 60);
            this.label_tendn.Name = "label_tendn";
            this.label_tendn.Size = new System.Drawing.Size(0, 19);
            this.label_tendn.TabIndex = 5;
            // 
            // textBox_mkcu
            // 
            this.textBox_mkcu.Location = new System.Drawing.Point(169, 98);
            this.textBox_mkcu.Name = "textBox_mkcu";
            this.textBox_mkcu.PasswordChar = '*';
            this.textBox_mkcu.Size = new System.Drawing.Size(199, 26);
            this.textBox_mkcu.TabIndex = 6;
            // 
            // textBox_mkmoi
            // 
            this.textBox_mkmoi.Location = new System.Drawing.Point(169, 136);
            this.textBox_mkmoi.Name = "textBox_mkmoi";
            this.textBox_mkmoi.PasswordChar = '*';
            this.textBox_mkmoi.Size = new System.Drawing.Size(199, 26);
            this.textBox_mkmoi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(169, 172);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 30);
            this.button_ok.TabIndex = 9;
            this.button_ok.Text = "Xác nhận";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "hnZL4ItLdNpfUF6pJmVj0Pzm3kROJpP2OpkHiQki5aIPXy98fHNhfQ==";
            this.skinEngine1.SkinFile = null;
            // 
            // Form_DoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 214);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_mkmoi);
            this.Controls.Add(this.textBox_mkcu);
            this.Controls.Add(this.label_tendn);
            this.Controls.Add(this.label_ten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_DoiMK";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.Form_DoiMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_ten;
        private System.Windows.Forms.Label label_tendn;
        private System.Windows.Forms.TextBox textBox_mkcu;
        private System.Windows.Forms.TextBox textBox_mkmoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_ok;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}