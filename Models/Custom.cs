using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericCollection.Models
{
    public class Custom<T> where T : class
    {
          T[] list;
        T[] newlist;
        T[] clearlist;
        T[] removelist;

        public int count;
        public Custom()
        {
            list = new T[0]; 
            clearlist = new T[0];
        }
        public void Add(T item)
        {
            newlist = list;
            list =new T [list.Length+1];
            for (int i = 0; i < newlist.Length; i++)
            {
                list[i] = newlist[i];
            }
                list[list.Length-1]=item;
        }

        public int Count
        {
           get { return list.Length; }
        }
        public bool Contains(T item)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (item == list[i])
                {
                    return true;
                }
            }
            return false;
        }
        public void Clear()
        {
            for (int i = 0; i < list.Length; i++)
            {

                if (list.Length>0)
                {
                    list = clearlist;
                }
            }
            Console.WriteLine(clearlist.Length);
            
        }
        public void Remove(T item)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (item == list[i])
                {
                    list = new T[list.Length-1];
                    removelist = list;
                   removelist[list.Length-1] = item;
                }
            }
        }


    }
}
