using Odev1OyunUyeSatışKampanya.Abstract;
using Odev1OyunUyeSatışKampanya.Entities;
using Odev1OyunUyeSatışKampanya.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1OyunUyeSatışKampanya.Concrete
{
    public class MusteriManager : IMusteriService
    {

        IMusteriCheckService _musteriCheckService;

        public MusteriManager(IMusteriCheckService musteriCheckService)
        {
            _musteriCheckService = musteriCheckService;
        }

        public void KayitGuncelle(Musteri musteri)
        {


            
            Console.WriteLine(musteri.Ad + " adlı müşterinin kaydı güncellendi");
        }
            
        public void KayitOl(Musteri musteri)
        {

            if (_musteriCheckService.CheckMusteri(musteri))
            {
                Console.WriteLine(musteri.Ad + " adlı müşterinin kaydı gerçekleşti");
            }
            else
            {
                Console.WriteLine("Böyle bir kullanıcı bulunamadı");
            }

        }

        public void KayitSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " adlı müşterinin kaydı silindi");
        }
    }
}
