using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B191210075_NurSenaAytar_Proje1
{
    class Cilek : Urun,IKatiMeyveSikacagi
    {
        //Çileğin ağırlığı hesaplanır.
        public override int AgirlikHesaplama()
        {
                Urun u=new Cilek();
            //         throw new NotImplementedException();
            Random agirlikHesaplama = new Random();
            u.setAgirlik(agirlikHesaplama.Next(70, 120));
            return u.getAgirlik();

        }

        //Çileğin katı meyve sıkacağı ile sıkılması ile elde edilen verimi hesaplanır.
        public double verimKatiMeyveSikacagi()
        {
            Urun u = new Cilek();
            //     throw new NotImplementedException();
            Random verimHesaplama = new Random();
            u.setVerimOrani(verimHesaplama.Next(80, 95));
            u.setVerim(u.getVerimOrani() * AgirlikHesaplama() / 100);
            return u.getVerim();
        }

        //Çileğin A vitamin miktarı hesaplanır.
        public override double VitaminAHesaplama()
        {
            Urun u = new Cilek();
            //        throw new NotImplementedException();
            u.setVitaminA (Convert.ToDouble(AgirlikHesaplama() * 12) / 100);
            return u.getVitaminA();
        }

        //Çileğin C vitamin miktarı hesaplanır.
        public override double VitaminCHesaplama()
        {
            Urun u = new Cilek();
            //        throw new NotImplementedException();
            u.setVitaminC(Convert.ToDouble(AgirlikHesaplama() * 60) / 100);
            return u.getVitaminC();
        }
    }
}
