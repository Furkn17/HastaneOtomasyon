﻿namespace Proje_hastane
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.CmbCİnsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnKayitYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ad :";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(218, 33);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(171, 36);
            this.TxtAd.TabIndex = 1;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(218, 145);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(171, 36);
            this.MskTC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "TC Kimlik No :";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(218, 250);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(171, 36);
            this.TxtSifre.TabIndex = 5;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(218, 89);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(171, 36);
            this.TxtSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telefon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Şifre :";
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(218, 197);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(171, 36);
            this.MskTelefon.TabIndex = 4;
            // 
            // CmbCİnsiyet
            // 
            this.CmbCİnsiyet.FormattingEnabled = true;
            this.CmbCİnsiyet.Items.AddRange(new object[] {
            "Erkek ",
            "Kadın"});
            this.CmbCİnsiyet.Location = new System.Drawing.Point(218, 303);
            this.CmbCİnsiyet.Name = "CmbCİnsiyet";
            this.CmbCİnsiyet.Size = new System.Drawing.Size(171, 36);
            this.CmbCİnsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cinsiyet :";
            // 
            // BtnKayitYap
            // 
            this.BtnKayitYap.BackColor = System.Drawing.Color.SpringGreen;
            this.BtnKayitYap.Location = new System.Drawing.Point(218, 369);
            this.BtnKayitYap.Name = "BtnKayitYap";
            this.BtnKayitYap.Size = new System.Drawing.Size(171, 42);
            this.BtnKayitYap.TabIndex = 21;
            this.BtnKayitYap.Text = "Kayıt Yap";
            this.BtnKayitYap.UseVisualStyleBackColor = false;
            this.BtnKayitYap.Click += new System.EventHandler(this.BtnKayitYap_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.BtnKayitYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(552, 444);
            this.Controls.Add(this.BtnKayitYap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbCİnsiyet);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.ComboBox CmbCİnsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnKayitYap;
    }
}