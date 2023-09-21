using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoEstructura
{
    class CrearLista
    {
        Nodo cabeza;
        int numero = 0;
        public int Tamaño
        {
            get { return numero; }
        }
        public void Insertar(string nom,string tel,string fecha)
        {
            Nodo aux;
            Nodo nuevo = new Nodo(nom,tel,fecha);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                aux = cabeza;
                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }
                aux.Siguiente = nuevo;
            }
            numero++;
        }        
        
        public void Imprime(System.Windows.Forms.ListBox lista)
        {
            lista.Items.Clear();
            Nodo aux = cabeza;
            while (aux != null)
            {
                lista.Items.Add(aux.Nombre + "  " + aux.Tel + "  " + aux.Cumple);
                aux = aux.Siguiente;
            }
        }
        public int Tamanño()
        {
            return numero;
        }
        public void borrar(string n)
        {
            Nodo p;
            p = cabeza;
            if (n.Equals(p.Nombre))
            {
                cabeza = cabeza.Siguiente;                
            }
            else
            {
                p = buscar(n);
                if (p.Siguiente != null)
                    p.Siguiente = p.Siguiente.Siguiente;
            }
            numero--;
        }
        public Nodo buscar(string m)
        {
            Nodo actual = cabeza;
            while ((actual.Siguiente  != null) && (!(actual.Siguiente .Nombre.Equals(m))))
            {
                actual = actual.Siguiente ;
            }
            return actual;
        }
        public Nodo Buscar(string nom)
        {
            
            Nodo aux = cabeza;
            while (aux != null && aux.Nombre!=nom)
            {                
                aux = aux.Siguiente;
            }

            return aux;

        }
    }
}
