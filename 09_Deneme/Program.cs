using System.Linq.Expressions;

namespace _09_Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Try Catch Konu Tekrarı

            try
            {
                Console.WriteLine("x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y: ");
                int y = Convert.ToInt32(Console.ReadLine());

                int sonuc = x / y;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Sayı sıfıra bölünemez!" +e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Geçersiz karakter girdiniz!");
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Girdiğiniz sayı çok büyük veya çok küçük");
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu!" + ex.Message);
            }

            finally
            {
                Console.WriteLine("Programın çıkış kapıdır! Temizlik/kapama işlemleri burada yapılır!");
            }
            Console.WriteLine("Hata alsa da devam eder!");




            #endregion
        }
    }
}
