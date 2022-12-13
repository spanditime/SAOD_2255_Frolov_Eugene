using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAOD
{
    public class List<T> : IEnumerable<T>
    {
        private class ListEnumerator : IEnumerator<T>
        {
            public ListEnumerator(Node<T> first, Node<T> last)
            {
                this.curr = new Node<T>(first.value, null, first);
                this.first = first;
                this.last = last;
            }
            public T Current => curr.value;

            object IEnumerator.Current => curr.value;

            public void Dispose()
            {

            }

            public bool MoveNext()
            {
                if (curr == last)
                    return false;
                curr = curr.next;
                return true;
            }

            public void Reset()
            {
                curr = new Node<T>(first.value, null, first);
            }
            private Node<T> first;
            private Node<T> last;
            private Node<T> curr;
        }
        private Node<T> last;
        private Node<T> first;

        public List()
        {
            last = first = null;
        }
        public void Append(T value)
        {
            if (IsEmpty)
            {
                last = first = new Node<T>(value, null, null);
            }
            else
            {
                last = new Node<T>(value, last, null);
                last.prev.next = last;
            }
        }
        public void Prepend(T value)
        {
            if (IsEmpty)
            {
                last = first = new Node<T>(value, null, null);
            }
            else
            {
                first = new Node<T>(value, null, first);
                first.next.prev = first;
            }
        }
        public uint Find(T value)
        {
            uint idx = 0;
            Node<T> curr = first;
            while (curr != null)
            {
                if (value.Equals(curr.value))
                    return idx;
                idx++;
                curr = curr.next;
            }
            throw new Exception();
        }
        public void Remove(T value)
        {
            uint idx = Find(value);
            RemoveAt(idx);
        }
        public void RemoveBack()
        {
            if (IsEmpty)
                throw new Exception();
            if (last.Equals(first))
            {
                last = first = null;
            }
            else
            {
                last = last.prev;
                last.next = null;
            }
        }
        public void RemoveFront()
        {
            if (IsEmpty)
                throw new Exception();
            if (last.Equals(first))
            {
                last = first = null;
            }
            else
            {
                first = first.next;
                first.prev = null;
            }
        }
        public void RemoveAt(uint idx)
        {
            Node<T> curr = first;
            for (uint i = 0; i != idx; i++)
            {
                if (curr.next == null)
                    throw new Exception();
                curr = curr.next;
            }
            if (curr.Equals(last))
            {
                RemoveBack();
            }
            else if (curr.Equals(first))
            {
                RemoveFront();
            }
            else
            {
                curr.prev.next = curr.next;
                curr.next.prev = curr.prev;
            }
        }
        public T At(uint idx)
        {
            Node<T> curr = first;
            for (uint i = 0; i != idx; i++)
            {
                if (curr.next == null)
                    throw new Exception();
                curr = curr.next;
            }
            return curr.value;
        }

        public uint Size
        {
            get
            {
                if (IsEmpty)
                    return 0;
                uint size = 1;
                Node<T> curr = first;
                while(curr.next != null)
                {
                    size++;
                    curr = curr.next;
                }
                return size;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ListEnumerator(first, last);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ListEnumerator(first, last);
        }

        public T[] ToArray()
        {
            uint size = Size;
            T[] array = new T[size];
            Node<T> curr = first;
            for(int i = 0; i < size; i++)
            {
                array[i] = curr.value;
                curr = curr.next;
            }
            return array;
        }

        public bool IsEmpty
        {
            get
            {
                return last == null;
            }
        }

        private class Node<_T>
        {
            public Node(_T value, Node<_T> prev, Node<_T> next)
            {
                this.value = value;
                this.prev = prev;
                this.next = next;
            }
            public Node<_T> prev;
            public Node<_T> next;
            public _T value;
        }
    }
}
