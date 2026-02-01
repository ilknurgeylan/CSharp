namespace _2_Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Deneme 1
            // Kullanıcıdan aylık geliri istenecek eğer geliri 40000 üstünde ise  %12 lik vergi kesilecek 
            // 40000 ve altında ise %9 luk vergi kesilecek yeni gelirini göstereceğiz
            //Console.Write("Aylık gelirinizi belirtiniz:");
            //double gelir=Convert.ToDouble(Console.ReadLine());
            //if(gelir>4000)
            //{
            //    Console.WriteLine("Yeni geliriniz:" + gelir * 0.88);
            //}
            //else if(gelir<4000 & gelir>0)
            //{
            //    Console.WriteLine("Yeni geliriniz:" + gelir * 0.91);
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz değer üzerinden hesaplama yapılamamaktadır.");
            //}


            #endregion
            #region Deneme 2
            //Kullanıcıdan iki ürünün fiyatını isteyin
            //Ürün fiyatlarının toplamı 2500 tl yi geçerse ucuz ürüne % 25 indirim uygulayalım
            //Eğer geçmezse ürün toplamlarını ekrana yazdıralım
            //Console.Write("Aldığınız ilk ürünün fiyatı:");
            //double urun1= Convert.ToDouble(Console.ReadLine()); 
            //Console.Write("Aldığınız ikinci ürünnün fiyatı:");
            //double urun2= Convert.ToDouble(Console.ReadLine());
            //double toplam = urun1 + urun2;
            //if(toplam>2500 & urun1<urun2 & urun1 > 0 & urun2 > 0)
            //{
            //    Console.WriteLine("Tebrikler! %25 indirim kazandınız. İndirimli tutarınız:"+(urun1*0.75+urun2)); 
            //}
            //else if(toplam>2500&urun1>urun2 & urun1 > 0 & urun2 > 0)
            //{
            //    Console.WriteLine("Tebrikler! %25 indirim kazandınız. İndirimli tutarınız:" + (urun2 * 0.75 + urun1));
            //}
            //else if(toplam>0&toplam<=2500)
            //{
            //    Console.Write("Toplam alışveriş tutarınız:" + toplam);
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz giriş yaptınız!");
            //}
            #endregion
            #region Deneme 3
            /* Kullanıcıdan harcadığı tutar istenilecek eğer kullanıcı 0 ila 1000 arasında harcama yaptıysa 0.35 ile çarpılacak
             * 1001-2500 0.38 üzerinden hesaplanacak
             * 2501-4000 arası 0.41
             * 4001-6000 arası 0.42
             * 6000 ve üstü 1200 tl indirim yapılıp 0.43 üzerinden işlem yapılacak 
             */
            //Console.Write("Lütfen alışveriş tutarınızı giriniz:");
            //double toplam=Convert.ToDouble(Console.ReadLine());
            //if (toplam <= 0)
            //{
            //    Console.WriteLine("Hatalı tutar girişi sağladınız!");
            //}
            //else if (toplam>0&toplam<=1000)
            //{
            //    Console.Write("Güncel indirimli tutarınız:" + toplam*0.65);
            //}
            //else if(toplam > 1000 & toplam <= 2500)
            //{
            //    Console.Write("Güncel indirimli tutarınız:" + toplam * 0.62);
            //}
            //else if(2500 > 0 & toplam <= 4000)
            //{
            //    Console.Write("Güncel indirimli tutarınız:" + toplam * 0.59);
            //}
            //else if(toplam > 4000 & toplam <= 6000)
            //{
            //    Console.Write("Güncel indirimli tutarınız:" + toplam * 0.58);
            //}
            //else if(toplam > 6000 )
            //{
            //    Console.Write("Güncel indirimli tutarınız:" + (toplam-1200) * 0.57);
            //}

            #endregion
            #region Deneme 4
            //    //1 ila 300 arasındaki sayıların 7 ye tam bölünenlerini ekrana teker teker yazdıran programı yazalım
            //    int a = 1;
            //    int top = 0;
            //b:
            //    if (a % 7 == 0)
            //    {
            //        Console.WriteLine(a);
            //        top += a;
            //    }
            //    a++;
            //    if (a<=300)
            //    {
            //        goto b;  
            //    }

            //    Console.WriteLine("1 ila 300 arasındaki sayıların 7 ye tam bölünenleri:"+top);


            #endregion
            #region Deneme 5
            //500 ila 1 arasındaki sayıların 5'e tam bölünenlerini ekrana teker teker yazdıran programı yazalım
            //int x = 500;
            //int total = 0;
            //i:
            //if (x % 5 == 0)
            //{
            //    Console.WriteLine(x);
            //    total += x;
            //}
            //x--;
            //if(x>=0)
            //{
            //    goto i;
            //}
            //Console.WriteLine("5'e bölünen tüm değerleri toplamı:"+total);
            #endregion
            #region Deneme 6
            /* Kullanıcıdan isim ,yaş , maaş  ve çocuk sayısı isteyeceğiz 
             * Eğer kullanıcı 45 yaşının altında ise çocuksayısına bakılacak
             * ve çocuk sayısı 3'ten az ise çocuk başına 2500₺ 
             * 3 ve 3'ten fazla ise çocuk başına 2000₺ maaşına ekleme yapılacak
             * 45 in üzerinde ise çocuk başına para verilmeyecek anca 10000₺ ekleme yapılacak 
             * Son olarak  ekranda çıktı : Erkan TÜRK Maaşınız 40000₺ gibi yazılacak.
             */

            //Console.Write("İsminiz : ");
            //string ad=Console.ReadLine();
            //Console.Write("Soyadınız : ");
            //string soyad = Console.ReadLine();
            //Console.Write("Yaşınız : ");
            //double yas=Convert.ToDouble(Console.ReadLine());
            //Console.Write("Aylık kazancınız : ");
            //double maas=Convert.ToDouble(Console.ReadLine());

            //if (yas <= 45 &&  yas>0 )
            //{
            //    Console.Write("Çocuk sayısı: ");
            //    int cocuk=Convert.ToInt32(Console.ReadLine());
            //    if (cocuk < 3&&cocuk>0)
            //    {
            //        Console.WriteLine(ad+"  "+soyad+ "  "+"yeni maaşınız"+"  "+ (maas+cocuk*2500));
            //    }
            //    else if (cocuk >= 3)
            //    {
            //        Console.WriteLine(ad + "  " + soyad + "  " + "yeni maaşınız" + "  " + (maas + cocuk *2000));
            //    }
            //}

            //else if(yas>45)
            //{
            //    Console.WriteLine(ad + "  " + soyad + "  " + "yeni maaşınız" + "  " + (maas + 10000));
            //}

            #endregion
        }
    }
}
