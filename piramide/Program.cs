using System;

namespace piramide
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string asterisco = "";
            string barra = "";

            for (int i = 0; i<=10; i++)
            {
                if (i % 2 == 0)
                {
                    asterisco += " *";
                    Console.WriteLine(asterisco);
                }
                else
                {
                    barra += " -";
                    Console.WriteLine(barra);
                }
                
            }
        }
    }
}
