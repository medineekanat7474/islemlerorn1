using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace islemlerorn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnToplam_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(txtSayı1.Text);
            sayi2 = Convert.ToInt32(txtSayı2.Text);
            sonuc = sayi1 + sayi2;

            lblSonuc.Text = "toplam: " + sonuc.ToString();


         }

        private void btnCikar_Click(object sender, EventArgs e)
        {

            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(txtSayı1.Text);
            sayi2 = Convert.ToInt32(txtSayı2.Text);
            sonuc = sayi1 - sayi2;

            lblSonuc.Text = "fark: " + sonuc.ToString();
                

        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(txtSayı1.Text);
            sayi2 = Convert.ToInt32(txtSayı2.Text);
            sonuc = sayi1 * sayi2;

            lblSonuc.Text = "sonuç: " + sonuc.ToString();

        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            float sayi1, sayi2, sonuc;
            sayi1 = Convert.ToSingle(txtSayı1.Text);
            sayi2 = Convert.ToSingle(txtSayı2.Text);
            sonuc = sayi1 / sayi2;

            lblSonuc.Text = "sonuç: " + sonuc.ToString();
        }
    }
}
