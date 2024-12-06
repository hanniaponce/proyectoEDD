using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    class Pila
    {

        NodoCuatro arriba;

        public NodoCuatro Arriba()
        {
            return arriba;
        }

        public void Apilar(NodoCuatro nodoC)
        {
            if (arriba == null)
            {
                arriba = nodoC;
            }
            else
            {
                NodoCuatro auxiliar = arriba;
                arriba = nodoC;
                arriba.Siguiente = auxiliar;
            }

        }

        public void Desapilar()
        {

            if (arriba != null)
            {
                arriba = arriba.Siguiente;
            }

        }

    }
}

