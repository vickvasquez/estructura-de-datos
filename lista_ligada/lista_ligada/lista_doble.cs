using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lista_ligada
{
    class lista_doble
    {
        nodo2 cabeza;
        public void insertarfinal(string dato)
        {
            nodo2 aux = cabeza;
            nodo2 nuevo = new nodo2(dato, null);
            if (cabeza == null)
            {
                nuevo.siguiente = null;
                nuevo.anterior = null;
                cabeza = nuevo;
            }
            else
            {
                aux = cabeza;
                while (aux.siguiente != null)
                {
                    aux = aux.siguiente;
                }
                nuevo.siguiente = aux.siguiente;
                nuevo.anterior = aux;
                aux.siguiente = nuevo;
            }

        }

        public void Imprimer(System.Windows.Forms.ListBox lista)
        {
            nodo2 aux = cabeza;
            lista.Items.Clear();
            while (aux != null)
            {
                lista.Items.Add(aux.Dato);
                aux = aux.siguiente;
            }
        }
        public void InsertaD(string dato)
        {
            nodo2 aux = cabeza;
            nodo2 nuevo = new nodo2(dato, null);
            if (cabeza == null)
            {
                nuevo.siguiente = null;
                nuevo.anterior = null;
                cabeza = nuevo;
            }
            else
            {
                nuevo.siguiente = aux;
                nuevo.anterior = aux.anterior;
                aux.anterior = nuevo;
                aux = cabeza = nuevo;
            }
        }
        public void Elimina(string dato)
        {
            nodo2 aux = Buscar(dato);
            if (aux != null)
            {
                aux = aux.siguiente;
                //cabeza.anterior = null;
                //aux.siguiente = null;
            }
        }
        public nodo2 Buscar(string dato)
        {
            nodo2 p, q;
            p = cabeza;
            if (cabeza != null)
            {
                q = null;
                if (p.Dato == dato)
                {
                    cabeza = cabeza.siguiente;
                    //cabeza.anterior = null;                    
                }
                else
                {
                    q = p;
                    p = p.siguiente;
                    while (p != null && p.Dato != dato)
                    {
                        q = p;
                        p = p.siguiente;
                    }
                    if (p != null)
                    {
                        q.siguiente = p.siguiente;
                        if (p.siguiente != null)
                        {
                            p.siguiente.anterior = q;
                        }
                    }
                }
                return p;
            }
            return null;
        }
        public int numNodo()
        {
            int numero = 0;
            nodo2 aux=cabeza;
            if (cabeza == null)
                return numero;
            else
                while (aux != null)
                {
                    numero += 1;
                    aux = aux.siguiente;
                }
            return numero;
        }
    }
}
