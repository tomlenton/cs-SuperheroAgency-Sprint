using SuperheroAgency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal class CustomStack<T>
    {
        private T[] items;

        public CustomStack()//constructor needs to start with empty array with length?
        {
            items = new T[0];
        }

        public void Push(T item) // Push method that adds an item to the end of the stack
        {
            Array.Resize<T>(ref items, items.Length + 1);
            items.SetValue(item, items.Length - 1);
          
        }
        public T Pop()
        {
            T itemTakenOut = items[items.Length - 1];
            Array.Resize<T>(ref items, items.Length - 1);
            return itemTakenOut;
        }

    }
}

