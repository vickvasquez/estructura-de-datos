using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lista_ligada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        lista_doble lista = new lista_doble();

        private void button1_Click(object sender, EventArgs e)
        {
            lista.insertarfinal(textBox1.Text);
            textBox1.Text = string.Empty;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lista.numNodo() == 0)
            {
                MessageBox.Show("No hay elementos en la lista","Lista Vacia",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                lista.Imprimer(listBox1);             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lista.InsertaD(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
                MessageBox.Show("Capture el dato a eliminar", "Dato erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (lista.numNodo() == 0)
                {
                    MessageBox.Show("No hay elementos en la lista", "Lista Vacia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (lista.numNodo() != 0)
                         lista.Elimina(textBox1.Text);                 

                }
            }
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }
    }
}
