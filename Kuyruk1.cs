using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuyruk_Quentity
{
    public interface IQueue<T>
    {
        //arayüzde hangi ifadeler olmalıdır. 
        int Count { get; }
        void EnQueue(T value);
        T DeQueue();
        T Peek();
    }
    public class Kuyruk1<T>
    {

        // dizi tabanlı yapmız dinamik tabanlı olacaktır. bağlı tabanlı yapıda iki yönlü yapı kullanılacaktır. 
        //bir önceki uygulamad gibi yapacağımız ifade 
        private readonly IQueue<T> queue;
        public int Count => queue.Count;
        //yapılandırıcı ifadeye ihtiyaç vardır 
        public Kuyruk1( QueuType type=QueuType.Array)
        {
            if (type==QueuType.Array)
            {
                queue = new ArrayQueue<T>();
            }
            else 
            {
                queue = new LinkedListQueue<T>();           
            
            }


        }
        public void EnQueue(T value)
        {
            queue.EnQueue(value);
        }
        public void DeQueue()
        {
            //parametreye ihtiyaç yoktur.  i
            queue.DeQueue();
        }

        public T DeQueuee()//bir eleman çıkartılacaksa hangi eleman olacağını verecek fonksiyondur. kuyrukta baştan eleman çıkartılır. 
        {
            return queue.DeQueue();
        }
        public T Peek()//bir eleman çıkartılacaksa hangi eleman olacağını verecek fonksiyondur. kuyrukta baştan eleman çıkartılır. 
        {
             return queue.DeQueue();
        }
    }
    public enum QueuType
    {
        Array=0, //list of t referan alacka List<T> dinamiktir
        LinkedList=1 //listenin başını ve sonunu dikkate alınarka yapılmaktadır. 
    }
}