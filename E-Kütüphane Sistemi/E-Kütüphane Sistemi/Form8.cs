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
    public partial class Form8 : Form
    {

        private List<Uye> uyeler = new List<Uye>();
        public Form8()
        {
            InitializeComponent();
        }

        private void btn_geri_don7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_kaydet2_Click(object sender, EventArgs e)
        {
            string uyeNo = txt_uye_no.Text;
            string uyeAdi = txt_uye_adi.Text;
            string uyeSoyadi = txt_uye_soyadi.Text;
            


            if (!string.IsNullOrWhiteSpace(uyeNo) && !string.IsNullOrWhiteSpace(uyeAdi) &&
                !string.IsNullOrWhiteSpace(uyeSoyadi))
            {
                Uye yeniUye = new Uye
                {
                    UyeNo = uyeNo,
                    UyeAdi = uyeAdi,
                    UyeSoyadi = uyeSoyadi
                    
                };


                uyeler.Add(yeniUye);


                lst_uyeler.Items.Add(yeniUye);
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
        public class Uye
        {
            public string UyeNo { get; set; }
            public string UyeAdi { get; set; }
            public string UyeSoyadi { get; set; }
           

            public override string ToString()
            {
                return $"{UyeNo,-3} {UyeAdi,-15} {UyeSoyadi,-20}";
            }
        }
    
    }
}
