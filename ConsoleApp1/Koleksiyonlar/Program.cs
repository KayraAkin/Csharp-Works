using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Kayra", "Fatma", "Batu", "Olgun", "Ostik" };

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            Console.WriteLine("---------------------");

            List<string> isimler2 = new List<string> { "Kayra", "Fatma", "Batu", "Olgun", "Ostik" };

        }
    }
}
