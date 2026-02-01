namespace _9_3_Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 10 ile 20 arasındaki sayıları FOR ile yazma
            for (int i=10;i<=20; i++)
            {
                Console.WriteLine(i);
            }
            #endregion
            #region  10 ile 20 arasındaki sayıları WHİLE ile yazma
            int a = 10;
            while(a<=20)
            {
                Console.WriteLine(a);
                a++;
            }
            #endregion
        }
    }
}
