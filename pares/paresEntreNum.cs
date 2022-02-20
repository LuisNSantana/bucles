using System;

namespace pares
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("****** EL NUMERO 2 DEBE SER MAYOR QUE EL NUMERO 1 ****");
            Console.WriteLine("Ingresa un numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            

            for(int i = num1 +1 ; i < num2 ; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Los numeros pares entre los dos numeros ingresados: " + i);
                }
                
                
            }
        }
    }
}
