using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5.Calendario.PR.Servicios
{
    /// <summary>
    /// Implementación de la interfaz, aquí tenemos toda la lógica de los métodos 
    /// 071123 - lig
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mes() 
        {
            int mes;
            Console.WriteLine("Introduzca un mes en formato de número: ");
            mes = Convert.ToInt32(Console.ReadLine());
            
            return mes; 
        }
        public int año()
        {
            int año;
            Console.WriteLine("Introduzca un año en formato de número: ");
            año = Convert.ToInt32(Console.ReadLine());

            return año;
        }
        public string repetir()
        {
            string repetir;
            Console.WriteLine("¿Desea seguir usando el calendario? Si es asi pulse [s], si desea salir pulse[n].");
            repetir = Console.ReadLine();
            return repetir;
        }
    }
}
