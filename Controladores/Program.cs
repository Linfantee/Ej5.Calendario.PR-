using Ej5.Calendario.PR.Servicios;

namespace Ej5.Calendario.PR 
{ 
    /// <summary>
    /// Clase principal de la operación 
    /// 061123 - lig
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de la aplicación
        /// 061123 - lig
        /// </summary>
       
        static void Main(string[] args)
        {
            //Variables
            string resultado;
            string calculo = "";
            int mes, año;

            //Objetos
            MenuInterfaz aka = new MenuImplementacion();

            MenuInterfaz2 ao = new MenuImplementacion2();


            do 
            {
                mes = aka.mes();
                año = aka.año();
              

                switch (mes)
                {
                    case 1: case 3: case 5: case 7: case 8: case 10: case 12:

                        Console.WriteLine("El mes seleccionado tiene 31 días");
                         ao.añoBisiesto(año);
                        break;

                    case 2:
                        calculo = ao.añoBisiesto(año);
                        if (calculo == "Y")
                        {
                            Console.WriteLine("El mes seleccionado tiene 29 días.");
                            
                        }
                        else
                        {
                            Console.WriteLine("El mes seleccionado tiene 28 días.");
                           
                        }
                       
                        break;

                    case 4: case 6: case 9: case 11:

                        Console.WriteLine("El mes seleccionado tiene 30 días.");
                        ao.añoBisiesto(año);
                        break;

                    default:

                        Console.WriteLine("[AYUDA] - El número seleccionado no es posible utilizarlo, escoja un número del 1 al 12.");

                        break;
                }
                  resultado = aka.repetir();

            } while (resultado == "s");

        }
       
    }

}










