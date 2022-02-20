using System;

namespace doWhile
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string pass = "12345";
            string resp;
            //string user;
            int cont = 0;
            //La diferencia con el while es que el do while va desde 1 a N y el while de 0 a N
            do
            {
                cont++;
                Console.WriteLine("INTRODUZCA EL PASSWORD: ");
                resp = Console.ReadLine();
                Console.WriteLine("intentos: " + cont);




            } while (pass != resp && cont <= 5);
            
                if (pass == resp)
            {
                Console.WriteLine("Has ingresado");
            }else
            {
                
                Console.WriteLine("Bloqueado");
            }

              
            
               
               
                
            
        }
    }
}
