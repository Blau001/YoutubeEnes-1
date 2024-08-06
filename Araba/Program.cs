using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            araba araba1 = new araba();

            araba1.ArabaModeli = "Mercedes";
            araba1.arabaKapiSayisi = 4;
            araba1.ArabaRengi = "Beyaz";
            Console.WriteLine("Araba Modeli: "+ araba1.ArabaModeli);
            Console.WriteLine("Araba Rengi: " + araba1.ArabaRengi);
            Console.WriteLine("Araba Kapı Sayısı: " + araba1.arabaKapiSayisi);
            araba1.motoruCalistir();
            araba1.kapilariKilitle();
        }
    }
}
