using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton permite que solo se pueda crear una instancia de un objeto de una clase.\n ");
            //SIN SINGLETON
            Console.WriteLine("Veamos un ejemplo creando dos objetos y llamando sus codigos, de una clase sin SIN SINGLETON;");
            DePrueba objeto1 = new DePrueba();
            DePrueba objeto2 = new DePrueba();
            Console.WriteLine("El codigo del objeto uno es; " + objeto1.GetHashCode());
            Console.WriteLine("El codigo del objeto dos es; " + objeto2.GetHashCode());

            //CON SINGLETON
            Console.WriteLine("Ahora creemos dos objetos de otra clase con SINGLETON");

            Singleton objetoA = Singleton.Instancia_actual;
            Singleton objetoB =Singleton.Instancia_actual;
            Console.WriteLine("El codigo del objeto A es; " + objetoA.GetHashCode());
            Console.WriteLine("El codigo del objeto B es; " + objetoB.GetHashCode());

            Console.ReadLine();
        }



        //Solo para propositos de ejemplo.
        class DePrueba {  }
    }
}
