using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Ordenamiento.Class
{
    internal class QuickSort
    {
        public void Ordenar(List<int> lista)
        {
            QuickSortRecursive(lista, 0, lista.Count - 1);
        }

        private void QuickSortRecursive(List<int> lista, int l, int h)
        {
            if (l < h)
            {
                int p = Particionar(lista, l, h);
                QuickSortRecursive(lista, l, p - 1);
                QuickSortRecursive(lista, p + 1, h);
            }
        }

        
        private int Particionar(List<int> lista, int l, int h)
        {
            int pivote = lista[h];
            int primerAlto = l;

            for (int i = l; i < h; i++)
            {
                if (lista[i] < pivote)
                {
                    Intercambiar(lista, i, primerAlto);
                    primerAlto++;
                }
            }

           
            Intercambiar(lista, primerAlto, h);
            return primerAlto;
        }

        
        private void Intercambiar(List<int> lista, int i, int j)
        {
            int temp = lista[i];
            lista[i] = lista[j];
            lista[j] = temp;
        }
    }
}
