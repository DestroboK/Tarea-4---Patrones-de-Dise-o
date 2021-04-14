using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Factory
{
    class Factoria_de_objetos
    {
        //Aquí vamos a crear un objeto en base a la entrada del usuario en el programa principal.
        //Cuplimos con el patrón Factory porque dejamos todo el trabajo de la creación de objetos para esta clase.
        
        public ICalcular Definir_Operación(string Tipo_Operación)
        {
            ICalcular ObjetoDeLaFactoria = null;

            //Dependiendo del string que mande el usuario creamos un objeto de estas 4 clases, llamando su metodo constructor.
            if(Tipo_Operación.ToLower() == "sumar") { ObjetoDeLaFactoria = new Sumar();  }
            else if (Tipo_Operación.ToLower() == "restar") { ObjetoDeLaFactoria = new Restar(); }
            else if (Tipo_Operación.ToLower() == "multiplicar") { ObjetoDeLaFactoria = new Multiplicar(); }
            else if (Tipo_Operación.ToLower() == "dividir") { ObjetoDeLaFactoria = new Dividir(); }
            else { Console.WriteLine("Operación no valida / error ortografico."); }

            return ObjetoDeLaFactoria;
        }
    }
}
