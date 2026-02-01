using System.Runtime.CompilerServices;

namespace _8_Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {

        //Programın İşleyişi ve Gereksinimleri
        //Girdi Değerleri: Kullanıcıdan mesafe(KM), yaş ve yolculuk tipi(1: Tek Yön, 2: Gidiş - Dönüş) bilgileri alınır.
        //Kontrol Şartları: Mesafe ve yaş pozitif olmalı, yolculuk tipi yalnızca 1 veya 2 olmalıdır.Aksi durumda, kullanıcıya "Invalid Data Entered!" mesajı gösterilir.
        //Fiyat Hesaplama:
        //Mesafe başına ücret: 0.10 TL / KM
        //12 yaşından küçükler için % 50 indirim
        //12 - 24 yaş arası için % 10 indirim
        //65 yaş üstü için % 30 indirim
        //Gidiş - dönüş seçimi için ek % 20 indirim
        bsl:
            Console.WriteLine("Mil giriniz");
            int mil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yaş giriniz");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yolculuk tipi nedir: \n1-Tek Yön \n2-Çift Yön");
            int yon = Convert.ToInt32(Console.ReadLine());
            if (mil <= 0 || yas <= 0 || (yon != 1 && yon != 2))
            {
                Console.WriteLine("Hatalı giriş yaptınız, tekrar giriş yapınız");
                goto bsl;
            }
            else
            {
                double fiyat = mil * 0.10;
                double indirim = 0;
                if (yas < 12)
                {
                    indirim = 0.50;
                }
                else if (yas >= 12 && yas <= 24)
                {
                    indirim = 0.10;
                }
                else if (yas > 65)
                {
                    indirim = 0.30;
                }
                fiyat -= (fiyat * indirim);
                if (yon == 2)
                {
                    fiyat -= (fiyat * 0.2);
                    fiyat *= 2;
                }
                Console.Write("Bilet Tutarı:" + fiyat+"TL");
            }
        }
    }
}
