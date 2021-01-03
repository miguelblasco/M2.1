using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase2
{
    class Program
    {
        static void Main(string[] args)
        {
            int YEAR = 1948; //ha de ser una constante
            int gap = 4; //cada 4 años es año bisiesto
            int leapYear = 0; //inicialización año bisiesto
            
            Console.WriteLine("introduce tu año de nacimiento: ");
            int birthYear=int.Parse(Console.ReadLine());

            
            while (birthYear > YEAR)
            {
                
                /*int a = */YEAR += gap;
                /*int b = */leapYear = leapYear + 1;
                
                //Console.WriteLine(a);
                //Console.WriteLine(b);
            }
            Console.WriteLine($"entre tu año de nacimiento y 1948 hay {leapYear} años bisiestos");









        }
    }
}
