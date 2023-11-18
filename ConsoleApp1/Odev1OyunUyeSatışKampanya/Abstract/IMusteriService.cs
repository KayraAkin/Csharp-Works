using Odev1OyunUyeSatışKampanya.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1OyunUyeSatışKampanya.Abstract
{
    public interface IMusteriService
    {
        void KayitOl(Musteri musteri);

        void KayitGuncelle(Musteri musteri);

        void KayitSil(Musteri musteri);
    }
}
