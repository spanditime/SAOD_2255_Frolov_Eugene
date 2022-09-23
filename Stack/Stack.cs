using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAOD
{
    internal class Stack<T>
    {
        public uint Capacity { get; private set; }
        public uint Size { get; private set; }
        private T[] values;
        public Stack(uint size)
        {
            if (size == 0)
                throw new Exception();
            this.Size = 0;
            this.Capacity = size;
            this.values = new T[this.Capacity];
        }
        public void Push(T value)
        {
            if (Size == Capacity)
                throw new Exception();
            values[Size] = value;
            Size++;
        }
        public T Peek()
        {
            if (IsEmpty)
                throw new Exception();
            return values[Size - 1];
        }
        public T Pop()
        {
            T value = Peek();
            Size--;
            return value;
        }

        
        public bool IsEmpty
        {
            get
            {
                return Size == 0;
            }
        }
        public void Clear()
        {
            Size = 0;
        }
        public T[] Values
        {
            get
            {
                T[] ret = new T[Size];
                for(int i = 0; i < Size; i++){
                    ret[i] = values[i];
                }
                return ret;
            }
        }
    }
}
