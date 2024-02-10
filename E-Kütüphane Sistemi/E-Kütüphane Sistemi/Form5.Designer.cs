namespace E_Kütüphane_Sistemi
{
    partial class Form5
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
            this.lst_kutuphane_listele = new System.Windows.Forms.ListBox();
            this.btn_geri_don4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(309, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(373, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kütüphane Listesi";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lst_kutuphane_listele
            // 
            this.lst_kutuphane_listele.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_kutuphane_listele.FormattingEnabled = true;
            this.lst_kutuphane_listele.ItemHeight = 19;
            this.lst_kutuphane_listele.Location = new System.Drawing.Point(309, 74);
            this.lst_kutuphane_listele.Name = "lst_kutuphane_listele";
            this.lst_kutuphane_listele.Size = new System.Drawing.Size(373, 365);
            this.lst_kutuphane_listele.TabIndex = 1;
            // 
            // btn_geri_don4
            // 
            this.btn_geri_don4.BackColor = System.Drawing.Color.Black;
            this.btn_geri_don4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri_don4.ForeColor = System.Drawing.Color.White;
            this.btn_geri_don4.Location = new System.Drawing.Point(12, 12);
            this.btn_geri_don4.Name = "btn_geri_don4";
            this.btn_geri_don4.Size = new System.Drawing.Size(129, 31);
            this.btn_geri_don4.TabIndex = 2;
            this.btn_geri_don4.Text = "GERİ DÖN";
            this.btn_geri_don4.UseVisualStyleBackColor = false;
            this.btn_geri_don4.Click += new System.EventHandler(this.btn_geri_don4_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(945, 586);
            this.Controls.Add(this.btn_geri_don4);
            this.Controls.Add(this.lst_kutuphane_listele);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lst_kutuphane_listele;
        private System.Windows.Forms.Button btn_geri_don4;
    }
}