using System;

namespace numEmpleados
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int horaDia = 0;
            byte mes = 30;
            //int cont;
            Console.WriteLine("Cuanto cobras la hora: ");
            double valorHora = Convert.ToDouble(Console.ReadLine());
            double resultado = 0;
            for (int i = 0; i < 6; i++)
            {
                switch (i) {
                    case 0:
                        {
                            Console.WriteLine("Ingrese horas trabajadas lunes: ");
                            horaDia = horaDia + Convert.ToInt32(Console.ReadLine());
                        }break;

                    case 1:
                        {
                            Console.WriteLine("Ingrese horas trabajadas martes: ");
                            horaDia = horaDia + Convert.ToInt32(Console.ReadLine());
                        }break;

                    case 2:
                        {
                            Console.WriteLine("Ingrese horas trabajadas miercoles: ");
                            horaDia = horaDia + Convert.ToInt32(Console.ReadLine());
                        }break;

                    case 3:
                        {
                            Console.WriteLine("Ingrese horas trabajadas jueves: ");
                            horaDia = horaDia + Convert.ToInt32(Console.ReadLine());
                        }break;

                    case 4:
                        {
                            Console.WriteLine("Ingrese horas trabajadas viernes: ");
                            horaDia = horaDia + Convert.ToInt32(Console.ReadLine());
                        }break;

                    case 5:
                        {
                            Console.WriteLine("Ingrese horas trabajadas sabados: ");
                            horaDia = horaDia + Convert.ToInt32(Console.ReadLine());
                        }break;
                    default:
                        {
                            Console.WriteLine("******ERROR************");
                        }
                        break;

                        

            }
            }

            resultado = horaDia * valorHora;


            Console.WriteLine("Las horas trabajadas en total durante la semana: " + horaDia);

            Console.WriteLine("Debera pagarle durante la semana: " + resultado + " euros ");

            Console.WriteLine("Debera pagarle durante el mes: " + resultado * 4);




        }
    }
}
