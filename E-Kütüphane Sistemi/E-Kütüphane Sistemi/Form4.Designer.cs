namespace E_Kütüphane_Sistemi
{
    partial class Form4
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
            this.lst_emanet_listele = new System.Windows.Forms.ListBox();
            this.btn_geri_don3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(233, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(748, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Emanet Listesi";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lst_emanet_listele
            // 
            this.lst_emanet_listele.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_emanet_listele.FormattingEnabled = true;
            this.lst_emanet_listele.ItemHeight = 19;
            this.lst_emanet_listele.Location = new System.Drawing.Point(233, 73);
            this.lst_emanet_listele.Name = "lst_emanet_listele";
            this.lst_emanet_listele.Size = new System.Drawing.Size(748, 384);
            this.lst_emanet_listele.TabIndex = 1;
            // 
            // btn_geri_don3
            // 
            this.btn_geri_don3.BackColor = System.Drawing.Color.Black;
            this.btn_geri_don3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri_don3.ForeColor = System.Drawing.Color.White;
            this.btn_geri_don3.Location = new System.Drawing.Point(12, 12);
            this.btn_geri_don3.Name = "btn_geri_don3";
            this.btn_geri_don3.Size = new System.Drawing.Size(123, 30);
            this.btn_geri_don3.TabIndex = 2;
            this.btn_geri_don3.Text = "GERİ DÖN";
            this.btn_geri_don3.UseVisualStyleBackColor = false;
            this.btn_geri_don3.Click += new System.EventHandler(this.btn_geri_don3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1067, 522);
            this.Controls.Add(this.btn_geri_don3);
            this.Controls.Add(this.lst_emanet_listele);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lst_emanet_listele;
        private System.Windows.Forms.Button btn_geri_don3;
    }
}