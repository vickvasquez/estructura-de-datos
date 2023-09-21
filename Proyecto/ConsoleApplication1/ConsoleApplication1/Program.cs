using System;
using System.IO;
using System.Collections;

namespace TextFileReader_csharp
{
    /// <summary>
    /// Descripción de resumen para Class1.
    /// </summary>
    class Class1
    {
        static void Main(string[] args)
        {
            StreamReader objReader = new StreamReader("datos.txt");
            string sLine = "";
            ArrayList arrText = new ArrayList();

            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    arrText.Add(sLine);
            }
            objReader.Close();

            foreach (string sOutput in arrText)
                Console.WriteLine(sOutput);
            Console.ReadLine();
        }
    }
}