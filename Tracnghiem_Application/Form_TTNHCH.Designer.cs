namespace Tracnghiem_Application
{
    partial class Form_TTNHCH
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
            this.comboBox_mon = new System.Windows.Forms.ComboBox();
            this.comboBox_nguoitao = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox_cauhoi = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên môn thi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên người tạo:";
            // 
            // comboBox_mon
            // 
            this.comboBox_mon.FormattingEnabled = true;
            this.comboBox_mon.Location = new System.Drawing.Point(112, 18);
            this.comboBox_mon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_mon.Name = "comboBox_mon";
            this.comboBox_mon.Size = new System.Drawing.Size(133, 24);
            this.comboBox_mon.TabIndex = 2;
            this.comboBox_mon.SelectedIndexChanged += new System.EventHandler(this.comboBox_mon_SelectedIndexChanged);
            // 
            // comboBox_nguoitao
            // 
            this.comboBox_nguoitao.FormattingEnabled = true;
            this.comboBox_nguoitao.Location = new System.Drawing.Point(364, 18);
            this.comboBox_nguoitao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_nguoitao.Name = "comboBox_nguoitao";
            this.comboBox_nguoitao.Size = new System.Drawing.Size(157, 24);
            this.comboBox_nguoitao.TabIndex = 3;
            this.comboBox_nguoitao.SelectedIndexChanged += new System.EventHandler(this.comboBox_nguoitao_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(503, 204);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nội dung câu hỏi:";
            // 
            // richTextBox_cauhoi
            // 
            this.richTextBox_cauhoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_cauhoi.Location = new System.Drawing.Point(20, 304);
            this.richTextBox_cauhoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox_cauhoi.Name = "richTextBox_cauhoi";
            this.richTextBox_cauhoi.Size = new System.Drawing.Size(501, 36);
            this.richTextBox_cauhoi.TabIndex = 6;
            this.richTextBox_cauhoi.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 345);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Các câu trả lời:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 366);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(225, 36);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(296, 366);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(225, 36);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(20, 410);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(225, 36);
            this.richTextBox3.TabIndex = 10;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(296, 410);
            this.richTextBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(225, 36);
            this.richTextBox4.TabIndex = 11;
            this.richTextBox4.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 459);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Câu trả lời đúng:";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(137, 455);
            this.richTextBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(384, 24);
            this.richTextBox5.TabIndex = 13;
            this.richTextBox5.Text = "";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "hnZL4ItLdNpfUF6pJmVj0Pzm3kROJpP2OpkHiQki5aIPXy98fHNhfQ==";
            this.skinEngine1.SkinFile = null;
            // 
            // Form_TTNHCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(540, 500);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox_cauhoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_nguoitao);
            this.Controls.Add(this.comboBox_mon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_TTNHCH";
            this.Text = "Thông tin ngân hàng câu hỏi";
            this.Load += new System.EventHandler(this.Form_TTNHCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_mon;
        private System.Windows.Forms.ComboBox comboBox_nguoitao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox_cauhoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}