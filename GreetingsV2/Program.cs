using System;

namespace GreetingsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja eesnime
            //programm küsib kasutaja perekonnanime
            //programm tervitab kasutaja, kasutades neid andmeid

            Console.WriteLine("Mis on su nimi?");
            string UserName = Console.ReadLine();
            Console.WriteLine("Mis on su perekonnanimi?");
            string LastName = Console.ReadLine();
            Console.WriteLine($"Hello {UserName} {LastName}");
            Console.ReadLine();

        }
    }
}
