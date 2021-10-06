using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm kusib kasutajal sisestada eesnimi ja perekonnanime
            //Programm tervitab kasutajat kasutades tema initsiaale
            //initsiaalid lopetavad punktiga
            //--> Harry Potter --> H. P.

            Console.WriteLine("Sisesta eesnimi!");
            string Eesnimi = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi!");
            string Perekonnanimi = Console.ReadLine();

            Console.WriteLine($"tere, {Eesnimi[0]}. {Perekonnanimi[0]}.!");
        }
    }
}
