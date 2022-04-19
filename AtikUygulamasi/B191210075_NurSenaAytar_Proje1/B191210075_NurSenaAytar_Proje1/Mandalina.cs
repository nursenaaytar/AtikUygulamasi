using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B191210075_NurSenaAytar_Proje1
{
    class Mandalina : Urun, INarenciyeSikacagi
    {
        //Mandalinanın ağırlığı hesaplanır.
        public override int AgirlikHesaplama()
        {
                   Urun u=new Mandalina();
            //         throw new NotImplementedException();
            Random agirlikHesaplama = new Random();
            u.setAgirlik(agirlikHesaplama.Next(70, 120));
            return u.getAgirlik();
        }

        //Mandalinanın narenciye sıkacağı ile sıkılması ile elde edilen verimi hesaplanır.
        public double verimNarenciyeSikacagi()
        {
            Urun u = new Mandalina();
            //    throw new NotImplementedException();
            Random verimHesaplama = new Random();
            u.setVerimOrani(verimHesaplama.Next(30, 70));
            u.setVerim(u.getVerimOrani() * AgirlikHesaplama() / 100);
            return u.getVerim();
        }

        //Mandalinanın A vitamin miktarı hesaplanır.
        public override double VitaminAHesaplama()
        {
            Urun u = new Mandalina();
            //    throw new NotImplementedException();
            u.setVitaminA(Convert.ToDouble(AgirlikHesaplama() * 681) / 100);
            return u.getVitaminA();
        }

        //Mandalinanın C vitamin miktarı hesaplanır.
        public override double VitaminCHesaplama()
        {
            Urun u = new Mandalina();
            //    throw new NotImplementedException();
            u.setVitaminC(Convert.ToDouble(AgirlikHesaplama() * 26) / 100);
            return u.getVitaminC();
        }
    }
}
