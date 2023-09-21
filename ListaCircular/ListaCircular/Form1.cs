using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Taskbar;
using System.Text;
using System.Windows.Forms;

namespace ListaCircular
{
    public partial class Form1 : Form
    {
        ListaCircular lista = new ListaCircular();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Añadir(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lista.NumNodo() == 0)
            {
                MessageBox.Show("No hay elementos en la lista");
            }
            lista.Mostrar(listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lista.Borrar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lista.NumNodo() == 0)
                MessageBox.Show("La lista esta vacia");
            else
            lista.Eliminar(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TaskbarManager windowsTaskbar = TaskbarManager.Instance;
            windowsTaskbar.SetProgressState(TaskbarProgressBarState.NoProgress); 
            windowsTaskbar.SetProgressValue(80, 100);
            Icon icoBtnRandom = new Icon("I:\\NAY.ico");

            Icon icoBtnBlanco = new Icon("I:\\NAY.ico");  

    

    // Creamos los dos botones  

     ThumbnailToolbarButton btnRandom = new ThumbnailToolbarButton(icoBtnRandom, "Color Random");  

     ThumbnailToolbarButton btnBlanco = new ThumbnailToolbarButton(icoBtnBlanco, "Color Blanco");  

  

     // Habilitamos ambos botones  

    btnRandom.Enabled = true;  

    btnBlanco.Enabled = true;  

    

   // Asignamos el evento clic a cada boton  

    btnRandom.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(btnRandom_Click);  

     btnBlanco.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(brnBlanco_Click);  


    // Obtenemos un puntero a la barra de tareas  

    TaskbarManager windowsTaskbar1 = TaskbarManager.Instance;  

    

    // Agregamos los botones a la vista previa  

     windowsTaskbar1.ThumbnailToolbars.AddButtons(this.Handle, btnRandom, btnBlanco);  


        }

        private void brnBlanco_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random r = new Random();  

           BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255)); 

        }
    }
}
