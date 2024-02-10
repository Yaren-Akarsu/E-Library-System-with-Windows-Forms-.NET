namespace E_Kütüphane_Sistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kitap_liste = new System.Windows.Forms.Button();
            this.btn_uye_liste = new System.Windows.Forms.Button();
            this.btn_emanet_liste = new System.Windows.Forms.Button();
            this.btn_kutuphane_liste = new System.Windows.Forms.Button();
            this.btn_kategori_liste = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_kitap_ekle = new System.Windows.Forms.Button();
            this.btn_uye_ekle = new System.Windows.Forms.Button();
            this.btn_emanet_islemleri = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(226, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-KÜTÜPHANE SİSTEMİNE HOŞGELDİNİZ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_kitap_liste
            // 
            this.btn_kitap_liste.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_kitap_liste.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitap_liste.Location = new System.Drawing.Point(25, 144);
            this.btn_kitap_liste.Name = "btn_kitap_liste";
            this.btn_kitap_liste.Size = new System.Drawing.Size(183, 45);
            this.btn_kitap_liste.TabIndex = 1;
            this.btn_kitap_liste.Text = "Kitapları Listele";
            this.btn_kitap_liste.UseVisualStyleBackColor = false;
            this.btn_kitap_liste.Click += new System.EventHandler(this.btn_kitap_liste_Click);
            // 
            // btn_uye_liste
            // 
            this.btn_uye_liste.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_uye_liste.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uye_liste.Location = new System.Drawing.Point(25, 195);
            this.btn_uye_liste.Name = "btn_uye_liste";
            this.btn_uye_liste.Size = new System.Drawing.Size(183, 45);
            this.btn_uye_liste.TabIndex = 2;
            this.btn_uye_liste.Text = "Üyeleri Listele";
            this.btn_uye_liste.UseVisualStyleBackColor = false;
            this.btn_uye_liste.Click += new System.EventHandler(this.btn_uye_liste_Click);
            // 
            // btn_emanet_liste
            // 
            this.btn_emanet_liste.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_emanet_liste.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_emanet_liste.Location = new System.Drawing.Point(25, 246);
            this.btn_emanet_liste.Name = "btn_emanet_liste";
            this.btn_emanet_liste.Size = new System.Drawing.Size(183, 45);
            this.btn_emanet_liste.TabIndex = 3;
            this.btn_emanet_liste.Text = "Emanet Listele";
            this.btn_emanet_liste.UseVisualStyleBackColor = false;
            this.btn_emanet_liste.Click += new System.EventHandler(this.btn_emanet_liste_Click);
            // 
            // btn_kutuphane_liste
            // 
            this.btn_kutuphane_liste.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_kutuphane_liste.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kutuphane_liste.Location = new System.Drawing.Point(25, 297);
            this.btn_kutuphane_liste.Name = "btn_kutuphane_liste";
            this.btn_kutuphane_liste.Size = new System.Drawing.Size(183, 45);
            this.btn_kutuphane_liste.TabIndex = 4;
            this.btn_kutuphane_liste.Text = "Kütüphaneleri Listele";
            this.btn_kutuphane_liste.UseVisualStyleBackColor = false;
            this.btn_kutuphane_liste.Click += new System.EventHandler(this.btn_kutuphane_liste_Click);
            // 
            // btn_kategori_liste
            // 
            this.btn_kategori_liste.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_kategori_liste.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kategori_liste.Location = new System.Drawing.Point(25, 348);
            this.btn_kategori_liste.Name = "btn_kategori_liste";
            this.btn_kategori_liste.Size = new System.Drawing.Size(183, 45);
            this.btn_kategori_liste.TabIndex = 5;
            this.btn_kategori_liste.Text = "Kategorileri Listele";
            this.btn_kategori_liste.UseVisualStyleBackColor = false;
            this.btn_kategori_liste.Click += new System.EventHandler(this.btn_kategori_liste_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.DarkRed;
            this.btn_cikis.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.ForeColor = System.Drawing.Color.White;
            this.btn_cikis.Location = new System.Drawing.Point(58, 413);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(106, 36);
            this.btn_cikis.TabIndex = 6;
            this.btn_cikis.Text = "ÇIKIŞ YAP";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_kitap_ekle
            // 
            this.btn_kitap_ekle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_kitap_ekle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitap_ekle.Location = new System.Drawing.Point(12, 2);
            this.btn_kitap_ekle.Name = "btn_kitap_ekle";
            this.btn_kitap_ekle.Size = new System.Drawing.Size(139, 35);
            this.btn_kitap_ekle.TabIndex = 9;
            this.btn_kitap_ekle.Text = "Kitap Ekle";
            this.btn_kitap_ekle.UseVisualStyleBackColor = false;
            this.btn_kitap_ekle.Click += new System.EventHandler(this.btn_kitap_ekle_Click);
            // 
            // btn_uye_ekle
            // 
            this.btn_uye_ekle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_uye_ekle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uye_ekle.Location = new System.Drawing.Point(157, 2);
            this.btn_uye_ekle.Name = "btn_uye_ekle";
            this.btn_uye_ekle.Size = new System.Drawing.Size(139, 35);
            this.btn_uye_ekle.TabIndex = 10;
            this.btn_uye_ekle.Text = "Üye Ekle";
            this.btn_uye_ekle.UseVisualStyleBackColor = false;
            this.btn_uye_ekle.Click += new System.EventHandler(this.btn_uye_ekle_Click);
            // 
            // btn_emanet_islemleri
            // 
            this.btn_emanet_islemleri.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_emanet_islemleri.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_emanet_islemleri.Location = new System.Drawing.Point(302, 2);
            this.btn_emanet_islemleri.Name = "btn_emanet_islemleri";
            this.btn_emanet_islemleri.Size = new System.Drawing.Size(139, 35);
            this.btn_emanet_islemleri.TabIndex = 11;
            this.btn_emanet_islemleri.Text = "Emanet İşlemleri";
            this.btn_emanet_islemleri.UseVisualStyleBackColor = false;
            this.btn_emanet_islemleri.Click += new System.EventHandler(this.btn_emanet_islemleri_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(257, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(665, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1038, 572);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_emanet_islemleri);
            this.Controls.Add(this.btn_uye_ekle);
            this.Controls.Add(this.btn_kitap_ekle);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_kategori_liste);
            this.Controls.Add(this.btn_kutuphane_liste);
            this.Controls.Add(this.btn_emanet_liste);
            this.Controls.Add(this.btn_uye_liste);
            this.Controls.Add(this.btn_kitap_liste);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kitap_liste;
        private System.Windows.Forms.Button btn_uye_liste;
        private System.Windows.Forms.Button btn_emanet_liste;
        private System.Windows.Forms.Button btn_kutuphane_liste;
        private System.Windows.Forms.Button btn_kategori_liste;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_kitap_ekle;
        private System.Windows.Forms.Button btn_uye_ekle;
        private System.Windows.Forms.Button btn_emanet_islemleri;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

