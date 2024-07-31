using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ryDortIslemSecHesapla
{
    public partial class dortIslemSecHesaplaForm : Form
    {
        public dortIslemSecHesaplaForm()
        {
            InitializeComponent();
        }

        #region Değişkenler ve Tanımlamalar

        #endregion

        #region Kullanıcı Tanımlı Olaylar

        #endregion

        #region Nesne Tanımlı Olaylar
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float Sayi1 = float.Parse(tbSayi1.Text);
            float Sayi2 = float.Parse(tbSayi2.Text);
            float Sonuc=0;
            #region if - else
            //if (mantıksal sınama) doğru ise yap
            //    else değilse yap
            #region SelectedIndex
            //if (cmbIslem.SelectedIndex == 0)
            //{
            //    Sonuc = Sayi1 + Sayi2;
            //    lblSonuc.Text = Sonuc.ToString();
            //}
            //else if (cmbIslem.SelectedIndex == 1)
            //{
            //    Sonuc = Sayi1 - Sayi2;
            //    lblSonuc.Text = Sonuc.ToString();
            //}
            //else if (cmbIslem.SelectedIndex == 2)
            //{
            //    Sonuc = Sayi1 * Sayi2;
            //    lblSonuc.Text = Sonuc.ToString();
            //}
            //else if (cmbIslem.SelectedIndex == 3)
            //{
            //    Sonuc = Sayi1 / Sayi2;
            //    lblSonuc.Text = Sonuc.ToString();
            //}
            ////else
            ////    MessageBox.Show("Seçim Yap");
            #endregion

            #region Text      
            //if (cmbIslem.Text == "Toplama")
            //{
            //    Sonuc = Sayi1 + Sayi2;
            //    //lblSonuc.Text = Sonuc.ToString();
            //}
            //else if (cmbIslem.Text == "Çıkarma")
            //{
            //    Sonuc = Sayi1 - Sayi2;
            //    //lblSonuc.Text = Sonuc.ToString();
            //}
            //else if (cmbIslem.Text == "Çarpma")
            //{
            //    Sonuc = Sayi1 * Sayi2;
            //    //lblSonuc.Text = Sonuc.ToString();
            //}
            //else if (cmbIslem.Text == "Bölme")
            //{
            //    Sonuc = Sayi1 / Sayi2;
            //    //lblSonuc.Text = Sonuc.ToString();
            //}
            //else
            //  MessageBox.Show("İşlem Türünü Seçiniz","Bilgi",
            //      MessageBoxButtons.OK,MessageBoxIcon.Information);
            //lblSonuc.Text = Sonuc.ToString();
            #endregion
            #endregion

            #region switch - case
            //switch (cmbIslem.SelectedIndex)
            //{
            //    case 0:
            //        {
            //            Sonuc = Sayi1 + Sayi2;
            //        } break;
            //    case 1: { Sonuc = Sayi1 - Sayi2; }break;
            //    case 2: { Sonuc = Sayi1 * Sayi2; } break;
            //    case 3: { Sonuc = Sayi1 / Sayi2; } break;
            //    default: 
            //        {
            //            MessageBox.Show("İşlem Türünü Seçiniz", "Bilgi",
            //            MessageBoxButtons.OK,MessageBoxIcon.Information); 
            //        }break;
            //}
            switch (cmbIslem.Text)
            {
                case "Toplama":{Sonuc = Sayi1 + Sayi2;}break;
                case "Çıkarma": { Sonuc = Sayi1 - Sayi2; } break;
                case "Çarpma": { Sonuc = Sayi1 * Sayi2; } break;
                case "Bölme": { Sonuc = Sayi1 / Sayi2; } break;
                default:
                    {
                        MessageBox.Show("İşlem Türünü Seçiniz", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }

            lblSonuc.Text = Sonuc.ToString();
            #endregion
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkmak istiyor musunuz?", "Kapatma",
                MessageBoxButtons.OK, MessageBoxIcon.Question);
            Application.Exit();
        }
        #endregion
    }
}
