using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B191210075_NurSenaAytar_Proje1
{
    class Greyfurt : Urun, INarenciyeSikacagi
    {

        //Greyfurtun ağırlığı hesaplanır.
        public override int AgirlikHesaplama()
        {
            Urun u = new Greyfurt();
            Random agirlikHesaplama = new Random();
            u.setAgirlik(agirlikHesaplama.Next(70, 120));
            return u.getAgirlik();
        }

        //Greyfurtun narenciye sıkacağı ile sıkılması ile elde edilen verimi hesaplanır.
        public double verimNarenciyeSikacagi()
        {
            Urun u = new Greyfurt();
            Random verimHesaplama = new Random();
            u.setVerimOrani( verimHesaplama.Next(30, 70));
            u.setVerim(u.getVerimOrani() * AgirlikHesaplama() / 100);
            return u.getVerim();
        }

        //Greyfurtun A vitamin miktarı hesaplanır.
        public override double VitaminAHesaplama()
        {
            Urun u = new Greyfurt();
            //      throw new NotImplementedException();
            u.setVitaminA(Convert.ToDouble(AgirlikHesaplama() * 3) / 100);
            return u.getVitaminA();
        }

        //Greyfurtun C vitamin miktarı hesaplanır.
        public override double VitaminCHesaplama()
        {
            Urun u = new Greyfurt();
            //      throw new NotImplementedException();
            u.setVitaminC(Convert.ToDouble(AgirlikHesaplama() * 44) / 100);
            return u.getVitaminC();
        }
    }
}
