using Odev1OyunUyeSatışKampanya.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1OyunUyeSatışKampanya.Entities
{
     public class Musteri:IEntities
    {
        public int Id { get; set; }
        public string TcNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumYili { get; set; }

    }
}
