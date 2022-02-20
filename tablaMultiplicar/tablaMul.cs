using System;

namespace tablaMultiplicar
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero para ver su tabla : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int resultado;
            Console.WriteLine("*****************************");
            

            for (int i = 1; i <= 10; i++)
            {
                resultado = num1 * i;
                
                Console.WriteLine(num1 + " * " + i + " = " + resultado);
                
            }
            Console.WriteLine("*******************************");
        }
    }
}
