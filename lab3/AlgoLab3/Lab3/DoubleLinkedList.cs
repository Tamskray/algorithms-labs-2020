using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class DoubleLinkedList<T> : IEnumerable<T>
    {
        public DoubleItem<T> Head { get; set; }
        public DoubleItem<T> Tail { get; set; }
        public int Count { get; set; }
        public DoubleLinkedList() { }
        public DoubleLinkedList(T data)
        {
            var item = new DoubleItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void Add(T data)
        {
            var item = new DoubleItem<T>(data);
            DoubleItem<T> temp = Head;
            item.Next = temp;
            Head = item;
            if (Count == 0)
            {
                Tail = Head;
            }
            else
            {
                temp.Previous = item;
            }
            Count++;
        }

        public void AddToEnd(T data)
        {
            var item = new DoubleItem<T>(data);
            if (Count == 0)
            {
                Head = item;
                Tail = item;
                Count = 1;
                return;
            }
            Tail.Next = item;
            item.Previous = Tail;
            Tail = item;
            Count++;
        }

        public void Delete(T data)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }
            if (current != null)
            {
                if (current.Next != null)
                {
                    current.Previous.Next = current.Previous;
                }
                else
                {
                    Tail = current.Previous;
                }
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    Head = current.Next;
                }
                Count--;
                return;
            }
            return;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public DoubleLinkedList<T> Reverse()
        {
            var result = new DoubleLinkedList<T>();
            var current = Tail;
            while (current != null)
            {
                result.Add(current.Data);
                current = current.Previous;
            }
            return result;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }
    }
}
