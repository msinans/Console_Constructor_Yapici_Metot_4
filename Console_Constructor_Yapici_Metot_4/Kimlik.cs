using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Constructor_Yapici_Metot_4
{
    internal class Kimlik
    {
        // değişken isimlerini atıyoruz
        string ad;
        string soyad;
        string sehir;
        int yas;
        char cinsiyet;

        // Kapsülleme kullanıyoruz
        public string AD
        {
            get { return ad; }
            set { ad = value.ToLower(); }
        }
        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }
        public string SEHİR
        {
            get { return sehir; }
            set { sehir = value; }
        }

        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }
        public char CINSIYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }
        // Constructor kullanarak ilk değer ataması yapıyoruz
        public Kimlik()
        {
            ad = "";
            soyad = "";
            sehir = "İstanbul";
            yas = 18;
            cinsiyet = 'K';
        }
    }
}
