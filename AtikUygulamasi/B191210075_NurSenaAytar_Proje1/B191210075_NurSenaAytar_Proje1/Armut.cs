using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B191210075_NurSenaAytar_Proje1
{
    class Armut : Urun, IKatiMeyveSikacagi
    {
        //Armutun ağırlığı hesaplanır.
        public override int AgirlikHesaplama()
        {
                 Urun u=new Armut();
            //         throw new NotImplementedException();
            Random agirlikHesaplama = new Random();
            u.setAgirlik(agirlikHesaplama.Next(70, 120));
            return u.getAgirlik();
        }

        //Armutun katı meyve sıkacağı ile sıkılması ile elde edilen verimi hesaplanır.
        public double verimKatiMeyveSikacagi()
        {
            Urun u = new Armut();
            //     throw new NotImplementedException();
            Random verimHesaplama = new Random();
            u.setVerimOrani(verimHesaplama.Next(80, 95));
            u.setVerim(u.getVerimOrani() * AgirlikHesaplama() / 100);
            return u.getVerim();
        }

        //Armutun A vitamin miktarı hesaplanır.
        public override double VitaminAHesaplama()
        {
            Urun u = new Armut();
            //   throw new NotImplementedException();
            u.setVitaminA(Convert.ToDouble(AgirlikHesaplama() * 25) / 100);
            return u.getVitaminA();
        }

        //Armutun C vitamin miktarı hesaplanır.
        public override double VitaminCHesaplama()
        {
            Urun u = new Armut();
            //   throw new NotImplementedException();
            u.setVitaminC(Convert.ToDouble(AgirlikHesaplama() * 5) / 100);
            return u.getVitaminC();
        }
    }
}
