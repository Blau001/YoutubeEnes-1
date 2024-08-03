using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hak = 3;
            while (true)
            {
                Console.WriteLine("Kullanıcıı adınızı giriniz");
                string kullanıcıAdı = Console.ReadLine();
                Console.WriteLine("Şifrenizi Giriniz.");
                string sifre = Console.ReadLine();
                if (kullanıcıAdı == "admin" && sifre == "123")
                {
                    Console.WriteLine("Hosgeldiniz");
                    break;
                }
                else
                {
                    Console.WriteLine("kullanıcı adı veya sifre yanlış");
                    
                }
                if ( hak>0)
                {
                    Console.WriteLine("Kalan hakkınız : " + hak + ", Tekrar deneyiniz.");
                    hak--;
                }
                else
                {
                    Console.WriteLine("Hakkınız bitti");
                    break;
                }
                
            }
        }
    }
}
