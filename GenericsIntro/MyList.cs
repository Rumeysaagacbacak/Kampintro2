using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor ----bir class newlendiğinde çalışan bloğa denirr
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;// geçici array
            items= new T[items.Length+1];//eleman sayısını verir.
            for (int i = 0; i < tempArray.Length; i++)//geçici arraydan geri çagırmak için yazdığımız kod.
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
