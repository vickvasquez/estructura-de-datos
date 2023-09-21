using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {         

            try
            {
            string fileName = "datos.txt";
            int letter = 0;
            FileStream stream = new FileStream(fileName, FileMode.Open,FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            while (letter != -1)
            {
                letter = reader.Read();
                if (letter != -1) listBox1.Items.Add(((char)letter));
            }
            reader.Close();
            stream.Close();
            }
            catch
            {
            Console.WriteLine("Error");
            }
            }
        }
    }

