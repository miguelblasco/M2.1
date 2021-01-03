using System;


namespace Fase1 // vídeo n°5 -> concatenación strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 11;
            int month = 10;
            int year = 1977;
            Console.WriteLine($"{day}/{month}/{year}");

            string name = "Miguel";
            string surname1 = "Blasco";
            string surname2 = "Gonzalez";
            Console.WriteLine($"{surname1} {surname2} {name}");
        }
    }
}