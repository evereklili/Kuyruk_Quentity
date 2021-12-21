using System;
using System.Collections.Generic;

namespace Kuyruk_Quentity
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private readonly List<T> list=new List<T> (); //LİSTE ORGANİZSYONU İİN 

        public int Count { get; private set; }

        public T DeQueue()
        {
            //liste başından silinecek
            if (Count==0)
            {
                throw new Exception("empty queue");
            }

            var temp = list[0];
            list.RemoveAt(0);//indis değeri olan elemanı. bir elemanı siler. 
            Count--;
            return temp;

        }

        public void EnQueue(T value)
        {
            if (value==null)
            {
                throw new System.ArgumentNullException();
            }
            list.Add(value);
            Count++;
        }

        public T Peek()
        {
            if (Count==0)
            {
                throw new Exception("empty queue!");
            }
            return list[0];
        }
    }
}