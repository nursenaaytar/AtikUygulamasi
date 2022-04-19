using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B191210075_NurSenaAytar_Proje1
{
    class Elma : Urun, IKatiMeyveSikacagi
    {
        //Elmanın ağırlığı hesaplanır.
        public override int AgirlikHesaplama()
        {
            Urun u = new Elma();
            //         throw new NotImplementedException();
            Random agirlikHesaplama = new Random();
            u.setAgirlik(agirlikHesaplama.Next(70, 120));
            return u.getAgirlik();
        }

        //Elmanın katı meyve sıkacağı ile sıkılması ile elde edilen verimi hesaplanır.
        public double verimKatiMeyveSikacagi()
        {
            Urun u = new Elma();
            //   throw new NotImplementedException();
            Random verimHesaplama = new Random();
            u.setVerimOrani(verimHesaplama.Next(80, 95));
            u.setVerim(u.getVerimOrani() * AgirlikHesaplama() / 100);
            return u.getVerim();
        }

        //Elmanın A vitamin miktarı hesaplanır.
        public override double VitaminAHesaplama()
        {
            Urun u = new Elma();
            //   throw new NotImplementedException();
            u.setVitaminA( Convert.ToDouble(AgirlikHesaplama() * 54) / 100);
            return u.getVitaminA();
        }

        //Elmanın C vitamin miktarı hesaplanır.
        public override double VitaminCHesaplama()
        {
            Urun u = new Elma();
            //   throw new NotImplementedException();
            u.setVitaminC(Convert.ToDouble(AgirlikHesaplama() * 5) / 100);
            return u.getVitaminC();
        }
    }
}
