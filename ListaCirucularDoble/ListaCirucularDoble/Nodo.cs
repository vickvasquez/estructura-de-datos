using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaCirucularDoble
{
    class Nodo
    {
        public string dato;
        public Nodo siguiente;
        public Nodo anterior;
        public Nodo(string dato, Nodo Sig,Nodo Ant)
        {
            this.dato = dato;
            siguiente = Sig;
            anterior = Ant;
        }
    }
}
