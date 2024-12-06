using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class Doble
    {
        private NodoDos primero = new NodoDos();
        private NodoDos ultimo = new NodoDos();

        public Doble()
        {
            primero = null;
            ultimo = null;
        }

        public void Insertar(int valor)
        {
            NodoDos nodo = new NodoDos();
            nodo.Dato = valor;

            if (primero == null)
            {
                primero = nodo;
                primero.Siguiente = null;
                primero.Atras = null;
                ultimo = primero;
            }

            else
            {
                ultimo.Siguiente = nodo;
                nodo.Siguiente = null;
                nodo.Atras = ultimo;
                ultimo = nodo;
            }

        }

        public void IzquierdaD(TextBox lst)
        {
            NodoDos actual = new NodoDos();
            actual = primero;
            while (actual != null)
            {
                lst.Text += actual.Dato + "->";
                actual = actual.Siguiente;
            }
        }
        public void DerechaI(TextBox lst)
        {
            NodoDos actual = new NodoDos();
            actual = ultimo;
            while (actual != null)
            {
                lst.Text += actual.Dato + "->";
                actual = actual.Atras;
            }
        }

    }
}

