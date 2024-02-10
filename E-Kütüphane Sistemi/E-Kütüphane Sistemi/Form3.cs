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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void List()
        {
            string[] kitaplar = {
                "KİTAP NO      YAZAR ADI                KİTAP ADI                           YAYINEVİ",
                "01         Sümeyye Demirkan           Veda Caddesi                       Ephesus Yayınları",
                "02             Marie Lu                Warcross                        Yabancı Yayınları",
                "03             Marie Lu               Genç Elitler                      Yabancı Yayınları",
                "04           Lev Tolstoy            İnsan Ne İle Yaşar?                  Can Yayınları",
                "05           George Orwell      Paris ve Londra'da Beş Parasız           Can Yayınları",
                "06           Dostoyevski             Suç ve Ceza                           İş Bankası Kültür Yayınları",
                "07            Emre Gül           Yalancılar ve Yabancılar                 Ren Kitap",
                "08           Beyza Alkoç             Karantina                              İndigo Kitap",
                "09           Aslı Arslan          Sokak Nöbetçileri                       İndigo Kitap",
                "10           Jane Austen          Aşk ve Gurur                            Can Yayınları"
            };

            lst_kitap_listele.Items.Clear();
            lst_kitap_listele.Items.AddRange(kitaplar);

        }
        
        private void btn_geri_don1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
