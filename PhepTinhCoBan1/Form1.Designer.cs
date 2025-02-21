namespace PhepTinhCoBan1
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TrackBar();
            this.tb2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtso3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textsomu = new System.Windows.Forms.TextBox();
            this.txtsomu = new System.Windows.Forms.Label();
            this.textketqua = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.Label();
            this.btnBang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Phép Tính Cơ Bản";
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(184, 111);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(100, 20);
            this.txtso1.TabIndex = 1;
            this.txtso1.TextChanged += new System.EventHandler(this.txtso1_TextChanged);
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(184, 152);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(100, 20);
            this.txtso2.TabIndex = 1;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(184, 195);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 20);
            this.txtkq.TabIndex = 1;
            this.txtkq.TextChanged += new System.EventHandler(this.txtkq_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "só 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "só 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(116, 283);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(75, 23);
            this.btnCong.TabIndex = 3;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(229, 283);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(75, 23);
            this.btnTru.TabIndex = 3;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(346, 283);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(75, 23);
            this.btnNhan.TabIndex = 3;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(457, 283);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(75, 23);
            this.btnChia.TabIndex = 3;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // tb1
            // 
            this.tb1.LargeChange = 2;
            this.tb1.Location = new System.Drawing.Point(307, 102);
            this.tb1.Maximum = 1000;
            this.tb1.Minimum = -100;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(263, 45);
            this.tb1.TabIndex = 4;
            this.tb1.Scroll += new System.EventHandler(this.tb1_Scroll);
            // 
            // tb2
            // 
            this.tb2.LargeChange = 2;
            this.tb2.Location = new System.Drawing.Point(307, 170);
            this.tb2.Maximum = 1000;
            this.tb2.Minimum = -100;
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(263, 45);
            this.tb2.TabIndex = 4;
            this.tb2.Scroll += new System.EventHandler(this.tb1_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 2;
            this.trackBar1.Location = new System.Drawing.Point(307, 170);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = -100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(263, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.tb1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "số 3";
            // 
            // txtso3
            // 
            this.txtso3.Location = new System.Drawing.Point(628, 111);
            this.txtso3.Name = "txtso3";
            this.txtso3.Size = new System.Drawing.Size(100, 20);
            this.txtso3.TabIndex = 1;
            this.txtso3.TextChanged += new System.EventHandler(this.txtso1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1072, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "số mũ";
            // 
            // textsomu
            // 
            this.textsomu.Location = new System.Drawing.Point(628, 155);
            this.textsomu.Name = "textsomu";
            this.textsomu.Size = new System.Drawing.Size(100, 20);
            this.textsomu.TabIndex = 1;
            this.textsomu.TextChanged += new System.EventHandler(this.txtso1_TextChanged);
            // 
            // txtsomu
            // 
            this.txtsomu.AutoSize = true;
            this.txtsomu.Location = new System.Drawing.Point(576, 158);
            this.txtsomu.Name = "txtsomu";
            this.txtsomu.Size = new System.Drawing.Size(35, 13);
            this.txtsomu.TabIndex = 7;
            this.txtsomu.Text = "số mũ";
            // 
            // textketqua
            // 
            this.textketqua.Location = new System.Drawing.Point(628, 195);
            this.textketqua.Name = "textketqua";
            this.textketqua.Size = new System.Drawing.Size(100, 20);
            this.textketqua.TabIndex = 1;
            this.textketqua.TextChanged += new System.EventHandler(this.txtso1_TextChanged);
            // 
            // txtketqua
            // 
            this.txtketqua.AutoSize = true;
            this.txtketqua.Location = new System.Drawing.Point(576, 195);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(20, 13);
            this.txtketqua.TabIndex = 7;
            this.txtketqua.Text = "Kq";
            // 
            // btnBang
            // 
            this.btnBang.Location = new System.Drawing.Point(734, 170);
            this.btnBang.Name = "btnBang";
            this.btnBang.Size = new System.Drawing.Size(75, 23);
            this.btnBang.TabIndex = 8;
            this.btnBang.Text = "=";
            this.btnBang.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBang.UseVisualStyleBackColor = true;
            this.btnBang.Click += new System.EventHandler(this.btnBang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 379);
            this.Controls.Add(this.btnBang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtsomu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textketqua);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.textsomu);
            this.Controls.Add(this.txtso3);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.TrackBar tb1;
        private System.Windows.Forms.TrackBar tb2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtso3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textsomu;
        private System.Windows.Forms.Label txtsomu;
        private System.Windows.Forms.TextBox textketqua;
        private System.Windows.Forms.Label txtketqua;
        private System.Windows.Forms.Button btnBang;
    }
}

