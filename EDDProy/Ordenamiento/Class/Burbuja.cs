using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Ordenamiento.Class
{
    internal class Burbuja
    {
        public void MetodoBurbuja(int[] arreglo)
        {
            int n = arreglo.Length;
            for (int i = 0; i < n - 1; i++)
            {
                
                bool huboIntercambio = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                        huboIntercambio = true;
                    }
                }
               
                if (!huboIntercambio)
                    break;
            }
        }
    }
}
