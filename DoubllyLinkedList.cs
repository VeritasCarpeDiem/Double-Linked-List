using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Double_Linked_List
{
    class Node<T>
    {
        public T Value
        {
            get;
            private set;
         
        }

        public Node<T> Prev { get; set; }
        public Node<T> Next { get; set; }

        public Node(T val)
        {
            this.Value = val;
        }
    }
    class DoublyLinkedList<T>: IEnumerable<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }

        public DoublyLinkedList()
        {
            Head = null;
            Tail = Head;
        }
        public int Count { get; private set; }

        public void AddLast(T val)
        {
            Node<T> current = Head;
            
            if(Head ==null)
            {
                Head = new Node<T>(val);
                Tail = Head;
            }
            else
            {
                Tail.Next = new Node<T>(val);
                
                //Tail.Next.Prev = Tail; 

                Node<T> previousTail = Tail;

                Tail = Tail.Next;

                Tail.Prev = previousTail;

            }
        }
        public void AddFirst(T val)
        {
            Node<T> current = Head;
            if (Head==null)
            {
                Head = new Node<T>(val);
                Tail = Head;
            }
            else
            {
                Head.Prev = new Node<T>(val);
                Head = Head.Prev;
                Head.Next = current; 
               
            }
        }
        public bool RemoveFirst()
        {
            if (Head ==null)
            {
                return false;
               // throw new Exception("Nothing to remove!");
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
                return true;
            }
        }
        public bool RemoveLast()
        {
           
            if (Head == null)
            {
                return false;
                //throw new Exception("Nothing to remove!");
            }
            else
            {
                Tail = Tail.Prev;
                Tail.Next = null;
                //Tail.Prev = Tail.Prev.Prev;
                //current = current.Next;
                return true;
            }

        }
        public bool Remove(T val)
        {
            Node<T> current = Head;
            while(current !=null)
            {
                if(current.Value.Equals(val))
                {
                    if (current==Head)
                    {
                        RemoveFirst();
                        return true;
                    }
                    else if (current==Tail)
                    {
                        RemoveLast();
                        return true;
                    }
                    else
                    {
                        var beforeNode = current.Prev;
                        var afterNode = current.Next;

                        beforeNode.Next = afterNode;
                        afterNode.Prev = beforeNode;

                        return true;
                    }
                }
                current = current.Next;
            }
            return false;
        }
        public void PrintForwards()
        {
            Node<T> current = Head;
            while(current != null)
            {
                Console.Write(current.Value +" , ");
                
                current = current.Next;
            }
            Console.WriteLine();
        }
        public void PrintBackwards()
        {
            Node<T> current = Tail;
            while(current != null)
            {
                Console.Write(current.Value+ " , ");
                current = current.Prev;
            }
            Console.WriteLine();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while(current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
            //throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

   
}
