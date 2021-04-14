using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Template
{
    public class DatoTipoImagen : ProcesadorDeDatos
    {
        public override void LeerDatos() { Console.WriteLine("Este metodo lee datos tipo imagen."); }
        public override void ProcesarDatos() { Console.WriteLine("Este metodo procesa datos tipo imagen."); }

    }
}
