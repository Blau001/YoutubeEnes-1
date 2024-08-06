using System;

namespace KapsullemeOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel();

            Console.WriteLine("Lütfen TC numaranızı giriniz:");
            string tcNo = Console.ReadLine();

            personel.PersonelTC = tcNo;

            Console.WriteLine("Gizlenmiş TC numarası: " + personel.PersonelTC);
            Console.ReadLine();
        }
    }
}
