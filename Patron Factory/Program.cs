using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2;
            Console.WriteLine("Provaremos el Patrón Factory con las funciones de una calculadora.");
            Console.WriteLine("Entra el primer numero; ");
            bool resultado = Double.TryParse(Console.ReadLine(), out numero1);
            if (!resultado) { Console.WriteLine("Por favor, entre un valor valido (numero): "); return; }

            Console.WriteLine("Entra el segundo numero; ");
            resultado = Double.TryParse(Console.ReadLine(), out numero2);
            if (!resultado) { Console.WriteLine("Por favor, entre un valor valido (numero): "); return; }

            Console.WriteLine("Que quiere hacer con estos dos numeros? (Escriba: Sumar, Restar, Multiplicar o Dividir)");
            //Aqui creamos un objeto de la clase que actuará como factoria, ella define cual objeto crear.
            Factoria_de_objetos Factoria = new Factoria_de_objetos();

            //Usando la interfaz definimos el tipo de operación y ejecutamos el metodo Calcular.
            ICalcular objeto = Factoria.Definir_Operación(Console.ReadLine());
            objeto.Calcular(numero1, numero2);
            

            Console.ReadLine();
        }
    }
}
