namespace E_Kütüphane_Sistemi
{
    partial class Form6
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
            this.button2 = new System.Windows.Forms.Button();
            this.lst_kategori_listele = new System.Windows.Forms.ListBox();
            this.btn_geri_don5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(271, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(388, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kategori Listesi";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lst_kategori_listele
            // 
            this.lst_kategori_listele.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_kategori_listele.FormattingEnabled = true;
            this.lst_kategori_listele.ItemHeight = 19;
            this.lst_kategori_listele.Location = new System.Drawing.Point(271, 77);
            this.lst_kategori_listele.Name = "lst_kategori_listele";
            this.lst_kategori_listele.Size = new System.Drawing.Size(388, 327);
            this.lst_kategori_listele.TabIndex = 2;
            // 
            // btn_geri_don5
            // 
            this.btn_geri_don5.BackColor = System.Drawing.Color.Black;
            this.btn_geri_don5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri_don5.ForeColor = System.Drawing.Color.White;
            this.btn_geri_don5.Location = new System.Drawing.Point(12, 12);
            this.btn_geri_don5.Name = "btn_geri_don5";
            this.btn_geri_don5.Size = new System.Drawing.Size(126, 33);
            this.btn_geri_don5.TabIndex = 3;
            this.btn_geri_don5.Text = "GERİ DÖN";
            this.btn_geri_don5.UseVisualStyleBackColor = false;
            this.btn_geri_don5.Click += new System.EventHandler(this.btn_geri_don5_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(954, 523);
            this.Controls.Add(this.btn_geri_don5);
            this.Controls.Add(this.lst_kategori_listele);
            this.Controls.Add(this.button2);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lst_kategori_listele;
        private System.Windows.Forms.Button btn_geri_don5;
    }
}