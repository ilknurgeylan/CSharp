using System.Globalization;
using System.Reflection.Metadata;

namespace _7_Odev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ödev
            //Kullanıcıdan alınan cinsiyet bilgisine göre
            //==> ERKEK ise
            //yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek,
            //yaş 60'ın altında ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    
            //6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
            //==> KADIN ise
            // yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, 
            //yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 5600 ve üstü ise 
            //maaşının 11 katı kadar ikramiye alarak emekli edilecek
            //5600 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
            //==> cinsiyet bilgisi switch-case ile sorgulanacak


            //Console.WriteLine("Cinsiyet giriniz, erkek ise E, kadın ise k kullanınız:\nE\nK");
            //string c = Console.ReadLine().ToLower(); //char olarak giremedim?
            //Console.WriteLine("Yaşınız kaçtır?");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Güncel maaş tutarınız nedir?");
            //double maas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Güncel prim gününüz nedir?");
            //int gun = Convert.ToInt32(Console.ReadLine());
            //switch (c)
            //{

            //    case "e": Console.WriteLine();
            //        if ( yas >= 60)
            //        {
            //            Console.WriteLine($"Tebrikler! Emekli oldunuz. Güncel ikramiye tutarınız{maas * 10}");
            //        }
            //        else if (yas < 60 || yas > 0)
            //            if (gun >= 6000)
            //            {
            //                Console.WriteLine($"Tebrikler! Emekli oldunuz. Güncel ikramiye tutarınız{maas * 11}");
            //            }
            //            else if (gun < 6000)
            //            { 
            //                Console.WriteLine("Üzgünüz, prim gün sayısı nedeniyle emeklilik hakkınız bulunmamaktadır.");
            //            }

            //                break;
            //    case "k": Console.WriteLine(); 
            //        if ( yas >= 58)
            //        {
            //            Console.WriteLine($"Tebrikler! Emekli oldunuz. Güncel ikramiye tutarınız{maas * 10}");
            //        }
            //        else if (yas < 58 || yas > 0)
            //            if (gun >= 5600)
            //            {
            //                Console.WriteLine($"Tebrikler! Emekli oldunuz. Güncel ikramiye tutarınız{maas * 11}");
            //            }
            //            else if (gun < 5600)
            //            { 
            //                Console.WriteLine("Üzgünüz, prim gün sayısı nedeniyle emeklilik hakkınız bulunmamaktadır.");
            //            }

            //                break;

            //    default:
            //        Console.WriteLine("Hatalı giriş yapıldı!");
            //    break;    

            //}
            #endregion
            #region Ödev

            //Kullanıcıya 5 hak tanımlayacağız kullanıcı random oluşturulan sayıyı bu 5 hak ile arayacakk eğer 
            //hak kısmı dolmadan bilirse tebrikler deyip random sayıyı göstereceğiz 
            //eğer kullanıcı 5 hakkı dolarsa hakkınız doldu deyip random sayıyı göstereceğiz
            //kullanıcı 1 ila 100 arasında sayıyı tahmin etmeye çalışacak
            //Örneğin oluşturulan random sayı değeri 50 kullanıcı 25 girdi girdiğiniz sayı oluşturulan sayıdan küçüktür
            // uyarısı verilip kullanıcı yönlendirilecek  kullanıcı 75 girdi girilen sayı büyüktür deyip yönlendirilecek
            //eğer sayılar birbirine eşitse şanslı sayıyı buldunuz diyecek ve 5 hakta bu işlemi yapacak.
            int hak = 5;
        git:
            Console.WriteLine("Bir sayı tahmin ediniz!");
            int tahmin = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(hak);
                hak--;
                Random a = new Random();
                int sans = a.Next(1, 101);
                if (hak > 0)
                {

                    if (tahmin >= 0 && tahmin <= 100)
                    {

                        if (sans != tahmin)
                        {
                            if (tahmin < sans)
                            {

                                Console.WriteLine($"Üzgünüm bilemediniz, tahmin ettiğiniz sayı: {tahmin}\nŞanslı sayı: {sans}\n{tahmin}<{sans} ev ve kalan hakkınız {hak}");
                            }
                            else if (tahmin > sans)
                            {

                                Console.WriteLine($"Üzgünüm bilemediniz, tahmin ettiğiniz  sayı: {tahmin}\nŞanslı sayı: {sans}\n{sans}<{tahmin} ev ve kalan hakkınız {hak}");
                            }
                            goto git;

                        }


                        else if (tahmin == sans)
                        {
                            Console.WriteLine("Tebrikleri bildiniz!Doğru sayı:" + sans);
                        }

                    }
                    else { Console.WriteLine("Hatalı giriş yaptınız!"); }
                    
                }
                else if(hak==0)
                {
                    Console.WriteLine("Hakkınız kalmamıştır!");
                }
            } while (hak == 0);

            #endregion

        }
    }
}
