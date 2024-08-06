using System;

namespace KapsullemeOdev
{
    public class Personel
    {
        private string personelTC = string.Empty; // Başlangıçta boş bir string ile başlatılıyor

        public string PersonelTC
        {
            get
            {
                return personelTC.Substring(0, 5) + "******";
            }
            set
            {
                if (value.Length == 11)
                {
                    bool kontrol = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (!char.IsNumber(value[i]))
                        {
                            kontrol = true;
                            break;
                        }
                    }

                    if (kontrol)
                    {
                        Console.WriteLine("TC numarası sadece rakamlardan oluşmalıdır.");
                    }
                    else
                    {
                        personelTC = value;
                    }
                }
                else
                {
                    Console.WriteLine("Girilen TC numarası 11 haneli olmalıdır.");
                }
            }
        }
    }
}
