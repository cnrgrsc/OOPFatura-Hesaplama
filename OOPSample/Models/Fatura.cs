using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample.Models
{
    public class Fatura
    {
        //Constructor based injection ile Encapsulation'i tam buradaki kurallarla uygulayın


      

        public string AdSoyad { get; set; }

        //Ilk index'in sonindex'ten büyük olmamasına dikkat ediniz derken bizim bu encapsulation'i index atamalarından birinde yapmamız saglıksız olur...
        int _sonIndex;
        public int SonIndex
        {
            
            get
            {
                return _sonIndex;
            }
            set
            {
                if (value >= 5)
                {
                    _sonIndex = value;
                }
                else throw new Exception("Index 5'ten kücük olamaz");
            }
        }

        int _ilkIndex;
        public int IlkIndex
        {
            
            get
            {
                return _ilkIndex;
            }

            set
            {
                if (value>0)
                {
                    _ilkIndex = value;
                }
                else
                {
                    throw new Exception("Ilk index 0'dan büyük olmalıdır");
                }
            }
        }
        public bool Mesken { get; set; }


        //Bir Property'nin set metodunu silmek o property'nin sadece readonly olmasını saglamaktır...
        public decimal KullanimMiktari
        {

            get


            {
                if(SonIndex-IlkIndex <= 0)
                {
                    throw new Exception("Sonuc negatif...Indexleri kontrol ediniz");
                }

                return SonIndex - IlkIndex;

            }
        }

        public decimal TutarHesapla()
        {

            if (SonIndex < IlkIndex)
            {
                throw new Exception("Index degerlerinde hata var..Lutfen SonIndex'in ilkIndex'ten büyük olmasına dikkat ediniz");
            }


            decimal tutar;
            if (Mesken)

                tutar = (KullanimMiktari * 0.7m) + (KullanimMiktari * 0.3m) * 0.2m;

            else tutar = KullanimMiktari * 0.3m;

            return tutar;
        }

    }
}
