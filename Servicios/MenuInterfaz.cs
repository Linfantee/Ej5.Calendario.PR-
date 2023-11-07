using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5.Calendario.PR.Servicios
{
    internal interface MenuInterfaz
    {
        public int mes();
        /// <summary>
        /// Método que pide un mes en formato de número al usuario
        /// 061123 - lig
        /// </summary>
        /// <returns></returns>
        public int año();
        /// <summary>
        /// Método que pide un año en formato de número al usuario
        /// 061123 - lig
        /// </summary>
        /// <returns></returns>
        public string repetir();
        /// <summary>
        /// Método que pide si quiere volver al programa (s) o salir (n) al usuario
        /// 061123 - lig
        /// </summary>
        /// <returns></returns>
    }
}
