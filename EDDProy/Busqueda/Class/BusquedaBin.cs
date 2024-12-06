using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Busqueda.Class
{
    internal class BusquedaBin
    {
        public int Buscar(int[] arreglo, int objetivo)
        {
            int izquierda = 0;
            int derecha = arreglo.Length - 1;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;

                if (arreglo[medio] == objetivo)
                    return medio;

                if (arreglo[medio] < objetivo)
                    izquierda = medio + 1;
                else
                    derecha = medio - 1;
            }

            return -1;
        }
    }

}
