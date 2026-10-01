using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyStack
    {
        int top;
        string[] data;
  
        // new Stack() // 5
        // new Stack(19) // 19

        public MyStack(int size=5)
        {
            top = 0;
            data = new string[size];
        }

        public void Push(string value)
        {
            if(top >= data.Length)
            {
                throw new Exception("out of range");
            }

            data[top++] = value;
            //data[top] = value;
            //top++;
        }

        public string Pop()
        {
            if(top <= 0)
            {
                throw new Exception("stack is empty");
            }

            return data[--top];
            //top--;
            //return data[top];

        }

    }

    class MyGenericStack<T>
    {
        int top;
        T[] data;

        // new Stack() // 5
        // new Stack(19) // 19

        public MyGenericStack(int size = 5)
        {
            top = 0;
            data = new T[size];
        }

        public void Push(T value)
        {
            if (top >= data.Length)
            {
                throw new Exception("out of range");
            }

            data[top++] = value;
            //data[top] = value;
            //top++;
        }

        public T Pop()
        {
            if (top <= 0)
            {
                throw new Exception("stack is empty");
            }

            return data[--top];
            //top--;
            //return data[top];

        }

    }
}
