using System;

namespace vocales
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char vocal;

            do
            {
                Console.WriteLine("Introduce una vocal: ");
                vocal = Convert.ToChar(Console.ReadLine());

                if      (vocal == 'a') Console.WriteLine("Vocal");
                else if (vocal == 'e')Console.WriteLine("Vocal");
                else if (vocal == 'i')Console.WriteLine("Vocal");
                else if (vocal == 'o')Console.WriteLine("Vocal");
                else if (vocal == 'u')Console.WriteLine("vocal");
                else Console.WriteLine("No es vocal");

                

            } while (vocal != ' ');
        }
    }
}
