using Odev1OyunUyeSatışKampanya.Concrete;
using Odev1OyunUyeSatışKampanya.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1OyunUyeSatışKampanya
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri {Ad = "Kayra",
                DogumYili = new DateTime(1999,09,20),
                Id = 1, Soyad= "Akın",
                TcNo= "11111111111" };

            Kampanya kampanya = new Kampanya { Adi = "Yılbaşı İndirimi" , Id = 1, Yuzdesi = "%20"};
            Kampanya kampanya2 = new Kampanya { Adi = "Cadılar Bayramı İndirimi" , Id = 2, Yuzdesi = "%50"};

            CheckMusteriManager checkMusteriManager = new CheckMusteriManager();

            MusteriManager musteriManager = new MusteriManager(checkMusteriManager);

            musteriManager.KayitOl(musteri1);

            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.Ekle(kampanya);
            kampanyaManager.Ekle(kampanya2);

            OyunSatisiManager oyunSatisiManager = new OyunSatisiManager();

            oyunSatisiManager.OyunSatisi(musteri1, kampanya);


            



        }
    }
}
