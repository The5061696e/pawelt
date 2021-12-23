using System;

namespace zadaniedrugie

{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int s1 = 1;
            Console.WriteLine("Silnia dla liczby 9 - ");
            for (int i = 1; i <= 9; i++)
            {
                s1 *= i;
                Console.WriteLine(s1);
            }
            double s2 = 1;
            Console.WriteLine("Silnia dla liczby 20 -");
            for (double i = 1; i <= 20; i++)
            {
                s2 *= i;
                Console.WriteLine(s2);
            }
              ulong s3 = 1;
              Console.WriteLine("Silnia dla liczby 243 - ");
              for (ulong i = 1; i <= 243; i++)
            {
                s3 *= i;
                Console.WriteLine(s3);
            }
        }
    }
}
