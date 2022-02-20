using System;

namespace producto20meses
{
    class MainClass
    {
        public static void Main(string[] args)
        {
             int mes = 10;

            int auxiliar = 0;
            int resultado;

            for(int i = 0; i<=20; i++)
            {
                //Console.WriteLine("------------------" + i);



                
                resultado = mes * auxiliar;
                auxiliar += 2;



                Console.WriteLine("MES "+i+" hay que pagar: "+resultado);
                


            }
            

           


        }
    }
}
