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
    internal class MenuImplementacion2 : MenuInterfaz2
    {
        public string añoBisiesto(int año)
        {

            string añoBisiesto;

            // Vemos si el año dado es bisiesto, para ello lo dividimos entre 4 si el resultado es 0 seguimos con el proceso si no es 0 el año no es bisiesto y ahi pararía el proceso.
            // Si el año dado ha podido dividirse entre 4 lo volveremos a dividir entre 100 e igual que antes si es 0 seguimos con el proceso y si no lo es el año no es bisiesto y pararíamos el proceso.
            // Por último lo dividiremos entre 400 para confirmar si es bisiesto y si el resultado es 0 el año elegido es bisiesto pero si no da 0 no lo seria y ya pararíamos el proceso de calculo.

            if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
            {
                Console.WriteLine("El año es bisiesto");
                añoBisiesto = "Y";
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
                añoBisiesto = "n";
            }
            return añoBisiesto;
        }
    }
}