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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public void List()
        {
            string[] kategoriler = {
                "KATEGORİ ADI" ,
                "Roman",
                "Polisiye ve Gerilim",
                "Bilim Kurgu ",
                "Fantastik ", 
                "Korku ", 
                "Biyografi ve Otobiyografi ", 
                "Tarihi Roman " ,
                "Genç Kurgu ", 
                "Felsefe " ,
                "Kişisel Gelişim"

            };

            lst_kategori_listele.Items.Clear();
            lst_kategori_listele.Items.AddRange(kategoriler);
        }

        private void btn_geri_don5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
