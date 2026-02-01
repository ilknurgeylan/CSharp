namespace _11_Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Çift Sayılar
            //100'e kadar yazdırmak istediğimizde döngüler devreye girer.
            int i = 1;
            int sayac = 0;
            int toplam = 0;
            do
            {
                toplam = 0;
                if (i % 2 == 0 && sayac == 0)

                    Console.WriteLine(i);
                toplam += i;
                i++;
            }
            while (i <= 100);//Koşulun gerçekleşeceği yer
            Console.WriteLine("Toplam sayınız: " + toplam);
            #endregion
            #region Deneme
            // int sayac = 0;
            //int sayi = 0;
            //int toplam = 0;
            //do
            //{
            //    Console.WriteLine("Sayı gir");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi == 0 && sayac == 0)
            //    {
            //        continue;//bu koşullar sağlanırsa bu adımı atla ve döngünün başına geri dön

            //    }
            //    else if (sayi > 0)
            //    {

            //        sayac++;
            //        toplam += sayi;
            //    }
            //    else if (sayi == 0)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Negatif değer girmeyiniz");
            //    }

            //}
            //while (true);
            //Console.WriteLine("Toplam: " + toplam);
            #endregion

        }
    }
}
