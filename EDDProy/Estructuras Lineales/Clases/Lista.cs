using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class Lista
    {
        public Nodo Inicio;

        public Nodo Final(Nodo nodo)
        {
            if (nodo.Siguiente == null)
            {
                return nodo;
            }
            else
            {
                return Final(nodo.Siguiente);
            }
        }
        public void AInicio(Nodo nodo)
        {
            if (Inicio == null)
            {
                Inicio = nodo;
            }
            else
            {
                Nodo aux = Inicio;
                Inicio = nodo;
                Inicio.Siguiente = aux;
            }
        }

        public void AFinal(Nodo nodo)
        {
            if (Inicio == null)
            {
                Inicio = nodo;
            }
            else
            {
                Nodo aux = Final(Inicio);
                aux.Siguiente = nodo;

            }
        }

        public void Eliminar(string dato)
        {
            if (Inicio == null) return;

            if (Inicio.Dato == dato)
            {
                Inicio = Inicio.Siguiente;
                return;
            }

            Nodo actual = Inicio;
            while (actual.Siguiente != null)
            {
                if (actual.Siguiente.Dato == dato)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    return;
                }
                actual = actual.Siguiente;
            }
        }
    }
}

