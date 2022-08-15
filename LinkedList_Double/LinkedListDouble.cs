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
        public Node prev;
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
                firstAdd.prev = null;
            }
            else
            {
                Node newnode = new Node();
                newnode.value = val;
                newnode.next = head;
                newnode.prev = null;
                head.prev = newnode;
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
                firstAdd.prev = null;
            }
            else
            {
                Node newnode = new Node();
                Node find = head;
                while (find.next != null)
                {
                    find = find.next;
                }
                newnode.value = val;
                newnode.prev = find;
                find.next = newnode;
                newnode.next = null;
            }
        }

         public void AddMiddle(int valIndex, int val)
        {
            if (IsNull())
            {
                Console.WriteLine("linked list Empty!!!");
            }
            else
            {
                Node newnode = new Node();
                Node find = head;
                while (find.next != null)
                {
                    find = find.next;
                    if (find.value == valIndex)
                    {
                        break;
                    }
                }
                if (find.value != valIndex)
                {
                    Console.WriteLine("adad find nashod");
                    return;
                }
                newnode.value = val;

                newnode.next = find.next;
                find.next = newnode;
                newnode.prev = find;
                if (newnode.next == null)
                {
                    return;
                }
                else
                {
                    newnode.next.prev = newnode;
                }
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
                while (lastItem.next != null)
                {
                    lastItem = lastItem.next;
                }
                if (lastItem.prev == null)
                {
                    head = null;
                }
                else
                {
                lastItem.prev.next = null;
                }
            }
        }

        public void Print() 
        {
            if (!IsNull())
            {
                Node temp = head;
                while (temp != null)
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

