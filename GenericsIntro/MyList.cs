using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //Constructor      
        public MyList()
        {
            items = new T[0];
        }
        public void add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

            }
            items[items.Length - 1] = item;


        }
    }
}
