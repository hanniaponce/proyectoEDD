using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public class NodoTres
    {
        public string Dato;
        public NodoTres Siguiente;

        public NodoTres(string dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
