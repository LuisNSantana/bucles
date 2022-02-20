using System;

namespace minuteroSegundero
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int j;
            bool power = true;
            int horas = 0;
            //mientras power sea true se va a ejecturar
            while (power)

            {   //esto
                for (int i = 0; i < 60; i++)
                {
                    //Console.WriteLine(i);

                    for (j = 1; j < 60; j++)
                    {
                        //Console.WriteLine(j);
                        Console.WriteLine(j + " minutos " + " : " + i + "segundos");
                    }

  

                }
                horas++;
                Console.WriteLine("Han pasado " + horas + " horas ");
                if (horas == 100)
                {
                    Console.WriteLine(" Nos han timado ");
                    power = false;

                }
                
                
               
            } 
            Console.WriteLine(" Hemos terminado ");
        }
    }
}
