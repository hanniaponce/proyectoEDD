using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    class Cola
    {
        NodoCinco inicio;


        public void Encolar(NodoCinco nodoF)
        {
            if (inicio == null)
            {
                inicio = nodoF;
            }
            else
            {
                NodoCinco auxiliar = BuscarUltimo(inicio);
                auxiliar.Siguiente = nodoF;
            }
        }

        private NodoCinco BuscarUltimo(NodoCinco nodoF)
        {
            if (nodoF.Siguiente == null)
            {
                return nodoF;

            }
            else
            {
                return BuscarUltimo(nodoF.Siguiente);
            }
        }

        public void Desencolar()
        {
            inicio = inicio.Siguiente;
        }

        public NodoCinco Inicio
        {
            get
            {
                return inicio;
            }

        }
        public bool Vaciar()
        {
            return (inicio == null);
        }
    }

}

