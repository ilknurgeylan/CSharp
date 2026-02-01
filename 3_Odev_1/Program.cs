namespace _3_Odev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev 1
            //Kullanıcıdan 3 adet sayı alınız ve bu sayıları A şeklinde görüldüğü gibi büyükten küçüğe sıralayınız ve ekrana yazdırınız
            //En büyük sayı 15
            //Ortanca sayı 13
            //En küçük sayı 5

            Console.WriteLine("İlk sayıyı yazınız");
            int ilkSayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı yazınız");
            int ikinciSayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçüncü sayıyı yazınız");
            int ücüncüSayi = Convert.ToInt32(Console.ReadLine());
            if (ilkSayi > ikinciSayi)
            {
                if (ikinciSayi > ücüncüSayi)
                {

                    Console.WriteLine($"Sayılar sırasıyla: {ilkSayi} > {ikinciSayi} > {ücüncüSayi}");

                }
                else
                {
                    Console.WriteLine($"Sayılar sırasıyla:{ilkSayi}>{ücüncüSayi} >{ikinciSayi}");
                }

            }
            else if (ikinciSayi > ilkSayi)
            {
                if (ilkSayi > ücüncüSayi)
                {
                    Console.WriteLine($"Sayılar sırasıyla {ikinciSayi}> {ilkSayi}>{ücüncüSayi}");
                }
                else
                {
                    Console.WriteLine($"Sayılar sırasıyla: {ikinciSayi}>{ücüncüSayi}>{ilkSayi}");
                }
            }

            else if (ücüncüSayi > ilkSayi)
            {
                if (ilkSayi > ikinciSayi)
                {
                    Console.WriteLine($"Sayılar sırasıyla:{ücüncüSayi}>{ilkSayi}>{ikinciSayi}");
                }
                else
                {
                    Console.WriteLine($"Sayılar sırasıyla:{ücüncüSayi}>{ikinciSayi}>{ilkSayi}");
                }
            }
            else
            {
                Console.WriteLine("Sayılar birbirine eşittir.");

            }
            #endregion
            #region Ödev 2
            //Kullanıcıdan şu anki hava sıcaklığını isteyip;
            //Hava sıcaklığı; 5 derece altındaysa "Hava soğuk,Kalın giysiler giyin" uyarısı yapsın.
            // 5 ile 15 arasında ise ; "Hava serin ceket giymeyi unutma" uyarısı.
            //15 ile 25 arasında ise ; "Hava ılık. Rahat şeyler giyebilirsin" uyarısı versin.
            //25 üzeri ise; Hava sıcaK uyarısı versin. 
            Console.WriteLine("Hava kaç derecedir?");
            int sicaklik = Convert.ToInt32(Console.ReadLine());
            if (sicaklik >= 25)
            {
                Console.WriteLine("Hava sıcaktır!");
            }
            else if (sicaklik < 25 && sicaklik >= 15)
            {
                Console.WriteLine("Hava ılık. Rahat şeyler giyebilirsin!");
            }
            else if (sicaklik < 15 && sicaklik >= 5)
            {
                Console.WriteLine("Hava serin ceket giymeyi unutma!");
            }
            else
            {
                Console.WriteLine("Hava soğuk, kalın giysiler giyin!");
            }

        }
    }
}
