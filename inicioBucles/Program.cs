using System;

namespace inicioBucles
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i<= num; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = num; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            int cont= 0;
            while (cont< num)
            {
                cont++;
                Console.WriteLine(cont);
            }

          
        }
    }
}
