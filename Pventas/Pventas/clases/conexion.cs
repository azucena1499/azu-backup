using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pventas.clases
{
    class Conexion
    {
        public string Conn()
        {
            //Defino  la cadena de conexion para para uso en el proyecto pventa
            string miconexion = ("Data Source=DESKTOP-U4S9UO5;Initial Catalog=pventa1;Integrated Security=True");
            return miconexion;
        }
    }
}
