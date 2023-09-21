using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoEstructura
{
    class Nodo
    {
        public string Nombre;
        public string Tel;
        public string Cumple;
        public Nodo Siguiente;

        public Nodo()
        {
        }
        public Nodo(string no,string tel,string cumple)
        {
            Nombre = no;
            Tel = tel;
            Cumple = cumple;
        }
    }
}
