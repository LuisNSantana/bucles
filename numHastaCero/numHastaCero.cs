using System;

namespace numHastaCero
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*for (int i = 100; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
            }*/

            int num;
            int cont = 0;
            int suma = 0;
            int media;
            int numPositivos = 0;
            int numNegativos = 0;
            do
            {
                cont++;
                Console.WriteLine("Introduzca un numero: ");
                num = Convert.ToInt32(Console.ReadLine());

                suma += num;
                if (num > 0)
                {
                    numPositivos++;
                }
                else if (num < 0)
                {
                    numNegativos++;
                }
                else
                {
                    ;
                }

            } while (num != 0);

             media = suma / cont;

           



            Console.WriteLine("La suma de los numeros es: "+suma +
                "\n" + "La media es: " + media + "\n" + "numeros positivos: " + numPositivos
                + "\n" + "numeros negativos: " + numNegativos);

            
           
            
        }
    }
}
