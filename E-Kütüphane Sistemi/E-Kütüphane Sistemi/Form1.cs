using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Kütüphane_Sistemi
{
    public partial class Form1 : Form
    {

        


        public Form1()
        {
            InitializeComponent();
           

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            DialogResult mesajSonucu = MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mesajSonucu == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_kitap_ekle_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();

            form7.Show();
            
        }

        private void btn_kitap_liste_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
            form3.List();
        }

        private void btn_uye_liste_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();

            form2.Show();
            form2.List();
        }

        private void btn_emanet_liste_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4();

            form4.Show();
            form4.List(); 
        }

        private void btn_kutuphane_liste_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            form5.Show();
            form5.List();
        }

        private void btn_kategori_liste_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();

            form6.Show();
            form6.List();
        }

        private void btn_uye_ekle_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();

            form8.Show();
        }

        private void btn_emanet_islemleri_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();

            form9.Show();
        }
    }
}
