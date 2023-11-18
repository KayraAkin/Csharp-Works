using Odev1OyunUyeSatışKampanya.Abstract;
using Odev1OyunUyeSatışKampanya.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1OyunUyeSatışKampanya.Concrete
{
    internal class KampanyaManager : IKampanyaService
    {
        public void Ekle(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.Adi + " adlı kampanya eklenmiştir");
        }

        public void Guncelle(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.Adi + " adlı kampanya güncellenmiştir");
        }

        public void Sıl(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.Adi + " adlı kampanya silinmiştir");
        }
    }
}
