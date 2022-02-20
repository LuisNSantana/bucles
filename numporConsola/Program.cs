using System;

namespace numporConsola
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cuantos numeros desea introducir: ");
            int numUsuario = Convert.ToInt32(Console.ReadLine());
            int num = 0;
            int cont = 0;
            int numMayoresCero = 0;
            int numMenoresCero = 0;
            int numIgualCero = 0;
            do {
                Console.WriteLine("Ingresa un numero: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num > 0)

                {
                    numMayoresCero++;
                    
                }
                else if (num < 0)
                {
                    numMenoresCero++;

                }
                else
                {
                    numIgualCero++;
                }
                cont++;
            }
            while (cont < numUsuario);

            Console.WriteLine("Numeros mayores a 0: " + numMayoresCero);
            Console.WriteLine("Numeros menores a 0: " + numMenoresCero);
            Console.WriteLine("Numeros iguales a 0: " + numIgualCero);




        }
    }
}
