using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirileninKaresiniAlmak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Karesini almak istediğiniz sayıyı giriniz");
            int Karesi= KareAl(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Seçtiğiniz sayının karesi: " + Karesi);
            if (Karesi > 25)
            {
                Console.WriteLine("Karesi 25'den buyuk");
            }
            if (Karesi == 25)
            {
                Console.WriteLine("Karesi 25'e esittir");
            }
            else
            {
                Console.WriteLine("Karesi 25'den kucuk");
            }
            Console.ReadLine();
        }
        static int KareAl(int sayi)
        {
            
            return sayi * sayi;
        }
    }
}
