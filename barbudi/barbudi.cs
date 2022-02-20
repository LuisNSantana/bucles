using System;

namespace barbudi
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int jugadores;
            Random rand = new Random();
            int dado1;
            int dado2;
            bool ganar = false;

            do
            {
                Console.WriteLine("Ingrese el numero de jugadores: ");
                jugadores = Convert.ToInt32(Console.ReadLine());
                

                
            } while (jugadores < 0 && jugadores > 4);

              if(jugadores > 4 || jugadores < 0)
            {
                Console.WriteLine("NO SE PUEDE JUGAR MAX 4 JUGADORES");
            }
            else {

                while (jugadores > 0 && ganar == false)

                {
                    dado1 = rand.Next(1, 7);
                    dado2 = rand.Next(1, 7);

                    if (dado1 == 3 && dado2 == 3 || dado1 == 5 && dado2 == 5 || dado1 == 6 && dado2 == 6 || dado1 == 6 && dado2 == 5)
                    {
                        ganar = true;
                        Console.WriteLine("Haz ganado !!!");
                    }
                    else if (dado1 == 1 && dado2 == 2 || dado1 == 1 && dado2 == 1 || dado1 == 2 && dado2 == 2 || dado1 == 4 && dado2 == 4)
                    {
                        ganar = false;
                        Console.WriteLine("Haz perdido!!! :( ");
                        jugadores--;
                    }

                    Console.WriteLine(dado1 + " ------- " + dado2);
                }
            }
            }
        }

    }


