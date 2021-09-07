using System;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja nime
            //programm tervitab kasutaja nimepidi
            Console.WriteLine("Mis su nimi on?");

            string UserName = Console.ReadLine();

            //Console.WriteLine("Hello, " + UserName);

            //string interpalotion

            Console.WriteLine($"Hello, {UserName}");

            Console.Read();
        }
    }
}
