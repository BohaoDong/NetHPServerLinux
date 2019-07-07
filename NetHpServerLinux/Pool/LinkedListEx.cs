using System.Collections.Generic;

namespace NetHpServerLinux.Pool
{
    public class LinkedListEx<T> : LinkedList<T>
    {
        public static LinkedList<T> Instance = new LinkedList<T>();


        // 将一个链表中的节点放到头部
        private void MoveToHead(LinkedListNode<T> n)
        {
            Instance.Remove(n);
            Instance.AddFirst(n);
        }
    }
}
