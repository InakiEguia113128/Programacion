using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    interface IColecction
    {
        bool EstaVacia();
        string Extraer();
        string Primero();
        bool Anadir(string elemento);
    }
}
