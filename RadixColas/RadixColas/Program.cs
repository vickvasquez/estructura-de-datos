using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace RadixColas
{
    class Program
    {
        enum DigitType { ones = 1, tens = 10 }
        static void DisplayArray(int[] n)
        {
            for (int x = 0; x < n.GetUpperBound(0); x++)
            {
                Console.WriteLine(n[x] + " ");
            }
        }
        static void RSort(Queue[] que, int[] n, DigitType digit)
        {
            int snum;
            for (int x = 0; x <n.GetUpperBound(0); x++)
            {
                if (digit == DigitType.ones)
                    snum = n[x] % 10;
                else
                    snum = n[x] / 10;
                que[snum].Enqueue(n[x]);
            }
        }
        static void BuildArray(Queue[] que, int[] n)
        {
            int y = 0;
            for (int x = 0; x <=9; x++)
            {
                while (que[x].Count>0)
                {
                 n[y]=Int32.Parse(que[x].Dequeue().ToString());
                 y++;
                }
            }
        }
        static void Main(string[] args)
        {
            Queue[] numQue = new Queue[10];
            int[] nums = new int[] { 91,46,85,15,92,35,31,22};
            for (int i = 0; i < 10; i++)
            {
                numQue[i] = new Queue();    
            }
            RSort(numQue, nums, DigitType.ones);
            BuildArray(numQue, nums);
            Console.WriteLine();
            Console.WriteLine("Resultados del primer rrecorrido");
            DisplayArray(nums);
            RSort(numQue, nums, DigitType.tens);
            BuildArray(numQue, nums);
            Console.WriteLine();
            Console.WriteLine("Resultados del segundo rrecorrido");
            DisplayArray(nums);
            Console.WriteLine();
             Console.WriteLine("Presione Enter para salir");
             Console.ReadLine();
        }
    }
}
