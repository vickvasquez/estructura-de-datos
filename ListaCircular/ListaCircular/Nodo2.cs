using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaCircular
{
    class Nodo2
    {
        public string dato;
        public Nodo2 Siguiente;

        public Nodo2()
        {
        }
        public Nodo2(string n, Nodo2 s)
        {
            dato = n;
            Siguiente = s;
        }
    }
}
