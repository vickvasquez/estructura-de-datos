using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;

namespace MultiProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, baseNum;
            Console.Title = "Convertidor a binario octal y hexadecimal";
            Console.WriteLine("Escribe un numero Decimal\n");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escribe la base\n");
            baseNum = Convert.ToInt32(Console.ReadLine());
            Console.Write(num + " " + "convertido a"+" ");
            MultiBase(num, baseNum);
            Console.WriteLine("Base"+" " + baseNum);
            Console.ReadLine();
        }
        static void MultiBase(int n, int b)
        {
            Stack Digits = new Stack();
            do
            {
                Digits.Push(n % b);
                n /= b;
            } while (n != 0);
            while (Digits.Count > 0)
                Console.Write(Digits.Pop());
        }
    }
}
