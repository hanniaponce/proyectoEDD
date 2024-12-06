using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public class Circular
    {

        private NodoTres primero;

        public void Agregar(string valor)
        {
            NodoTres nodoTres = new NodoTres(valor);
            if (primero == null)
            {
                primero = nodoTres;
                nodoTres.Siguiente = primero;
            }
            else
            {
                NodoTres actual = primero;
                while (actual.Siguiente != primero)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nodoTres;
                nodoTres.Siguiente = primero;
            }
        }

        public void Eliminar(int posicion)
        {
            if (primero == null)
                return;
            if (posicion == 0)
            {
                if (primero.Siguiente == primero)
                {
                    primero = null;
                }
                else
                {
                    NodoTres actual = primero;
                    while (actual.Siguiente != primero)
                    {
                        actual = actual.Siguiente;
                    }

                    actual.Siguiente = primero.Siguiente;
                    primero = primero.Siguiente;

                }

                return;

            }

            NodoTres anterior = primero;
            NodoTres NodoNuevo = primero.Siguiente;
            for (int i = 1; i < posicion; i++)
            {
                if (NodoNuevo == primero) return;
                anterior = NodoNuevo;
                NodoNuevo = anterior.Siguiente;
            }

            if (NodoNuevo == primero) return;
            anterior.Siguiente = NodoNuevo.Siguiente;
        }

        public List<string> Datos()
        {
            List<string> Datos = new List<string>();
            if (primero == null)
                return Datos;

            NodoTres actual = primero;
            do
            {
                Datos.Add(actual.Dato);
                actual = actual.Siguiente;

            } while (actual != primero);
            return Datos;

        }

    }
}
