namespace Tracnghiem_Application
{
    partial class Form_CapMK
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
            this.textBox_ma = new System.Windows.Forms.TextBox();
            this.textBox_tendn = new System.Windows.Forms.TextBox();
            this.textBox_mk = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên đăng nhập:";
            // 
            // textBox_ma
            // 
            this.textBox_ma.Location = new System.Drawing.Point(167, 28);
            this.textBox_ma.MaxLength = 4;
            this.textBox_ma.Name = "textBox_ma";
            this.textBox_ma.Size = new System.Drawing.Size(201, 30);
            this.textBox_ma.TabIndex = 3;
            // 
            // textBox_tendn
            // 
            this.textBox_tendn.Location = new System.Drawing.Point(167, 74);
            this.textBox_tendn.Name = "textBox_tendn";
            this.textBox_tendn.Size = new System.Drawing.Size(201, 30);
            this.textBox_tendn.TabIndex = 4;
            // 
            // textBox_mk
            // 
            this.textBox_mk.Location = new System.Drawing.Point(167, 124);
            this.textBox_mk.Name = "textBox_mk";
            this.textBox_mk.Size = new System.Drawing.Size(201, 30);
            this.textBox_mk.TabIndex = 5;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(133, 196);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(82, 25);
            this.button_ok.TabIndex = 6;
            this.button_ok.Text = "Xác nhận";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "hnZL4ItLdNpfUF6pJmVj0Pzm3kROJpP2OpkHiQki5aIPXy98fHNhfQ==";
            this.skinEngine1.SkinFile = null;
            // 
            // Form_CapMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(533, 255);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBox_mk);
            this.Controls.Add(this.textBox_tendn);
            this.Controls.Add(this.textBox_ma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_CapMK";
            this.Text = "Cấp mật khẩu";
            this.Load += new System.EventHandler(this.Form_CapMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ma;
        private System.Windows.Forms.TextBox textBox_tendn;
        private System.Windows.Forms.TextBox textBox_mk;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}