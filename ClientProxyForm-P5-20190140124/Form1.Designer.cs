
namespace ClientProxyForm_P5_20190140124
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
            this.buttonHasil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelPenjumlahan = new System.Windows.Forms.Label();
            this.labelPengurangan = new System.Windows.Forms.Label();
            this.labelPerkalian = new System.Windows.Forms.Label();
            this.labelPembagian = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonHasil
            // 
            this.buttonHasil.Location = new System.Drawing.Point(260, 214);
            this.buttonHasil.Name = "buttonHasil";
            this.buttonHasil.Size = new System.Drawing.Size(75, 23);
            this.buttonHasil.TabIndex = 0;
            this.buttonHasil.Text = "Hasil";
            this.buttonHasil.UseVisualStyleBackColor = true;
            this.buttonHasil.Click += new System.EventHandler(this.buttonHasil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Angka 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Angka 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(213, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 8;
            // 
            // labelPenjumlahan
            // 
            this.labelPenjumlahan.AutoSize = true;
            this.labelPenjumlahan.Location = new System.Drawing.Point(431, 78);
            this.labelPenjumlahan.Name = "labelPenjumlahan";
            this.labelPenjumlahan.Size = new System.Drawing.Size(100, 13);
            this.labelPenjumlahan.TabIndex = 9;
            this.labelPenjumlahan.Text = "Hasil Penjumlahan :";
            // 
            // labelPengurangan
            // 
            this.labelPengurangan.AutoSize = true;
            this.labelPengurangan.Location = new System.Drawing.Point(431, 107);
            this.labelPengurangan.Name = "labelPengurangan";
            this.labelPengurangan.Size = new System.Drawing.Size(103, 13);
            this.labelPengurangan.TabIndex = 10;
            this.labelPengurangan.Text = "Hasil Pengurangan :";
            this.labelPengurangan.Click += new System.EventHandler(this.label8_Click);
            // 
            // labelPerkalian
            // 
            this.labelPerkalian.AutoSize = true;
            this.labelPerkalian.Location = new System.Drawing.Point(431, 142);
            this.labelPerkalian.Name = "labelPerkalian";
            this.labelPerkalian.Size = new System.Drawing.Size(83, 13);
            this.labelPerkalian.TabIndex = 11;
            this.labelPerkalian.Text = "Hasil Perkalian :";
            // 
            // labelPembagian
            // 
            this.labelPembagian.AutoSize = true;
            this.labelPembagian.Location = new System.Drawing.Point(431, 177);
            this.labelPembagian.Name = "labelPembagian";
            this.labelPembagian.Size = new System.Drawing.Size(92, 13);
            this.labelPembagian.TabIndex = 12;
            this.labelPembagian.Text = "Hasil Pembagian :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 331);
            this.Controls.Add(this.labelPembagian);
            this.Controls.Add(this.labelPerkalian);
            this.Controls.Add(this.labelPengurangan);
            this.Controls.Add(this.labelPenjumlahan);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHasil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHasil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelPenjumlahan;
        private System.Windows.Forms.Label labelPengurangan;
        private System.Windows.Forms.Label labelPerkalian;
        private System.Windows.Forms.Label labelPembagian;
    }
}

