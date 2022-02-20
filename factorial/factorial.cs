using System;

namespace factorial
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero que quiere saber el factorial: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            double factorial = 1;

            while (numero != 0)
            {
                factorial = factorial * numero;
                numero--;
            }
            Console.WriteLine(" El factorial es: " + factorial);
        }
    }
}
