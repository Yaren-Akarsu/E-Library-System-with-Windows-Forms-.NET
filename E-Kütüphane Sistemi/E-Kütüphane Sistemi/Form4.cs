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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public void List()
        {
            string[] emanet = {
                " Kitap Adı                        Emanet Alınan Tarih      Teslim Tarihi          Kişi Bilgisi",
                " Veda Caddesi                     -     03.08.2023   -         22.08.2023   -     Melike Bora",
                " Warcross                         -     23.09.2023   -         30.09.2023   -     Yaren Akarsu",
                " Genç Elitler                     -     16.12.2023   -         20.12.2023   -     Selen Akarsu",
                " İnsan Ne İle Yaşar?              -     25.07.2023   -         01.08.2023   -     Tuğçe Yaşar",
                " Paris ve Londra'da Beş Parasız   -     12.05.2023   -         15.05.2023   -     Süleyman Demir",
                " Suç ve Ceza                      -     29.10.2023   -         08.11.2023   -     Batuhan Sevin",
                " Yalancılar ve Yabancılar         -     09.05.2023   -         15.05.2023   -     Egemen Akbaba",
                " Karantina                        -     09.12.2023   -         14.12.2023   -     Gizem Nur Çetin",
                " Sokak Nöbetçileri                -     06.02.2023   -         22.02.2023   -     Burak İşler",
                " Aşk ve Gurur                     -     14.07.2023   -         24.07.2023   -     Enes Arslan"
            };

            lst_emanet_listele.Items.Clear();
            lst_emanet_listele.Items.AddRange(emanet);
        }

        private void btn_geri_don3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
