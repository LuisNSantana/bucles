using System;

namespace intervarlos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num;
            int limiteSup;
            int suma=0;
            int cont = 0;
            int media;
            int numFuera = 0;
            Console.WriteLine("Ingresa intervarlo superior: ");
            limiteSup = Convert.ToInt32(Console.ReadLine());
            int limiteInf;
            Console.WriteLine("Ingresa intervarlo inferior: ");
            limiteInf = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Ingresa un numero: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num <=limiteSup && num > limiteInf)
                {
                    suma += num;
                    
                }

                
                

            } while (num != 0);

            
            media = suma / cont;
            Console.WriteLine(" \nLa suma es: " + suma + "\n la media es: " + media);


        }
    }
}
