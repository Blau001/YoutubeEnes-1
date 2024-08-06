using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMetotKullanımı
{
    public class Personel
    {
        public static  void isimSoyisimYazdır()
        {
        Console.WriteLine("Selçuk Yiğit");
        }
        public static void toplaYap()
        {
            Console.WriteLine("İlk sayıyı giriniz.");
            int sayi1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci sayıyı giriniz.");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplam = " + (sayi1 + sayi2));
        }
    }
}
