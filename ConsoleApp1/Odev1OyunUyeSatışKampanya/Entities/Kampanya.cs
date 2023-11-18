using Odev1OyunUyeSatışKampanya.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1OyunUyeSatışKampanya.Entities
{
    public class Kampanya:IEntities
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Yuzdesi { get; set; }
    }
}
