using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;

namespace Pilas1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack nums = new Stack();
            Stack ops = new Stack();
            Console.Title = "APLICACION DE PILAS";
            string expresion = "5*10*15/20";
            Calcular(nums, ops, expresion);
            Console.WriteLine(nums.Pop());
            Console.ReadLine();
        }
        static bool IsNumeric(string input)
        {
            bool ban = true;
            string expresion = (@"^\d+$");
            Regex validar = new Regex(expresion);
            if (!validar.IsMatch(input))
                ban = false;
            return ban;
        }
        static void Calcular(Stack N, Stack O, string exp)
        {
            string ch, token = "";
            for (int i = 0; i < exp.Length; i++)
            {
                ch = exp.Substring(i, 1);
                if (IsNumeric(ch))
                    token += ch;
                    if (ch == "" || i == (exp.Length - 1))
                    {
                        if (IsNumeric(token))
                        {
                            N.Push(token);
                            token = string.Empty;
                        }
                    }
                    else if (ch == "+" || ch == "-" || ch == "*" || ch == "/")
                    {
                        O.Push(ch);
                    }
                    if (N.Count == 2)
                        Compute(N, O);
                
            }
        }
        static void Compute(Stack N, Stack O)
        {
            int oper1, oper2;
            string oper;
            oper1 = Convert.ToInt32(N.Pop());
            oper2 = Convert.ToInt32(N.Pop());
            oper = O.Pop().ToString();
            switch (oper)
            {
                case "+":
                    N.Push(oper1 + oper2);
                    break;
                case "-":
                    N.Push(oper1 - oper2);
                    break;
                case "*":
                    N.Push(oper1 * oper2);
                    break;
                case "/":
                    N.Push(oper1 / oper2);
                    break;
            }
        }
    }
}
