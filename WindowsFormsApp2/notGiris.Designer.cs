﻿
namespace WindowsFormsApp2
{
    partial class notGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notGiris));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.sorgulananİsim = new System.Windows.Forms.Label();
            this.sorgulananSoyisim = new System.Windows.Forms.Label();
            this.sorgulananOgrenciNo = new System.Windows.Forms.TextBox();
            this.sonuç1 = new System.Windows.Forms.Label();
            this.vize1 = new System.Windows.Forms.Label();
            this.ortalama1 = new System.Windows.Forms.Label();
            this.final1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(47, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Öğrenci No";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(493, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sonuç:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(474, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ortalama:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(459, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Final Notu:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(470, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Vize Notu:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button7.Location = new System.Drawing.Point(855, 412);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 38);
            this.button7.TabIndex = 26;
            this.button7.Text = "GERİ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(9, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 31);
            this.label7.TabIndex = 29;
            this.label7.Text = "Öğrenci Soyad:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(36, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 31);
            this.label8.TabIndex = 30;
            this.label8.Text = "Öğrenci Ad:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button2.Location = new System.Drawing.Point(729, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 38);
            this.button2.TabIndex = 35;
            this.button2.Text = "KAYDET";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button3.Location = new System.Drawing.Point(197, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 38);
            this.button3.TabIndex = 36;
            this.button3.Text = "ARA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(318, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(319, 31);
            this.label9.TabIndex = 41;
            this.label9.Text = "ÖĞRENCİ NOT DÜZENLEME";
            // 
            // sorgulananİsim
            // 
            this.sorgulananİsim.AutoSize = true;
            this.sorgulananİsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sorgulananİsim.Location = new System.Drawing.Point(154, 311);
            this.sorgulananİsim.Name = "sorgulananİsim";
            this.sorgulananİsim.Size = new System.Drawing.Size(68, 22);
            this.sorgulananİsim.TabIndex = 43;
            this.sorgulananİsim.Text = "label11";
            // 
            // sorgulananSoyisim
            // 
            this.sorgulananSoyisim.AutoSize = true;
            this.sorgulananSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sorgulananSoyisim.Location = new System.Drawing.Point(154, 360);
            this.sorgulananSoyisim.Name = "sorgulananSoyisim";
            this.sorgulananSoyisim.Size = new System.Drawing.Size(68, 22);
            this.sorgulananSoyisim.TabIndex = 44;
            this.sorgulananSoyisim.Text = "label12";
            // 
            // sorgulananOgrenciNo
            // 
            this.sorgulananOgrenciNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorgulananOgrenciNo.Location = new System.Drawing.Point(171, 123);
            this.sorgulananOgrenciNo.Multiline = true;
            this.sorgulananOgrenciNo.Name = "sorgulananOgrenciNo";
            this.sorgulananOgrenciNo.Size = new System.Drawing.Size(152, 23);
            this.sorgulananOgrenciNo.TabIndex = 45;
            this.sorgulananOgrenciNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sonuç1
            // 
            this.sonuç1.AutoSize = true;
            this.sonuç1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sonuç1.Location = new System.Drawing.Point(591, 329);
            this.sonuç1.Name = "sonuç1";
            this.sonuç1.Size = new System.Drawing.Size(68, 22);
            this.sonuç1.TabIndex = 46;
            this.sonuç1.Text = "label11";
            // 
            // vize1
            // 
            this.vize1.AutoSize = true;
            this.vize1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.vize1.Location = new System.Drawing.Point(591, 178);
            this.vize1.Name = "vize1";
            this.vize1.Size = new System.Drawing.Size(68, 22);
            this.vize1.TabIndex = 46;
            this.vize1.Text = "label11";
            // 
            // ortalama1
            // 
            this.ortalama1.AutoSize = true;
            this.ortalama1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ortalama1.Location = new System.Drawing.Point(591, 277);
            this.ortalama1.Name = "ortalama1";
            this.ortalama1.Size = new System.Drawing.Size(68, 22);
            this.ortalama1.TabIndex = 47;
            this.ortalama1.Text = "label11";
            // 
            // final1
            // 
            this.final1.AutoSize = true;
            this.final1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.final1.Location = new System.Drawing.Point(591, 228);
            this.final1.Name = "final1";
            this.final1.Size = new System.Drawing.Size(68, 22);
            this.final1.TabIndex = 48;
            this.final1.Text = "label11";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(611, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ders Seçiniz";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.Location = new System.Drawing.Point(463, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button4.Location = new System.Drawing.Point(463, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 50;
            this.button4.Text = "GERİ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button5.Location = new System.Drawing.Point(775, 93);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 23);
            this.button5.TabIndex = 51;
            this.button5.Text = "GERİ";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button6.Location = new System.Drawing.Point(671, 93);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 23);
            this.button6.TabIndex = 52;
            this.button6.Text = "V";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button8.Location = new System.Drawing.Point(567, 93);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 23);
            this.button8.TabIndex = 53;
            this.button8.Text = "GERİ";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // notGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 462);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.final1);
            this.Controls.Add(this.ortalama1);
            this.Controls.Add(this.vize1);
            this.Controls.Add(this.sonuç1);
            this.Controls.Add(this.sorgulananOgrenciNo);
            this.Controls.Add(this.sorgulananSoyisim);
            this.Controls.Add(this.sorgulananİsim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "notGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Düzenleme";
            this.Load += new System.EventHandler(this.not_bil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label sorgulananİsim;
        private System.Windows.Forms.Label sorgulananSoyisim;
        private System.Windows.Forms.TextBox sorgulananOgrenciNo;
        private System.Windows.Forms.Label sonuç1;
        private System.Windows.Forms.Label vize1;
        private System.Windows.Forms.Label ortalama1;
        private System.Windows.Forms.Label final1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
    }
}