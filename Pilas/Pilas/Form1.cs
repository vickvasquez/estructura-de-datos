using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pilas
{
    public partial class Form1 : Form
    {
        Stack <string> Num=new Stack<string>();
        Stack<string> ope = new Stack<string>();
        Stack<string> cierra = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
            
            
        }
        public void Borrar()
         {
             ope.Clear();
             Num.Clear();
             cierra.Clear();
        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {    
            Label lb1 = new Label();
            if (txtexpresion.Text == string.Empty)
            {
                
                lb1.Text = "Capture la expresion en el cuadro de texto";
                lb1.ForeColor = Color.Red;
                lb1.Height = 20;
                lb1.Width = 250;
                lb1.Location = new Point(150, 60);
                this.Controls.Add(lb1);
                txtexpresion.Focus();               
            }
            else
            {
                this.Controls.Remove(lb1);            
                string expresion = txtexpresion.Text;
                Expresiones ola = new Expresiones();
                ola.Calcular(Num, ope, cierra, expresion);
                if (ola.Encuentra(ope, cierra) == 1)
                    MessageBox.Show("La expresion esta balanceada","Lista Balanceada",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                    MessageBox.Show("La expresion esta desbalanceada","Lista Desbalanceada",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Borrar();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
