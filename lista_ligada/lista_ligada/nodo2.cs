using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lista_ligada
{
    class nodo2
    {
        public string Dato;
        public nodo2 siguiente,anterior;
        public nodo2()
        { 
         
        }
        public nodo2(string nodo2,nodo2 s)
        {
            Dato=nodo2;
            siguiente=s;
        }
    }
}
