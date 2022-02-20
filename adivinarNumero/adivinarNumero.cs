using System;

namespace adivinarNumero
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Adivina un numero del 1 al 100");
            Random rand = new Random();
            int a = rand.Next(1, 100);
            int cont = 0;
            int num;
            Console.WriteLine(a);
            bool noEncontrado = true;
            
           
                
            while (cont <= 10 && noEncontrado)
            {
                Console.WriteLine("Ingresa un numero: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num > a)
                {
                    Console.WriteLine("Tu numero es mayor, llevas " + cont + " intentos");
                   
                }else if (num < a)
                {
                    Console.WriteLine("tu numero es menor, llevas " + cont + " intentos");
                }else if (num == a)
                {
                    Console.WriteLine("ADIVINASTEEE!!! el numero es: " + a + " Lo haz conseguido en " + cont
                        + " intentos");
                    noEncontrado = false;
                }else
                {
                    Console.WriteLine("No lo haz conseguido, el numero era: " + a);
                }
                cont++;



               


            }
        }
    }
}
