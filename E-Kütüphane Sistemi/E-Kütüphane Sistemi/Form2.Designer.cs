namespace E_Kütüphane_Sistemi
{
    partial class Form2
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
            this.lst_uye_listele = new System.Windows.Forms.ListBox();
            this.btn_geri_don2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(276, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(422, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "ÜYE LİSTESİ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lst_uye_listele
            // 
            this.lst_uye_listele.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_uye_listele.FormattingEnabled = true;
            this.lst_uye_listele.ItemHeight = 19;
            this.lst_uye_listele.Location = new System.Drawing.Point(276, 70);
            this.lst_uye_listele.Margin = new System.Windows.Forms.Padding(4);
            this.lst_uye_listele.Name = "lst_uye_listele";
            this.lst_uye_listele.Size = new System.Drawing.Size(422, 327);
            this.lst_uye_listele.TabIndex = 1;
            // 
            // btn_geri_don2
            // 
            this.btn_geri_don2.BackColor = System.Drawing.Color.Black;
            this.btn_geri_don2.ForeColor = System.Drawing.Color.White;
            this.btn_geri_don2.Location = new System.Drawing.Point(13, 13);
            this.btn_geri_don2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_geri_don2.Name = "btn_geri_don2";
            this.btn_geri_don2.Size = new System.Drawing.Size(112, 27);
            this.btn_geri_don2.TabIndex = 2;
            this.btn_geri_don2.Text = "GERİ DÖN";
            this.btn_geri_don2.UseVisualStyleBackColor = false;
            this.btn_geri_don2.Click += new System.EventHandler(this.btn_geri_don2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1000, 534);
            this.Controls.Add(this.btn_geri_don2);
            this.Controls.Add(this.lst_uye_listele);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lst_uye_listele;
        private System.Windows.Forms.Button btn_geri_don2;
    }
}