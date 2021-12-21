namespace Kuyruk_Quentity
{
    internal class LinkedListQueue<T> : IQueue<T>
    {
        private readonly DoublyLinkedList<T> list = new DoublyLinkedList<T>();
        public int Count => throw new System.NotImplementedException();

        public T DeQueue()
        {
            throw new System.NotImplementedException();
        }

        public void EnQueue(T value)
        {
            throw new System.NotImplementedException();
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new System.Exception("Empyt queneu");
            }
        }
    }
}