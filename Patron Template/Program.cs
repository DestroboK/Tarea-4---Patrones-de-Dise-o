using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            //La plantilla template permite crear un "esqueleto" del programa que puede ser representado con una
            //clase abstracta. La clase "ProcesadorDeDatos" funciona como un template que las clases "DatoTipoImagen"
            //y "DatoTipoTexto" utilizan para sobreescribir la parte de "Leer" y "Procesar", mientras que la parte de
            //"guardar la hace la clase abstracta directamente.

            DatoTipoImagen objeto1 = new DatoTipoImagen();
            objeto1.ProcesarLeerGuardar();

            DatoTipoTexto objeto2 = new DatoTipoTexto();
            objeto2.ProcesarLeerGuardar();

            Console.ReadLine();
        }
    }
}
