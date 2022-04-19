using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B191210075_NurSenaAytar_Proje1
{
    abstract class Urun
    {
        private int _agirlik;
        private int _verimOrani;
        private double _verim;
        private double _vitaminA;
        private double _vitaminC;

        //Urun adında constructer oluşturuldu.
        public Urun() { }

        //private olan _agirlik değerine erişebilmek ve değer ataması yapabilmek için oluşturuldu.
        public void setAgirlik(int a)
        {
            _agirlik = a;
        }

        //private olan _agirlik değerine erişebilmek için oluşturuldu.
        public int getAgirlik()
        {
            return _agirlik;
        }

        //private olan _verimOrani değerine erişebilmek ve değer ataması yapabilmek için oluşturuldu.
        public void setVerimOrani(int b)
        {
            _verimOrani = b;
        }

        //private olan _verimOrani değerine erişebilmek için oluşturuldu.
        public int getVerimOrani()
        {
            return _verimOrani;
        }

        //private olan _verim değerine erişebilmek ve değer ataması yapabilmek için oluşturuldu.
        public void setVerim(double c)
        {
            _verim = c;
        }

        //private olan _verim değerine erişebilmek için oluşturuldu.
        public double getVerim()
        {
            return _verim;
        }

        //private olan _vitaminA değerine erişebilmek ve değer ataması yapabilmek için oluşturuldu.
        public void setVitaminA(double d)
        {
            _vitaminA = d;
        }

        //private olan _vitaminA değerine erişebilmek için oluşturuldu.
        public double getVitaminA()
        {
            return _vitaminA;
        }

        //private olan _vitaminC değerine erişebilmek ve değer ataması yapabilmek için oluşturuldu.
        public void setVitaminC(double e)
        {
            _vitaminC = e;
        }

        //private olan _vitaminC değerine erişebilmek için oluşturuldu.
        public double getVitaminC()
        {
            return _vitaminC;
        }

        //Urunun A vitamini miktarını hesaplamak için oluşturuldu.
        public abstract double VitaminAHesaplama();

        //Urunun C vitamini miktarını hesaplamak için oluşturuldu.
        public abstract double VitaminCHesaplama();

        //Urunun ağırlığını hesaplamak için oluşturuldu.
        public abstract int AgirlikHesaplama();

    }
}
