namespace Tracnghiem_Application
{
    partial class Form_QLMT
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
            this.comboBox_tenmon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_mamon = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_themmon = new System.Windows.Forms.TextBox();
            this.textBox_themma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_soch = new System.Windows.Forms.TextBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên môn thi:";
            // 
            // comboBox_tenmon
            // 
            this.comboBox_tenmon.FormattingEnabled = true;
            this.comboBox_tenmon.Location = new System.Drawing.Point(140, 12);
            this.comboBox_tenmon.Name = "comboBox_tenmon";
            this.comboBox_tenmon.Size = new System.Drawing.Size(188, 30);
            this.comboBox_tenmon.TabIndex = 1;
            this.comboBox_tenmon.SelectedIndexChanged += new System.EventHandler(this.comboBox_tenmon_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã môn thi:";
            // 
            // textBox_mamon
            // 
            this.textBox_mamon.Location = new System.Drawing.Point(513, 15);
            this.textBox_mamon.Name = "textBox_mamon";
            this.textBox_mamon.Size = new System.Drawing.Size(112, 30);
            this.textBox_mamon.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thêm môn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xóa môn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập vào tên môn thi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhập vào mã môn thi:";
            // 
            // textBox_themmon
            // 
            this.textBox_themmon.Location = new System.Drawing.Point(221, 144);
            this.textBox_themmon.Name = "textBox_themmon";
            this.textBox_themmon.Size = new System.Drawing.Size(337, 30);
            this.textBox_themmon.TabIndex = 8;
            // 
            // textBox_themma
            // 
            this.textBox_themma.Location = new System.Drawing.Point(205, 208);
            this.textBox_themma.MaxLength = 4;
            this.textBox_themma.Name = "textBox_themma";
            this.textBox_themma.Size = new System.Drawing.Size(112, 30);
            this.textBox_themma.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã môn thi tối đa 4 ký tự";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số câu hỏi  trong ngân hàng câu hỏi:";
            // 
            // textBox_soch
            // 
            this.textBox_soch.Location = new System.Drawing.Point(324, 48);
            this.textBox_soch.Name = "textBox_soch";
            this.textBox_soch.Size = new System.Drawing.Size(49, 30);
            this.textBox_soch.TabIndex = 12;
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "hnZL4ItLdNpfUF6pJmVj0Pzm3kROJpP2OpkHiQki5aIPXy98fHNhfQ==";
            this.skinEngine1.SkinFile = null;
            // 
            // Form_QLMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(703, 295);
            this.Controls.Add(this.textBox_soch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_themma);
            this.Controls.Add(this.textBox_themmon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_mamon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_tenmon);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_QLMT";
            this.Text = "Quản lý môn thi";
            this.Load += new System.EventHandler(this.Form_QLMT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_tenmon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_mamon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_themmon;
        private System.Windows.Forms.TextBox textBox_themma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_soch;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}