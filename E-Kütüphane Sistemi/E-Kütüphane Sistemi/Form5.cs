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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public void List()
        {
            string[] kutuphane = {
                "ŞEHİR               KÜTÜPHANE ADI",
                "Ankara            Millet Kütüphanesi",
                "İstanbul          Taksim Kütüphane ",
                "İzmir             Kent üniversitesi",
                "Çanakkale         Barbaros Kütüphanesi",
                "Tekirdağ          Kubbealtı Kütphanesi",
                "Bolu              Halk Kütüphanesi",
                "Aydın              Anadolu Kütüphanesi"
            };

            lst_kutuphane_listele.Items.Clear();
            lst_kutuphane_listele.Items.AddRange(kutuphane);
        }
        private void btn_geri_don4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
