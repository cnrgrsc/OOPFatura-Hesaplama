using OOPSample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*
           Kullanım miktarınızı hesaplamak icin öncelikle sonindeksin ilk indeksten cıkarılması gerekir...Tutar meskende kullanım miktarının 0.7 ile carpılması, halka acık yerlerde kullanım miktarının 0.3 ile carpılmasıdır...

        //Son indeksin ilk indeksten kücük olmamasına dikkat ediniz. Aksi halde hatalı bir sorgulama yapılacaktır. Programda kullanıcının düzgün formatta giriş yapmasını saglamalısınız... Aynı zamanda textbox'a ben yanlıslıkl sayı yerine yazı girersem o da uyarı versin..

        //Halka acık alanlarda su ücreti : 0.3 
        //Meskende : 0.7

        //Kurumumuz atık su ücreti almaktadır. Bu ücret de sadece mesken üzerinde belirlenmektedir. Bu ücret toplam kullanılan suyun %30'u kadar ekstradan hesaplanır ve yine her bir atık su basına 0.2 tl ücret alınır...

         // (KullanimMiktari * 0.7m)  + ( kullanimMiktari * 0.3m *0.2m);
         
         
         
         
         
         
         
         
         */
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //Fatura f = new Fatura(13,10);
            
            

           
            try
            {
                //Object Initializer
                Fatura f = new Fatura
                {
                    AdSoyad = txtAdSoyad.Text,
                    SonIndex = Convert.ToInt32(txtSonIndex.Text),
                    IlkIndex = Convert.ToInt32(txtIlkIndex.Text),
                    Mesken = rdbMesken.Checked


                };
                //Asagıdaki tarafta dikkat ederseniz listbox'lara teker teker veriler eklenmiştir yani bir nesne eklenmemiştir...Cünkü istek o yöndedir...

                string yazdirilacakTutar = f.TutarHesapla().ToString("C2");
                lstAdSoyad.Items.Add(f.AdSoyad);
                lstMiktar.Items.Add(f.KullanimMiktari);
                lstFatura.Items.Add(yazdirilacakTutar); //C2 formatı sisteminize göre para ikonu cıkartır...



            }
            catch (Exception ex)
            {

                MessageBox.Show($"Sistem hata mesajı:{ex.Message}");
            }


        }
    }
}
