namespace _10_Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sifre ekranı
            string sifre = "";
            do
            {
                Console.WriteLine("Şifreyi yazınız:");
                sifre = Console.ReadLine();
            }while (sifre != "1234");
            Console.WriteLine("Giriş yapıldı!");



            #endregion
        }
    }
}
