using Lab08_Collections.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Collections.Classes
{
    public class Backpack<T> : IBag<T>
    {

        //use this for storage
        private List<T> myBag = new List<T>();

        public void Pack(T item)
        {
            myBag.Add(item);
        }

        public T Unpack(int index)
        {
            //Find the item at that index
            T output = myBag[index];
            //Remove that item from the list
            myBag.Remove(output);
            //Return that item
            return output;
        }

        //Gonna be honest, have no idea what is happening here
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T thing in myBag)
            {
                yield return thing;
            }
        }

        //Gonna be honest, have no idea what is happening here
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
