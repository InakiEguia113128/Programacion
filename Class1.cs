using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    class Pila : IColecction
    {
        public string[] Array { get; set; }
        private string Elemento { get; set; }
        public int contador { get; set; }

        public Pila(string elemento, int cantidad)
        {
            this.Elemento = elemento;
            this.Array = new string[cantidad];
        }
        public Pila()
        {
            this.Elemento = string.Empty;
        }

        public bool EstaVacia()
        {
            if (Array[0] == null)
                 return true;                        
            else
                 return false;
        }

        public string Extraer()
        {
            string ultimo = "";
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == null)
                {
                    ultimo = Array[i - 1];
                    Array[i - 1] = null;
                    break;
                }
            }
            return ultimo;
        }
        public string Primero()
        {
            string primero = "";
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == null)
                {
                    primero = Array[i-1];
                    return primero;
                }
            }
            return primero;
        }

        public bool Anadir(string elemento)
        {
            if (contador < Array.Length)
            {
                Array[contador] = elemento;
                contador++;
                return true;
            }
            else
            { 
                return false;  
            }
        }

        public override string ToString()
        {
            return $"Elemento: {Elemento}";
        }
    }
}
