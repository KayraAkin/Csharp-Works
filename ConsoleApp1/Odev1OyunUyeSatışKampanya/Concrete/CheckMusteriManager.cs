using Odev1OyunUyeSatışKampanya.Abstract;
using Odev1OyunUyeSatışKampanya.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1OyunUyeSatışKampanya.Concrete
{
    public class CheckMusteriManager : IMusteriCheckService
    {
        public bool CheckMusteri(Musteri musteri)
        {

            if(musteri.TcNo == "11111111111")
            {
                return true;
            }
            else
            {
                return false;
            }
                       
        }

    }
}
