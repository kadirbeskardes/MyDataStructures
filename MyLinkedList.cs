using System;

namespace MyDataStructures
{
    public class MyLinkedList
    {
        private MyLinkedListNode Head = null;
        private MyLinkedListNode temp = null;

        public MyLinkedList()
        {
            Head = null;
            temp = null;
        }

        public void AddFirst(object value)
        {
            MyLinkedListNode newBl = new MyLinkedListNode();
            newBl.Data = value;
            newBl.Next = Head;
            Head = newBl;
        }
        private MyLinkedListNode GetHead()
        {
            return this.Head;
        }
        public void DeleteNextNode(object x)
        {
            temp = Head;
            while (temp != null)
            {
                if (temp.Data == x)
                {
                    temp.Next = temp.Next.Next;
                    break;
                }
                temp = temp.Next;
            }
        }
        public void AddLast(object value)
        {
            MyLinkedListNode newBl = new MyLinkedListNode();
            newBl.Data = value;
            if (Head == null)
            {
                newBl.Next = Head;
                Head = newBl;
            }
            else
            {
                temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
            }
            temp.Next = newBl;
        }
        public void RemoveFirst()
        {
            Head = Head.Next;
        }
        public void RemoveLast()
        {
            temp = Head;
            while (temp.Next.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = null;
        }
        public void Remove(object value)
        {
            temp = Head;
            while (temp.Next != null)
            {
                if (temp.Next.Data == value)
                {
                    temp = temp.Next.Next;
                }
                else
                {
                    temp = temp.Next;
                }
            }
        }
        public void Clear()
        {
            Head = null;
        }
        public object GetByIndex(int index)
        {
            temp = Head;
            for (int i = 1; i < index; i++)
            {
                temp = temp.Next;
            }
            return temp.Data;
        }
        public void PrintList()
        {
            temp = Head;
            while (temp != null)
            {
                if (temp.Data.GetType() == typeof(Int32[]))
                {
                    var array = (Int32[])temp.Data;
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write($"{array[i]},");
                    }
                    Console.WriteLine();
                }
                else Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
        public int GetCount()
        {
            int count = 0;
            temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
                count++;
            }
            return count;
        }
        public void Concat(MyLinkedList list2)
        {
            temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = list2.GetHead();
        }
        public bool Equals(MyLinkedList other)
        {
            temp = this.Head;
            var temp2 = other.GetHead();
            while (temp != null)
            {
                if (temp.Data == temp2.Data)
                {
                    temp = temp.Next;
                    temp2 = temp2.Next;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
