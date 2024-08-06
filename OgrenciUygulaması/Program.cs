
using System;

namespace OgrenciUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci _ogrenci = new Ogrenci(87, "Selçuk", "Yiğit", 78, 50, 93, "Çanakkale Onsekiz Mart Üniversitesi");
            İslemleriGoster();

            while (true)
            {
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        _ogrenci.OgrenciBilgileriGoster();
                        break;
                    case "2":
                        double notOrt = _ogrenci.OgrenciNotOrt;
                        Console.WriteLine("Öğrencinin not ortalaması: " + notOrt);
                        break;
                    case "3":
                        _ogrenci.OkulGetir();
                        break;
                    case "4":
                        Console.WriteLine("Çıkış yapılıyor...");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;
                }
                İslemleriGoster();
            }
        }

        static void İslemleriGoster()
        {
            Console.WriteLine("1. Öğrenci bilgilerini göster");
            Console.WriteLine("2. Öğrenci not ortalamasını hesapla");
            Console.WriteLine("3. Öğrencinin okul bilgisini göster");
            Console.WriteLine("4. Çıkış");
        }
    }
}
