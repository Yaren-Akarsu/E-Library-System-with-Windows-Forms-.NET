namespace E_Kütüphane_Sistemi
{
    partial class Form3
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
            this.lst_kitap_listele = new System.Windows.Forms.ListBox();
            this.btn_geri_don1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(161, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(735, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "KİTAP LİSTESİ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lst_kitap_listele
            // 
            this.lst_kitap_listele.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_kitap_listele.FormattingEnabled = true;
            this.lst_kitap_listele.ItemHeight = 19;
            this.lst_kitap_listele.Location = new System.Drawing.Point(161, 60);
            this.lst_kitap_listele.Name = "lst_kitap_listele";
            this.lst_kitap_listele.Size = new System.Drawing.Size(735, 365);
            this.lst_kitap_listele.TabIndex = 1;
            // 
            // btn_geri_don1
            // 
            this.btn_geri_don1.BackColor = System.Drawing.Color.Black;
            this.btn_geri_don1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri_don1.ForeColor = System.Drawing.Color.White;
            this.btn_geri_don1.Location = new System.Drawing.Point(12, 12);
            this.btn_geri_don1.Name = "btn_geri_don1";
            this.btn_geri_don1.Size = new System.Drawing.Size(120, 29);
            this.btn_geri_don1.TabIndex = 2;
            this.btn_geri_don1.Text = "GERİ DÖN";
            this.btn_geri_don1.UseVisualStyleBackColor = false;
            this.btn_geri_don1.Click += new System.EventHandler(this.btn_geri_don1_Click);
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1040, 484);
            this.Controls.Add(this.btn_geri_don1);
            this.Controls.Add(this.lst_kitap_listele);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lst_kitap_listele;
        private System.Windows.Forms.Button btn_geri_don1;
    }
}