using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Template
{
    public abstract class ProcesadorDeDatos
    {
        //Esta clase funciona como el esqueleto que otras clases usaran para implementar dos metodos abstractos a su manera.

        public void ProcesarLeerGuardar()
        {
            LeerDatos();
            ProcesarDatos();
            GuardarDatos();
        }

        public abstract void LeerDatos();
        public abstract void ProcesarDatos();

        public void GuardarDatos()
        {
            Console.WriteLine("Este metodo guarda los datos en la base de datos.");
        }
    }
}
