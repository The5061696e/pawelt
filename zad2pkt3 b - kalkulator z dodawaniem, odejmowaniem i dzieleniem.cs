using System;
// "l" oznacza liczbę, a "z" oznacza znak
namespace zadanie_drugie_punkt_3_podpunkt_b
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wpisz pierwszą liczbę");
            int l1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wpisz drugą liczbę");
            int l2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wpisz znak '+' aby wykonać dodawanie, '-' aby wykonać odejmowanie lub '*' by wykonać mnożenie");
            char z = Console.ReadLine()[0];

            switch (z)
            {
                case '+':

                    Console.WriteLine("Wynik");
                    Console.WriteLine(l1 + l2);
                    break;

                case '-':
                    Console.WriteLine("Wynik");
                    Console.WriteLine(l1 - l2);

                    break;

                case '*':
                    Console.WriteLine("Wynik");
                    Console.WriteLine(l1 * l2);
                    break;

                default:

                    Console.WriteLine("Błąd. Wpisz prawidłowy znak.");
                    break;
            }
        }
    }
}
