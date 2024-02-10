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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void List()
        { 
            string[] uyeler = { 
                "ÜYE NO          ÜYE ADI                ÜYE SOYADI",
                "1                   Yaren                    Akarsu", 
                "2                  Melike                     Bora",
                "3                  Tuğçe                     Yaşar",
                "4                  Burak                     İşler",
                "5                Batuhan                     Sevin",
                "6               Gizem Nur                   Çetin",
                "7              Süleyman                     Demir",
                "8               Selen                       Akarsu",
                "9               Egemen                      Akbaba",
                "10               Enes                        Arslan"
            };

            lst_uye_listele.Items.Clear();
            lst_uye_listele.Items.AddRange(uyeler);
        }

        private void btn_geri_don2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
