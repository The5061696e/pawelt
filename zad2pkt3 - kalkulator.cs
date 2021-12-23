using System;
// l oznacza liczba
namespace zadanie_drugie_punkt_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wpisz mnożnę");
            int l1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wpisz mnożnik");
            int l2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Twój wynik mnożenia");
            Console.WriteLine(l1 * l2);
        }
    }
}
