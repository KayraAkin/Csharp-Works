using Odev1OyunUyeSatışKampanya.Abstract;
using Odev1OyunUyeSatışKampanya.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1OyunUyeSatışKampanya.Concrete
{
    public class OyunSatisiManager : IOyunSatisiServisi
    {
        public void OyunSatisi(Musteri muster, Kampanya kampanya)
        {
            Console.WriteLine(muster.Ad +" " +kampanya.Adi + " kampanyasını kullanarak "+ kampanya.Yuzdesi + " indirim ile oyunu satın almıştır.");
        }
    }
}
