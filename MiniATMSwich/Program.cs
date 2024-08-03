using System;

namespace MiniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            bool devam = true;

            while (devam)
            {
                Console.WriteLine("Hoş Geldiniz. Lütfen Yapmak Istediginiz Islem Numarasını Giriniz.");
                Console.WriteLine("1. Para Yatırmak");
                Console.WriteLine("2. Para Çekmek");
                Console.WriteLine("3. Toplam Bakiye");
                Console.WriteLine("4. Çıkış");

                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Yatırmak Istediginiz Tutarı Giriniz: ");
                        int tutar = Convert.ToInt32(Console.ReadLine());
                        bakiye += tutar;
                        Console.WriteLine("Yeni Bakiyeniz: " + bakiye);
                        break;
                    case 2:
                        Console.WriteLine("Çekmek Istediginiz Tutarı Giriniz: ");
                        tutar = Convert.ToInt32(Console.ReadLine());
                        if (bakiye >= tutar)
                        {
                            bakiye -= tutar;
                            Console.WriteLine("Yeni Bakiyeniz: " + bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz Bakiye");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Toplam Bakiyeniz: " + bakiye);
                        break;
                    case 4:
                        Console.WriteLine("Çıkış Yapılıyor...");
                        devam = false;
                        break;
                    default:
                        Console.WriteLine("Yanlış Girdiniz");
                        break;
                }
            }
        }
    }
}
