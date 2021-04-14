using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Factory
{
    public class Dividir : ICalcular
    {
        public void Calcular(double a, double b)
        {
            Console.WriteLine("a / b es igual a {0}", a / b);
        }
    }
}
