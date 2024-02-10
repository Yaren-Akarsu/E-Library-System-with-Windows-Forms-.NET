using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static E_Kütüphane_Sistemi.Form8;

namespace E_Kütüphane_Sistemi
{
    public partial class Form9 : Form
    {
        private List<Emanet> emanetler = new List<Emanet>();
        public Form9()
        {
            InitializeComponent();
        }

        private void btn_geri_don8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_kaydet3_Click(object sender, EventArgs e)
        {
            string kitapAdii = txt_kitap_adii.Text;
            string emanetAlinanTarih = txt_emanet_alinan_tarih.Text;
            string teslimTarihi = txt_teslim_tarihi.Text;
            string kisiBilgisi = txt_kisi_bilgisi.Text;



            if (!string.IsNullOrWhiteSpace(kitapAdii) && !string.IsNullOrWhiteSpace(emanetAlinanTarih) &&
                  !string.IsNullOrWhiteSpace(teslimTarihi) && !string.IsNullOrWhiteSpace(kisiBilgisi))
            {
                Emanet yeniEmanet = new Emanet
                {
                    KitapAdii = kitapAdii,
                    EmanetAlinanTarih = emanetAlinanTarih,
                    TeslimTarihi = teslimTarihi,
                    KisiBilgisi = kisiBilgisi
                };


                emanetler.Add(yeniEmanet);


                lst_emanetler.Items.Add(yeniEmanet);
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

        public class Emanet
        {
            public string KitapAdii { get; set; }
            public string EmanetAlinanTarih { get; set; }
            public string TeslimTarihi { get; set; }
            public string KisiBilgisi { get; set; }




            public override string ToString()
            {
                return $"{KitapAdii,-25} {EmanetAlinanTarih,-15} {TeslimTarihi,-15}{KisiBilgisi,-35}";
            }
        }
    }
}
