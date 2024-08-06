using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMetotKullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel.isimSoyisimYazdır();
            Personel.toplaYap();
            Console.ReadLine();
        }
    }
}
