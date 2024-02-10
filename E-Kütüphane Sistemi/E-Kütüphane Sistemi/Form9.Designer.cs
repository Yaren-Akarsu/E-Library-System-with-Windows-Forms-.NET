namespace E_Kütüphane_Sistemi
{
    partial class Form9
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_geri_don8 = new System.Windows.Forms.Button();
            this.btn_kaydet3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lst_emanetler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kitap_adii = new System.Windows.Forms.TextBox();
            this.txt_emanet_alinan_tarih = new System.Windows.Forms.TextBox();
            this.txt_teslim_tarihi = new System.Windows.Forms.TextBox();
            this.txt_kisi_bilgisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(206, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "EMANET İŞLEMLERİ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_geri_don8
            // 
            this.btn_geri_don8.BackColor = System.Drawing.Color.Black;
            this.btn_geri_don8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri_don8.ForeColor = System.Drawing.Color.White;
            this.btn_geri_don8.Location = new System.Drawing.Point(12, 12);
            this.btn_geri_don8.Name = "btn_geri_don8";
            this.btn_geri_don8.Size = new System.Drawing.Size(127, 33);
            this.btn_geri_don8.TabIndex = 1;
            this.btn_geri_don8.Text = "GERİ DÖN";
            this.btn_geri_don8.UseVisualStyleBackColor = false;
            this.btn_geri_don8.Click += new System.EventHandler(this.btn_geri_don8_Click);
            // 
            // btn_kaydet3
            // 
            this.btn_kaydet3.BackColor = System.Drawing.Color.Peru;
            this.btn_kaydet3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet3.Location = new System.Drawing.Point(232, 450);
            this.btn_kaydet3.Name = "btn_kaydet3";
            this.btn_kaydet3.Size = new System.Drawing.Size(116, 49);
            this.btn_kaydet3.TabIndex = 2;
            this.btn_kaydet3.Text = "KAYDET";
            this.btn_kaydet3.UseVisualStyleBackColor = false;
            this.btn_kaydet3.Click += new System.EventHandler(this.btn_kaydet3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(628, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(712, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "EMANET LİSTESİ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // lst_emanetler
            // 
            this.lst_emanetler.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_emanetler.FormattingEnabled = true;
            this.lst_emanetler.ItemHeight = 17;
            this.lst_emanetler.Items.AddRange(new object[] {
            " KİTAP ADI                              EMANET ALINAN TARİH      TESLİM TARİHİ   " +
                "     KİŞİ BİLGİSİ",
            " Veda Caddesi                                   03.08.2023                       " +
                "   22.08.2023                       Melike Bora",
            " Warcross                                           23.09.2023                   " +
                "      30.09.2023                      Yaren Akarsu",
            " Genç Elitler                                       16.12.2023                   " +
                "      20.12.2023                      Selen Akarsu",
            " İnsan Ne İle Yaşar?                            25.07.2023                       " +
                " 01.08.2023                       Tuğçe Yaşar",
            " Paris ve Londra\'da Beş Parasız        12.05.2023                         15.05.2" +
                "023                   Süleyman Demir",
            " Suç ve Ceza                                      29.10.2023                     " +
                "   08.11.2023                     Batuhan Sevin",
            " Yalancılar ve Yabancılar                  09.05.2023                        15.0" +
                "5.2023                   Egemen Akbaba",
            " Karantina                                        09.12.2023                     " +
                "    14.12.2023                   Gizem Nur Çetin",
            " Sokak Nöbetçileri                          06.02.2023                          2" +
                "2.02.2023                      Burak İşler",
            " Aşk ve Gurur                                  14.07.2023                        " +
                "  24.07.2023                      Enes Arslan"});
            this.lst_emanetler.Location = new System.Drawing.Point(628, 146);
            this.lst_emanetler.Name = "lst_emanetler";
            this.lst_emanetler.Size = new System.Drawing.Size(712, 344);
            this.lst_emanetler.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "KİTAP ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "EMANET ALINAN TARİH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "TESLİM TARİHİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(79, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "KİŞİ BİLGİSİ";
            // 
            // txt_kitap_adii
            // 
            this.txt_kitap_adii.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitap_adii.Location = new System.Drawing.Point(331, 148);
            this.txt_kitap_adii.Name = "txt_kitap_adii";
            this.txt_kitap_adii.Size = new System.Drawing.Size(201, 27);
            this.txt_kitap_adii.TabIndex = 9;
            // 
            // txt_emanet_alinan_tarih
            // 
            this.txt_emanet_alinan_tarih.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_emanet_alinan_tarih.Location = new System.Drawing.Point(331, 205);
            this.txt_emanet_alinan_tarih.Name = "txt_emanet_alinan_tarih";
            this.txt_emanet_alinan_tarih.Size = new System.Drawing.Size(201, 27);
            this.txt_emanet_alinan_tarih.TabIndex = 10;
            // 
            // txt_teslim_tarihi
            // 
            this.txt_teslim_tarihi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_teslim_tarihi.Location = new System.Drawing.Point(331, 286);
            this.txt_teslim_tarihi.Name = "txt_teslim_tarihi";
            this.txt_teslim_tarihi.Size = new System.Drawing.Size(201, 27);
            this.txt_teslim_tarihi.TabIndex = 11;
            // 
            // txt_kisi_bilgisi
            // 
            this.txt_kisi_bilgisi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kisi_bilgisi.Location = new System.Drawing.Point(331, 359);
            this.txt_kisi_bilgisi.Name = "txt_kisi_bilgisi";
            this.txt_kisi_bilgisi.Size = new System.Drawing.Size(207, 27);
            this.txt_kisi_bilgisi.TabIndex = 12;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1357, 519);
            this.Controls.Add(this.txt_kisi_bilgisi);
            this.Controls.Add(this.txt_teslim_tarihi);
            this.Controls.Add(this.txt_emanet_alinan_tarih);
            this.Controls.Add(this.txt_kitap_adii);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_emanetler);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_kaydet3);
            this.Controls.Add(this.btn_geri_don8);
            this.Controls.Add(this.button1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_geri_don8;
        private System.Windows.Forms.Button btn_kaydet3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lst_emanetler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kitap_adii;
        private System.Windows.Forms.TextBox txt_emanet_alinan_tarih;
        private System.Windows.Forms.TextBox txt_teslim_tarihi;
        private System.Windows.Forms.TextBox txt_kisi_bilgisi;
    }
}