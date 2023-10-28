using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharStack
{
    internal class CharStack
    {
        private char[] stack;
        private int index;

        public CharStack(int nElem)
        {
            stack = new char[nElem];
            index = 0;
        }
        public bool push(char c)
        {
            if (index < stack.Length){
                stack[index] = c;
                index++;
                return true;
            }
            return false;
        }

        public bool pop()
        {
            if (index > 0)
            {
                index--;
                return true;
            }
            return false;
        }
        public bool isEmpty()
        {
            if (index == 0)
            {
                return true;
            }
            return false;
        }
        public char getElem()
        {
            if (isEmpty()) throw new Exception();
            return stack[index - 1];
        }
    }
}
