using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAOD
{
    public class Queue<T>
    {
        public uint Capacity { get; private set; }
        public uint Size { get; private set; }
        public uint First { get; private set; }
        public T[] Values { get; private set; }
        public Queue(uint size)
        {
            this.Capacity = size;
            this.Size = 0;
            First = 0;
            this.Values = new T[this.Capacity];
        }
        public void Push(T value)
        {
            if (Size == Capacity)
                throw new Exception();
            Values[(First + Size) % Capacity] = value;
        }
        public T Peek()
        {
            if (IsEmpty)
                throw new Exception();
            return Values[First];
        }
        public T Pop()
        {
            T value = Peek();
            Size--;
            First = (First + 1) % Capacity;
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
    }
}
