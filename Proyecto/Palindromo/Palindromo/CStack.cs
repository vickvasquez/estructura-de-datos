using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;

namespace Palindromo
{
    class CStack
    {
        private int p_index;
        private ArrayList list;
        public CStack()
        {
            list = new ArrayList();
            p_index = -1;
        }
        public int Count
        {
            get { return list.Count; }
        }
        public void push(object item)
        {
            list.Add(item);
            p_index++;
        }
        public object pop()
        {
            object obj = list[p_index];
            list.RemoveAt(p_index);
            p_index--;
            return obj;
        }
        public void Clear()
        {
            list.Clear();
            p_index = -1;
        }
        public object Peek()
        {
            return list[p_index];
        }
    }
}
