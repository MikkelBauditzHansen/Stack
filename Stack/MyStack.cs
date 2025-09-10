using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class MyStack<T>
    {
        private List<T> _items;
        public int Count { get { return _items.Count; } } //returnere hvor mange elementer der er i stacken
        
        public MyStack()
        {
            _items = new List<T>();
        }
        public void Push(T item)
        {
            _items.Add(item);
        }
        public T Pop()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Stakken er tom.");
            int lastIndex = _items.Count - 1; //finder det sidste element i listen
            T topitem = _items[lastIndex]; //gemmer det fundne element i topitem
            _items.RemoveAt(lastIndex); //fjerner elementet i den fundne position
            return topitem; //returnerer det element der blev gemt i topitem 
        }

        public T Peek()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("Stakken er tom.");
            }
            return _items[_items.Count - 1]; //returnerer det element der ligger i toppen af stakken
        }
        


    }
}
