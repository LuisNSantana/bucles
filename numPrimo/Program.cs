using System;

namespace numPrimo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Introduce un numero:");
            number = Convert.ToInt32(Console.ReadLine());
            if (EsPrimo(number))
            {
                Console.WriteLine("Es primo");
            }
            else
            {
                Console.WriteLine("No es primo");
            }

           
        }
        public static bool EsPrimo(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int raiz = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
