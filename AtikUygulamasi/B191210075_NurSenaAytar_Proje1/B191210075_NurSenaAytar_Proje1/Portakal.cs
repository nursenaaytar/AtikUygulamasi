using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B191210075_NurSenaAytar_Proje1
{
    class Portakal : Urun, INarenciyeSikacagi
    {
        //Portakalın ağırlığı hesaplanır.
        public override int AgirlikHesaplama()
        {
            Urun u = new Portakal();
            //         throw new NotImplementedException();
            Random agirlikHesaplama = new Random();
            u.setAgirlik(agirlikHesaplama.Next(70, 120));
            return u.getAgirlik();
        }

        //Portakalın narenciye sıkacağı ile sıkılması ile elde edilen verimi hesaplanır.
        public double verimNarenciyeSikacagi()
        {
            Urun u = new Portakal();
            //      throw new NotImplementedException();
            Random verimHesaplama = new Random();
            u.setVerimOrani(verimHesaplama.Next(30, 70));
            u.setVerim(u.getVerimOrani() * AgirlikHesaplama() / 100);
            return u.getVerim();
        }

        //Portakalın A vitamin miktarı hesaplanır.
        public override double VitaminAHesaplama()
        {
            Urun u = new Portakal();
            //     throw new NotImplementedException();
            u.setVitaminA(Convert.ToDouble(AgirlikHesaplama() * 225) / 100);
            return u.getVitaminA();
        }

        //Portakalın C vitamin miktarı hesaplanır.
        public override double VitaminCHesaplama()
        {
            Urun u = new Portakal();
            //     throw new NotImplementedException();
            u.setVitaminC(Convert.ToDouble(AgirlikHesaplama() * 45) / 100);
            return u.getVitaminC();
        }
    }
}
