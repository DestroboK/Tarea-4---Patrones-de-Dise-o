using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Singleton
{
    class Singleton
    {
        private static Singleton instancia = new Singleton();
        private Singleton() { }

        public static Singleton Instancia_actual
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Singleton();
                }


                return instancia;
            }
        }
    }
}
