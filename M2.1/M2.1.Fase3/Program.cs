using System;


namespace bis2
{
    class Program
    {
        static void Main(string[] args)
        {
            int YEAR=1948; 
            int gap = 4; //cada 4 años es año bisiesto
            int leapYear = 0; //inicialización año bisiesto
            int birthYear = 0;
            bool esBisiesto;
            string loEs = "Tu año de nacimiento es bisiesto";
            string noLoEs = "Tu año de nacimiento no es bisiesto";


                Console.WriteLine("Introduce tu año de nacimiento: \n ");
           
                birthYear = int.Parse(Console.ReadLine());



            if (birthYear >= YEAR) //if para garantizar que birthYear sea mayor que YEAR
            {

                for (int i = YEAR; i <= birthYear; i += gap)
                {
                    leapYear = leapYear + 1;


                    Console.WriteLine(YEAR);
                    YEAR = YEAR + gap;


                }

                YEAR = YEAR - (leapYear * 4); //para que YEAR vuelva a ser 1948
                Console.WriteLine($"Entre tu año de nacimiento {birthYear} y {YEAR} hay {leapYear} años bisiestos \n");

                esBisiesto = (birthYear % gap) == 0;
                
                
                if (esBisiesto) Console.WriteLine($"{esBisiesto}: {loEs}");

                
                else Console.WriteLine($"{esBisiesto}: {noLoEs}");

            }
            else Console.WriteLine("Incorrecto: el año debe ser >= 1948");

        }
    }
}