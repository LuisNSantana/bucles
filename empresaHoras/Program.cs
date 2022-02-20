using System;

namespace empresaHoras
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese dias trabajados en la semana: ");
            int dias = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese horas trabajadas en el dia: ");
            int horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero de empleados: ");
            int empleados = Convert.ToInt32(Console.ReadLine());
            int resultado;
            

            int precioHora = 8;
            int operacion = 0;
           
            for(int i = 0; i>dias; i++)
            {
                horas++;
                Console.WriteLine("------------"+horas);
            }

            operacion = horas * precioHora;
           
            
            //operacion *= 5;
            resultado = operacion * empleados;

            Console.WriteLine("Lo que debe pagar la empresa en la semana es: " + resultado);

            Console.WriteLine("Lo que se debe pagar a cada empleado en la semana es: " + resultado / empleados);


        }
    }
}
