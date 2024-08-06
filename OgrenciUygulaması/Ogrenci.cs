using System;

namespace OgrenciUygulamasi
{
    public class Ogrenci
    {
        private int ogrenciNo;
        private string ogrenciAdi;
        private string ogrenciSoyadi;
        private int vize1;
        private int vize2;
        private int final;
        private string okulIsmi;

        public Ogrenci(int _ogrenciNo, string _ogrenciAdi, string _ogrenciSoyadi, int _vize1, int _vize2, int _final, string _okulIsmi)
        {
            ogrenciNo = _ogrenciNo;
            ogrenciAdi = _ogrenciAdi;
            ogrenciSoyadi = _ogrenciSoyadi;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulIsmi = _okulIsmi;
        }

        public void OgrenciBilgileriGoster()
        {
            Console.WriteLine("Öğrenci Numarası: " + ogrenciNo);
            Console.WriteLine("Öğrenci Adı: " + ogrenciAdi);
            Console.WriteLine("Öğrenci Soyadı: " + ogrenciSoyadi);
            Console.WriteLine("Öğrenci Vize 1 notu: " + vize1);
            Console.WriteLine("Öğrenci Vize 2 notu: " + vize2);
            Console.WriteLine("Öğrenci Final notu: " + final);
            Console.WriteLine("Öğrenci Okulu: " + okulIsmi);
        }

        public double OgrenciNotOrt
        {
            get
            {
                return vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            }
        }

        public void OkulGetir()
        {
            Console.WriteLine("Okulun adı: " + okulIsmi);
        }
    }
}
