using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Double
{

    public class Node
    {
        public int value;
        public Node next;
        public Node priv;
    }


    public class LinkedListDouble
    {
        Node head;
        private bool IsNull()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddFirst(int val)
        {
            if (IsNull())
            {
                Node firstAdd = new Node();
                head = firstAdd;
                firstAdd.value = val;
                firstAdd.next = null;
                firstAdd.priv = null;
            }
            else
            {
                Node newnode = new Node();
                newnode.value = val;
                newnode.next = head;
                newnode.priv = null;
                head.priv = newnode;
                head.next = null;
                head = newnode;
            }
        }

        public void AddLast(int val)
        {
            if (IsNull())
            {
                Node firstAdd = new Node();
                head = firstAdd;
                firstAdd.value = val;
                firstAdd.next = null;
                firstAdd.priv = null;
            }
            else
            {
                Node newnode = new Node();
                Node find = head;
                while (head.next != null)
                {
                    find = find.next;
                }
                newnode.value = val;
                newnode.priv = find;
                find.next = newnode;
                newnode.next = null;
            }
        }

        public void DeleteFirst()
        {
            if (IsNull())
            {
                Console.WriteLine("Empty !!!");
            }
            else
            {
                Node node = head.next;
                head = null;
                head = node;
            }
        }

        public void DeleteLast()
        {
            if (IsNull())
            {
                Console.WriteLine("Empty !!!");
            }
            else
            {
                Node lastItem = head;
                while (head.next != null)
                {
                    lastItem = lastItem.next;
                }
                if (lastItem.priv == null)
                {
                    head = null;
                }
                else
                {
                lastItem.priv.next = null;
                }
            }
        }

        public void Print() 
        {
            if (IsNull())
            {
                Node temp = head;
                while (temp == null)
                {
                    Console.WriteLine(temp.value);
                    temp = temp.next;
                }
            }
            else
            {
                Console.WriteLine("Empty !!!");
            }
        }
    }


}
