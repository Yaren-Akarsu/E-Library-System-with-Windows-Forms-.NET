using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static E_Kütüphane_Sistemi.Form7;

namespace E_Kütüphane_Sistemi
{
    public partial class Form7 : Form
    {
        private List<Kitap> kitaplar = new List<Kitap>();
        public Form7()
        {
            InitializeComponent();
        }
        
        private void btn_geri_don6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_kaydet1_Click(object sender, EventArgs e)
        {
            string kitapNo = txt_kitap_no.Text;
            string yazarAdi = txt_yazar_adi.Text;
            string kitapAdi = txt_kitap_adi.Text;
            string yayinEvi = txt_yayinevi.Text;

           
            if (!string.IsNullOrWhiteSpace(kitapNo) && !string.IsNullOrWhiteSpace(yazarAdi) &&
                !string.IsNullOrWhiteSpace(kitapAdi) && !string.IsNullOrWhiteSpace(yayinEvi))
            {
                Kitap yeniKitap = new Kitap
                {
                    KitapNo = kitapNo,
                    YazarAdi = yazarAdi,
                    KitapAdi = kitapAdi,
                    YayinEvi = yayinEvi
                };

                
                kitaplar.Add(yeniKitap);

                
                lst_kitaplar.Items.Add(yeniKitap);
            }
            else
            {
                MessageBox.Show("LÜTFEN İSTENİLEN HER BİLGİYİ GİRİNİZ!");
            }

            DialogResult mesajSonucu = MessageBox.Show("Kaydetme İşlemi Başarılı Çıkış Yapmak İster Misiniz?", "Successfully Completed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mesajSonucu == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        public class Kitap
        {
            public string KitapNo { get; set; }
            public string YazarAdi { get; set; }
            public string KitapAdi { get; set; }
            public string YayinEvi { get; set; }

            public override string ToString()
            {
                return $"{KitapNo,-4} {YazarAdi,-18} {KitapAdi,-25} {YayinEvi,-30}";
            }
        }
        


    }
}
