using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
   
        class NodoDos

        {
            private int dato;

            private NodoDos siguiente;
            private NodoDos atras;

            public int Dato
            {
                get { return dato; }
                set { dato = value; }
            }

            public NodoDos Siguiente
            {
                get { return siguiente; }
                set { siguiente = value; }
            }

            public NodoDos Atras
            {
                get { return atras; }
                set { atras = value; }
            }

        }
    }

