using System;

namespace ahorroAnual
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu sueldo anual: ");
            int sueldoAnual = Convert.ToInt32(Console.ReadLine());

            int cantDepositada = 0;
            int cont = 0;
            

            do
            {
                
                Console.WriteLine("Ingresa la cantidad a depositar: ");
                cantDepositada = cantDepositada + Convert.ToInt32(Console.ReadLine());

                

                cont++;
                switch (cont)
            {
                    case 1:
                        {
                            Console.WriteLine("Lo que llevas ahorrado en enero es: " + cantDepositada);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Lo que llevas ahorrado en febrero es: " + cantDepositada);
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Lo que llevas ahorrado en marzo es: " + cantDepositada);
                        }break;
                    case 4:
                        {
                            Console.WriteLine("Lo que llevas ahorrado en abril es: " + cantDepositada);
                        }break;
                    case 5:
                        {
                            Console.WriteLine("Lo que llevas ahorrado en mayo es: " + cantDepositada);
                        }break;
                    case 6:
                        {
                            Console.WriteLine("Lo que llevas ahorrado en junio es: " + cantDepositada);
                        } break;
                    case 7:
                        {
                            Console.WriteLine("Lo que llevas ahorrado en julio es: " + cantDepositada);
                        }break;

                    case 8:
                        {
                            Console.WriteLine("Lo que llevas ahorrado en agosto es: " + cantDepositada);
                        }break;

                    case 9:
                        {
                            Console.WriteLine("Lo que llevas ahorrado en septiembre es: " + cantDepositada);
                        }break;
                    case 10:
                        {
                            Console.WriteLine("Lo que llevas ahorrado en octubre es: " + cantDepositada);
                        }break;

                    case 11:
                        {
                            Console.WriteLine("Lo que llevas ahorrado en noviembre es: " + cantDepositada);
                        }break;

                    case 12:
                        {
                            Console.WriteLine("Lo que llevas ahorrado en diciembre es: " + cantDepositada);
                        }break;

                    default: 
                        {
                            Console.WriteLine("Ya ha superado el año");
                        }break;
                }

            } while (cont < 12);
            


            //Console.WriteLine("-------" + cantDepositada);

            

            //cantAhorradaMes = cantDepositada / 12;

            Console.WriteLine("Lo que haz ahorrado en el anho es: " + cantDepositada + " €");

            




            
        }
    }
}
