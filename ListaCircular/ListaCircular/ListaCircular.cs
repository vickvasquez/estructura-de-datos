using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaCircular
{
    class ListaCircular
    {
        private Nodo2 ultimo;
        private int numero = 0;

        public int Tamaño
        {
            get { return numero; }
        }
        public void Añadir(string dato)
        {
            Nodo2 q = new Nodo2(dato, null);
            if (ultimo == null)
            {
               ultimo = q;
               ultimo.Siguiente = q;               
            }
            else
            {
                q.Siguiente = ultimo.Siguiente;
                ultimo.Siguiente = q;
            }
            numero++;
        }
        public void Mostrar(System.Windows.Forms.ListBox lista)
        {
            if (ultimo == null)
                return;
            else
            {
                lista.Items.Clear();
                Nodo2 q = ultimo.Siguiente;
                while (q != ultimo)
                {
                    lista.Items.Add(q.dato);
                    q = q.Siguiente;
                }
                lista.Items.Add(ultimo.dato);
            }
            
        }
        public void Borrar()
        {
            if (ultimo == null)
                return;
            else
            {
                Nodo2 q = ultimo.Siguiente;
                string s = q.dato;
                if (q == ultimo)
                        ultimo = null;
                else
                    ultimo.Siguiente = q.Siguiente;
            }
            numero--;
        }
        public Nodo2 Encuentra(string n)
        {
            Nodo2 p;
            p = ultimo.Siguiente;
            if (ultimo != null)
            {
                
                if (p.dato == n)
                {
                    ultimo.Siguiente = ultimo.Siguiente.Siguiente;
                    p = p.Siguiente;        
                }
                else
                {
                    
                    p = p.Siguiente;
                    while (p != null && p.dato != n)
                    {
                        p = p.Siguiente;
                    }
                    if (p != null)
                    {
                       
                        if (p.Siguiente != null)
                        {
                            p.Siguiente=null;
                        }
                    }
                }
                return p;
            }
            return null;
           

        }
       
        public void Eliminar(string dat)
        {
            Nodo2 q = Encuentra(dat);
            if(q!=null)
            {
                q= q.Siguiente;
            }            
        }

        public int NumNodo()
        {
            return numero;
        }
    }
}
