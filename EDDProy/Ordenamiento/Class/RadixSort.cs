using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Ordenamiento.Class
{
    internal class RadixSort
    {
        public void Ordenar(int[] arreglo)
        {
            int max = ObtenerMax(arreglo);

            
            for (int pos = 1; max / pos > 0; pos *= 10)
            {
                CountSort(arreglo, pos);
            }
        }

        private int ObtenerMax(int[] arreglo)
        {
            int max = arreglo[0];
            foreach (var num in arreglo)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        private void CountSort(int[] arreglo, int pos)
        {
            int n = arreglo.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            
            for (int i = 0; i < n; i++)
            {
                int digito = (arreglo[i] / pos) % 10;
                count[digito]++;
            }

            
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            
            for (int i = n - 1; i >= 0; i--)
            {
                int digito = (arreglo[i] / pos) % 10;
                output[count[digito] - 1] = arreglo[i];
                count[digito]--;
            }

            
            for (int i = 0; i < n; i++)
            {
                arreglo[i] = output[i];
            }
        }
    }
}

