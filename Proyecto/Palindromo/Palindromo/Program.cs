using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            CStack alist = new CStack();
            string ch;
            string word = "sees";
            bool isPalindrome = true;
            for (int x = 0; x < word.Length; x++)
                alist.push(word.Substring(x, 1));
            int pos = 0;
            while (alist.Count > 0)
            {
                ch = alist.pop().ToString();
                if (ch != word.Substring(pos, 1))
                {
                    isPalindrome = false;
                    break;
                }
                pos++;
            }
            if (isPalindrome)
            {
                Console.WriteLine(word + " "+"es palindromo");
            }
            else
                Console.WriteLine(word + "no es un palindromo");
            Console.ReadLine();
        }

    }
}
