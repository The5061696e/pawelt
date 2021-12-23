using System;
// l oznacza liczbę, a z oznacza znak
namespace zadanie_drugie_punkt_3_podpunkt_a
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wpisz pierwszą liczbę");
            int l1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wpisz drugą liczbę");
            int l2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wpisz znak '+' aby wykonać dodawanie lub '-' aby odjąć");
            char z = Console.ReadLine()[0];


            if (z == '-') {

                Console.WriteLine(l1 - l2);

            }else if(z == '+')
            {
                Console.WriteLine(l1 + l2);
            }
            else
            {
                Console.WriteLine("Błąd. Wpisz prawidłowy znak.");
            }
        }
    }
}
