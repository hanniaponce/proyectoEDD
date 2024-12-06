using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Busqueda.Class
{
    public class Hash
    {
        private readonly int _tam; 
        private readonly LinkedList<KeyValuePair<int, string>>[] _tabla; 

        public Hash(int tam)
        {
            _tam = tam;
            _tabla = new LinkedList<KeyValuePair<int, string>>[tam];

            for (int i = 0; i < tam; i++)
            {
                _tabla[i] = new LinkedList<KeyValuePair<int, string>>();
            }
        }

        
        public void Insertar(int clave, string valor)
        {
            int index = HashFunction(clave);

            foreach (var pair in _tabla[index])
            {
                if (pair.Key == clave)
                {
                    throw new Exception("La clave ya existe en la tabla hash.");
                }
            }

            _tabla[index].AddLast(new KeyValuePair<int, string>(clave, valor));
        }

       
        public string Buscar(int clave)
        {
            int index = HashFunction(clave);

            foreach (var pair in _tabla[index])
            {
                if (pair.Key == clave)
                {
                    return pair.Value;
                }
            }

            return "No encontrado";
        }

        
        public void Limpiar()
        {
            for (int i = 0; i < _tam; i++)
            {
                _tabla[i].Clear();
            }
        }

        
        private int HashFunction(int clave)
        {
            return clave % _tam;
        }
    }
}
