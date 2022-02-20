using System;

namespace kmEncontrados
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int user1 = 70;
            int user2 = 150;
            int cont = 70;
            bool encontrado;


            while(user1  != user2){

                user1++;
                user2--;

                if (user1 == user2)
                {
                    
                    encontrado = true;
                    Console.WriteLine(user1);
                        

                }

            }

            

        }
    }
}
