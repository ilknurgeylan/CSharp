namespace _1_DenemeGiriş
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Deneme 1
            //Console.WriteLine("Bir sayı yazmalısınız.");
            //int ilkSayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci bir sayı yazmalısınız.");
            //int ikinciSayi = Convert.ToInt32(Console.ReadLine());
            //int toplamSayi = ilkSayi + ikinciSayi;
            //int ilksayibolumu = ilkSayi / ikinciSayi;
            //int cikarma = ilkSayi - ikinciSayi;
            //int carpma = ilkSayi * ikinciSayi;
            //Console.WriteLine($"Yazılan iki sayının toplam : {toplamSayi}");
            //Console.WriteLine("İlk sayı ikinci sayıya bölündüğünde çıksan sayı:" + ilksayibolumu);
            //Console.WriteLine($"Çıkarma sonucu:" + cikarma);
            //Console.WriteLine("Çarpma sonucu:" + carpma);
            #endregion
            #region Deneme 2

            //Console.WriteLine("Kullanıcı adınızı giriniz:");
            //string kullaniciAdi=Console.ReadLine();
            //Console.WriteLine("Parola yazınız:");
            //string parola=Console.ReadLine();
            //if (kullaniciAdi == "admin" && parola =="1234")
            //{
            //    Console.WriteLine("Giriş başarılıdır!");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş yaptınız!");
            //}
            #endregion
            #region Deneme 3
            //Kullanıcının girdiği değeri önce 0 dan büyük mü kontrol edelim eğer sıfırdan büyükse 100 den büyük mü küçük mu kontrol edelim
            //Console.WriteLine("Bir sayı giriniz.");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 0)
            //{
            //    if (sayi < 100)
            //    {
            //        Console.WriteLine("100'den küçük bir sayı girdiniz:" +sayi);
            //    }
            //    else if (sayi>100)
            //    {
            //        Console.WriteLine("100'den büyük bir sayı girdiniz:" + sayi);
            //    }
            //    else
            //    {
            //        Console.WriteLine("100 sayısını girdiniz:" + sayi);
            //    }
            //}
            //else if(sayi==0)
            //{
            //    Console.WriteLine("Girdiğiniz değer:" + sayi);
            //}
            //else if(sayi<0)
            //    if (sayi>-100)
            //    {
            //        Console.WriteLine($"-100 den büyük bir değer girdiniz:{sayi}");
            //    }
            //    else if(sayi<-100)
            //    {
            //        Console.WriteLine($"-100 den küçük bir değer girdiniz:{sayi}");
            //    }
            //else
            //    {
            //        Console.WriteLine("Girdiğiniz değer:" + sayi);
            //    }
            #endregion
            #region Deneme 4
            //Kullanıcının girdiği değeri kontrol edelim tek mi çift mi olduğunu ekrana yazdıralım
            //Console.WriteLine("Bir sayı giriniz.");
            //double deger=Convert.ToDouble(Console.ReadLine());
            //if (deger % 2 == 0 & deger>0)
            //{
            //    Console.WriteLine("Çift sayı girdiniz."+deger);
            //}
            //else if(deger % 2 == 1&deger>0)
            //{
            //    Console.WriteLine("Tek sayı girdiniz."+deger);
            //}
            //else if(deger==0)
            //{
            //    Console.WriteLine("0 Değerini girdiniz");
            //}
            //else if (deger<0)
            //{
            //    Console.WriteLine("Pozitif değer giriniz.");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz ibare girdiniz.");
            //}

            #endregion
            #region Dehneme 5
            //Kullanıcıya bir soru soracağız haftanın kaçıncı günü diye kullanıcı eğer 1 girerse pazartesi 2 salı gibi if else blokları ile değeri ekrana yazdıracağız
            //kullanıcı 0'dan küçük ve 0 girerse  veya 7 den büyük bir değer girerse ekrana bir uyarı vereceğiz.
            //Console.Write("Haftanın kaçıncı gününde olduğunuzu belirtin:");
            //int gun=Convert.ToInt32(Console.ReadLine());
            //if (gun>0 & gun<8)
            //{
            //    if (gun == 1)
            //    {
            //        Console.WriteLine(gun + ".gün Pazartesi.");
            //    }
            //    else if (gun == 2)
            //    {
            //        Console.WriteLine(gun + ".gün Salı.");
            //    }
            //    else if (gun == 3)
            //    {
            //        Console.WriteLine(gun + ".gün Çarşamba.");
            //    }
            //    else if (gun == 4)
            //    {
            //        Console.WriteLine(gun + ".gün Perşembe.");
            //    }
            //    else if (gun == 5)
            //    {
            //        Console.WriteLine(gun + ".gün Cuma.");
            //    }
            //    else if (gun == 6)
            //    {
            //        Console.WriteLine(gun + ".gün Cumartesi.");
            //    }
            //    else if (gun == 7)
            //    {
            //        Console.WriteLine(gun + ".gün Pazar.");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Hatalı değer girdiniz.");
            //}
            #endregion
            #region Deneme 6
            //Kullanıcıdan değer alacağız kullanıcı pozitif bir değer girerse girdiği değeri göstereceğiz
            //kullanıcı negatif değer girerse girdiği değeri göstereceğiz
            //kullanıcı eğer '0' girerse pozitif veya negatif değer girin diye tekrardan soru yapısına yönlendireceğiz.
            //basla:
            //    Console.WriteLine("Bir sayı giriniz.");
            //    int sayi=Convert.ToInt32(Console.ReadLine());
            //    if (sayi < 0)
            //    {
            //        Console.WriteLine("Negatif bir sayı girdiniz:" + sayi);
            //    }
            //    else if(sayi==0)
            //    {
            //        Console.WriteLine("Pozitif ya da negatif bir sayı girmelisiniz");
            //        goto basla;
            //    }
            //    else if(sayi>0)
            //    {
            //        Console.WriteLine("Pozitif bir sayi girdiniz:" +sayi);
            //    }

            #endregion
        }
    }
}
