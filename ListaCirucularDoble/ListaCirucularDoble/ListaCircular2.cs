using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaCirucularDoble
{
    class ListaCircular2
    {
        private Nodo ultimo;
        private int numero = 0;
        public int Tamaño
        {
            get { return numero; }
        }
        public void Insertar(string dato)
        {
            Nodo nuevo=new Nodo(dato,null,null);
            if (ultimo == null)
            {
                nuevo.siguiente = nuevo.anterior = nuevo;
                ultimo = nuevo;
            }
            else
            {   
                nuevo.siguiente = ultimo.siguiente;
                nuevo.anterior = ultimo.siguiente.anterior;  
                ultimo.siguiente = nuevo;
                nuevo.anterior = ultimo;         
                ultimo = nuevo;
            }
            numero++;
        }
        public void Imprimir(System.Windows.Forms.ListBox lista)
        {
            if (ultimo == null)
                return;
            else
            {
                Nodo q = ultimo.siguiente;;
                lista.Items.Clear();                
                while (q != ultimo)
                {
                    lista.Items.Add(q.dato);
                    q = q.siguiente;
                }
                lista.Items.Add(ultimo.dato);
            }
        }
        public int Nodos()
        {
            return numero;
        }
        public void Borrar(string d)
        {
        }
        public Nodo Buscar(string x)
        {
            Nodo aux;
            aux = ultimo.siguiente;
            while (aux.siguiente != ultimo && aux.dato != x)
            {
                aux = aux.siguiente;
            }
            return aux;
        }
    }
}
