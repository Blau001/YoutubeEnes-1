using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM
{
    internal class Program
    {
        private static int secim;

        static void Main(string[] args)
        {

            int bakiye = 1000;
            Console.WriteLine("Hoş geldiniz.");
            Console.WriteLine("Hangi işlemi yapmak istiyorsunuz?");
            Console.WriteLine("1. Para Yatırma");
            Console.WriteLine("2. Para Cekme");
            Console.WriteLine("3. Bakiye Sorgulama");
            Console.WriteLine("4. Cıkış");
            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim > 4)
            {
                Console.WriteLine("Gecersiz islem");
            }
            else if (secim == 1)
            {
                Console.WriteLine("Ne kadar para yatırmak istersiniz?");
                int para = Convert.ToInt32(Console.ReadLine());
                bakiye += para;
                Console.WriteLine("Yeni bakiyeniz: " + bakiye);
            }
            else if (secim == 2)
            {
                Console.WriteLine("Ne kadar para cekmek istersiniz?");
                int para = Convert.ToInt32(Console.ReadLine());
                if (bakiye >= para)
                {
                    bakiye -= para;
                    Console.WriteLine("Yeni bakiyeniz: " + bakiye);
                    Console.ReadLine();
                }
                else 
                {
                    Console.WriteLine("Yetersiz bakiye, çıkış yapmak için bir tuşa tıklayın.");
                    
                }
            }
            else if (secim == 3)
            {
                Console.WriteLine("Bakiyeniz: " + bakiye);
            }
            else if (secim == 4)
            {
                Console.WriteLine("Çıkış için rastgele bir tuşa tıklayınız.");
            }
        }
    }
}
