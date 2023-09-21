using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Taskbar;
using System.Windows.Forms;
using System.IO;

namespace ProyectoEstructura
{
    public partial class Form1 : Form
    {
        CrearLista lista = new CrearLista();
        string s="";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            button4.Enabled = false;
            TaskbarManager windowsTaskbar = TaskbarManager.Instance;
            windowsTaskbar.SetProgressState(TaskbarProgressBarState.Normal);
            windowsTaskbar.SetProgressValue(100, 100);
            Icon icoBtnRandom = new Icon(@"I:\Proyecto\maximizar.ico");
            Icon icobutton1 = new Icon(@"I:\Proyecto\cerrar.ico");
            Icon icoBtnBlanco = new Icon(@"I:\Proyecto\minizar.ico");
            ThumbnailToolbarButton btnRandom = new ThumbnailToolbarButton(icoBtnRandom, "Maximizar");
            ThumbnailToolbarButton button1 = new ThumbnailToolbarButton(icobutton1, "Cerrar");
            ThumbnailToolbarButton btnBlanco = new ThumbnailToolbarButton(icoBtnBlanco, "Minimizar");
            btnRandom.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(btnRandom_Click);
            btnBlanco.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(btnBlanco_Click);
            button1.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(button1_Click);
            TaskbarManager windowsTaskbar1 = TaskbarManager.Instance;         // Agregamos los botones a la vista previa
            windowsTaskbar1.ThumbnailToolbars.AddButtons(this.Handle, btnRandom, btnBlanco);
        }

        void button1_Click(object sender, ThumbnailButtonClickedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }

       private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

                StreamReader leer = new StreamReader("datos.txt");
                while (s != null)
                {
                    s = leer.ReadLine();
                    if (s != null)
                    {
                        int i = 0;
                        string a = "", j = "", k = "";
                        while (s[i] != ' ')
                        {
                            a += s[i];
                            i++;
                        }
                        while (s[i] == ' ')
                        {
                            i++;
                        }
                        while (s[i] != ' ')
                        {
                            j += s[i];
                            i++;
                        }
                        while (s[i] == ' ')
                        {
                            i++;
                        }
                        while (i < s.Length)
                        {
                            k += s[i]; i++;
                        }
                        lista.Insertar(a, j, k);
                    }
                }
                leer.Close();

            }
            else if (radioButton2.Checked == true)
            {
                if (lista.Tamanño() == 0)
                    MessageBox.Show("La lista esta vacia","Lista Vacia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                    lista.Imprime(listBox1);
            }
            else if (radioButton4.Checked == true)
            {
                if (lista.Tamanño() != 0)
                {
                    lista.borrar(listBox1.SelectedItem.ToString());
                    for (int i = 0; i <= listBox1.Items.Count - 1; i++)
                    {
                        if (listBox1.SelectedIndex == i)
                        {
                            listBox1.Items.RemoveAt(i);
                        }
                    }
                }
                else
                    MessageBox.Show("Ya no hay elementos en la lista", "lista vacia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(radioButton5.Checked==true)
            {
                 if (lista.Buscar(textBox1.Text)!=null)
                    {
                        MessageBox.Show("El elemento esta en la lista");
                     }
                else
                    MessageBox.Show("No se encuentra en la lista");
            }


            else
                MessageBox.Show("La lista contiene" + " " + lista.Tamanño() + " " + "Nodos", "Cantidad De Nodos", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

                button4.Enabled = true;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnBlanco_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {

        }

     }


 }

