using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;


        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }

        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);

                //cambio 2

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);
        }
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);

            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
        }

        public bool BuscarNodo(int Dato, NodoBinario Nodo)
        {
            if (Nodo == null) return false;
            if (Nodo.Dato == Dato) return true;


            if (Dato < Nodo.Dato)
                return BuscarNodo(Dato, Nodo.Izq);
            else
                return BuscarNodo(Dato, Nodo.Der);
        }

        //podar arbol
        public void PodarArbol(int Dato, ref NodoBinario Nodo)
        {
            if (Nodo == null) return;

            PodarArbol(Dato, ref Nodo.Izq);
            PodarArbol(Dato, ref Nodo.Der);

            if (Nodo.Dato == Dato)
            {
                Nodo = null;

            }


        }
        //eliminar predecesor
        public NodoBinario BuscarMayor(NodoBinario Nodo)
        {
            while (Nodo != null)
            {
                Nodo = Nodo.Der;
            }
            return Nodo;
        }
        public void EliminarPredecesor(int Dato, ref NodoBinario Nodo)
        {
            if (Nodo == null)
                return;

            else if (Dato < Nodo.Dato)
                EliminarPredecesor(Dato, ref Nodo.Izq);

            else if (Dato > Nodo.Dato)
                EliminarPredecesor(Dato, ref Nodo.Der);

            else if (Nodo.Izq != null && Nodo.Der != null)
            {
                NodoBinario mayor = BuscarMayor(Nodo.Izq);
                Nodo.Dato = mayor.Dato;
                EliminarPredecesor(mayor.Dato, ref Nodo.Izq);
            }
            else
            {
                NodoBinario temp = Nodo;
                if (Nodo.Izq == null)
                    Nodo = Nodo.Der;
                else if (Nodo.Der == null)
                    Nodo = Nodo.Izq;
            }
        }

        //eliminar sucesor
        public NodoBinario BuscarMenor(NodoBinario Nodo)
        {
            while (Nodo != null)
            {
                Nodo = Nodo.Izq;
            }
            return Nodo;
        }
        public void EliminarSucesor(int Dato, ref NodoBinario Nodo)
        {
            if (Nodo == null)
                return;

            else if (Dato < Nodo.Dato)
                EliminarPredecesor(Dato, ref Nodo.Izq);

            else if (Dato > Nodo.Dato)
                EliminarPredecesor(Dato, ref Nodo.Der);

            else if (Nodo.Izq != null && Nodo.Der != null)
            {
                NodoBinario menor = BuscarMenor(Nodo.Der);
                Nodo.Dato = menor.Dato;
                EliminarPredecesor(menor.Dato, ref Nodo.Der);
            }
            else
            {
                NodoBinario temp = Nodo;
                if (Nodo.Izq == null)
                    Nodo = Nodo.Der;
                else if (Nodo.Der == null)
                    Nodo = Nodo.Izq;
            }
        }

        //altura 
        public int Altura(NodoBinario Nodo)
        {
            if (Nodo == null)
                return 0;

            return 1 + Math.Max(Altura(Nodo.Izq), Altura(Nodo.Der));
        }

        //contar hojas
        public int ContarHojas(NodoBinario Nodo)
        {
            if (Nodo == null)
                return 0;

            if (Nodo.Izq == null && Nodo.Der == null)
                return 1;
            else
                return ContarHojas(Nodo.Izq) + ContarHojas(Nodo.Der);
        }

        //contar nodos
        public int ContarNodos(NodoBinario Nodo)
        {
            if (Nodo == null)
                return 0;

            if (Nodo.Izq == null && Nodo.Der == null)
                return 1;
            else
                return ContarNodos(Nodo.Izq) + ContarNodos(Nodo.Der);
        }

        //niveles
        public void RecorridoNiveles(NodoBinario Nodo)
        {
            if (Nodo == null)
                return;

            Queue<NodoBinario> colaAuxiliar = new Queue<NodoBinario>();
            colaAuxiliar.Enqueue(Nodo);

            while (colaAuxiliar.Count > 0)
            {
                NodoBinario nodoAuxiliar = colaAuxiliar.Dequeue();
                Console.Write(nodoAuxiliar.Dato + "-");

                if (nodoAuxiliar.Izq != null)
                    colaAuxiliar.Enqueue(nodoAuxiliar.Izq);
                if (nodoAuxiliar.Der != null)
                    colaAuxiliar.Enqueue(nodoAuxiliar.Der);
            }

        }

        //arbol lleno
        public bool ArbolLleno(NodoBinario Nodo)
        {
            if (Nodo == null)
                return true;

            if (Nodo.Izq == null && Nodo.Der == null)
                return true;

            if (Nodo.Izq != null && Nodo.Der != null)
                return ArbolLleno(Nodo.Izq) && ArbolLleno(Nodo.Der);

            return false;
        }

        //arbol completo
        public bool ArbolCompleto(NodoBinario Nodo)
        {
            if (Nodo == null)
                return true;

            Queue<NodoBinario> colaAuxiliar = new Queue<NodoBinario>();
            colaAuxiliar.Enqueue(Nodo);
            bool nodoNoLleno = false;

            while (colaAuxiliar.Count > 0)
            {
                NodoBinario nodoAuxiliar = colaAuxiliar.Dequeue();


                if (nodoAuxiliar.Izq != null)
                {
                    if (nodoNoLleno)
                        return false;

                    colaAuxiliar.Enqueue(nodoAuxiliar.Izq);
                }
                else
                {
                    nodoNoLleno = true;
                }

                if (nodoAuxiliar.Der != null)
                {
                    if (nodoNoLleno)
                        return false;

                    colaAuxiliar.Enqueue(nodoAuxiliar.Der);
                }
                else
                {
                    nodoNoLleno = true;
                }
            }

            return true;
        }

    }
}
