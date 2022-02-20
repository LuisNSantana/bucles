using System;

namespace tabla1a5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int resul=0;
            Console.WriteLine("*** Bienvenidos a su tabla de multiplicar ***");
            for(int i = 1; i <=5; i++)
            {
                
                for (int j = 1; j<=10; j++)
                {
                     resul = i * j;
                    
                    Console.WriteLine(i + " * " + j + " = " + resul );
                   
                }
                Console.WriteLine("***********************");

            }
        }
    }
}
