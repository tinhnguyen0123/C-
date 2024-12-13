namespace Tracnghiem_Application
{
    partial class Form_TTDSTS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_ma = new System.Windows.Forms.ComboBox();
            this.comboBox_ten = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_dc = new System.Windows.Forms.Label();
            this.label_ns = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 133);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(564, 155);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox_ma
            // 
            this.comboBox_ma.FormattingEnabled = true;
            this.comboBox_ma.Location = new System.Drawing.Point(113, 12);
            this.comboBox_ma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_ma.Name = "comboBox_ma";
            this.comboBox_ma.Size = new System.Drawing.Size(171, 24);
            this.comboBox_ma.TabIndex = 1;
            this.comboBox_ma.SelectedIndexChanged += new System.EventHandler(this.comboBox_ma_SelectedIndexChanged);
            // 
            // comboBox_ten
            // 
            this.comboBox_ten.FormattingEnabled = true;
            this.comboBox_ten.Location = new System.Drawing.Point(417, 12);
            this.comboBox_ten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_ten.Name = "comboBox_ten";
            this.comboBox_ten.Size = new System.Drawing.Size(171, 24);
            this.comboBox_ten.TabIndex = 2;
            this.comboBox_ten.SelectedIndexChanged += new System.EventHandler(this.comboBox_ten_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã thí sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên thí sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày sinh:";
            // 
            // label_dc
            // 
            this.label_dc.BackColor = System.Drawing.Color.White;
            this.label_dc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_dc.Location = new System.Drawing.Point(113, 44);
            this.label_dc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dc.Name = "label_dc";
            this.label_dc.Size = new System.Drawing.Size(172, 26);
            this.label_dc.TabIndex = 11;
            // 
            // label_ns
            // 
            this.label_ns.BackColor = System.Drawing.Color.White;
            this.label_ns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_ns.Location = new System.Drawing.Point(113, 76);
            this.label_ns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ns.Name = "label_ns";
            this.label_ns.Size = new System.Drawing.Size(172, 26);
            this.label_ns.TabIndex = 12;
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // Form_TTDSTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(611, 305);
            this.Controls.Add(this.label_ns);
            this.Controls.Add(this.label_dc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_ten);
            this.Controls.Add(this.comboBox_ma);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_TTDSTS";
            this.Text = "Thông tin danh sách thí sinh";
            this.Load += new System.EventHandler(this.Form_TTDSTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_ma;
        private System.Windows.Forms.ComboBox comboBox_ten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_dc;
        private System.Windows.Forms.Label label_ns;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}