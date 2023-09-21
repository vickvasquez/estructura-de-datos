using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Pilas
{
    class Expresiones
    {
       public bool IsNumeric(string input)
        {
            bool ban = true;
            string expresion = (@"^\d+$");
            Regex validar = new Regex(expresion);
            if (!validar.IsMatch(input))
                ban = false;
            return ban;
        }
        public void Calcular(Stack<string> N, Stack<string> Pe, Stack<string> Pc, string exp)
        {
            string ch, token = "";
            for (int i = 0; i < exp.Length; i++)
            {
                ch = exp.Substring(i, 1);
                if (IsNumeric(ch))
                    token += ch;
                if (IsNumeric(token))
                {
                    N.Push(token);
                    token = string.Empty;
                }
                else if (ch == "(")
                {
                    Pe.Push(ch);
                }
                else if (ch == ")")
                {
                    Pc.Push(ch);
                }

            }
        }
        public int Encuentra(Stack<string> Pe, Stack<string> Pc)
        {
            int n = 0;
            if (Pe.Count == Pc.Count)
                n = 1;
            return n;
        }

    }
}
