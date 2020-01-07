using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            #region      List data structure

            //List<int> arr = new List<int>();
            //Console.WriteLine("ArrayWork is capacity = " + arr.Capacity + " elements count " + arr.Count);
            //arr.Add(1);
            //arr.Add(2);
            //arr.Add(3);
            //arr.Add(4);
            //Console.WriteLine("ArrayWork is capacity = " + arr.Capacity + " elements count " + arr.Count);
            //arr.Add(5);
            //Console.WriteLine("ArrayWork is capacity = " + arr.Capacity + " elements count " + arr.Count);
            //if (arr.Remove(4))
            //{
            //    Console.WriteLine("ArrayWork is capacity after removing element = " + arr.Capacity + " elements count " + arr.Count);
            //}

            //for (int i = 0; i < arr.Capacity; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //int[] ArrayWork = new int[8];
            //ArrayWork[0] = 1;
            //ArrayWork[1] = 2;
            //ArrayWork[2] = 3;
            //ArrayWork[3] = 4;
            //ArrayWork[4] = 5;

            //for (int i = 0; i < ArrayWork.Length; i++)
            //{
            //    Console.WriteLine(ArrayWork[i]);
            //}

            //Console.WriteLine("After remove my ArrayWork");

            //ArrayWork.Copy(ArrayWork, 4, ArrayWork, 3, 5 - 3);

            //for(int i = 0; i < ArrayWork.Length; i++)
            //{
            //    Console.WriteLine(ArrayWork[i]);
            //}


            //ArrayWork[3] = default(int);

            //for (int i = 0; i < ArrayWork.Length; i++)
            //{
            //    Console.WriteLine(ArrayWork[i]);
            //}

            #endregion   List data structure

            #region     LinkedList

            LinkedListNode link = new LinkedListNode();
            link.AddToBegin(10);
            link.AddToEndNode(20);
            link.AddToEndNode(30);
            link.AddToBefore(30, 40);
            link.AddToEndNode(50);
            link.RemoveElementBy(50);
            link.ReverseElement(link.Root);
            link.Print();

            //link.Print();

            #endregion

            Console.ReadKey();
        }
    }

    #region      Linked list data structure

    public class LinkNode
    {
        public int Data { get; set; }
        public LinkNode Next { get; set; }

        public LinkNode(int data)
        {
            Data = data;
            Next = null;
        }


        public void Display()
        {
            Console.Write(" | " + Data);
            if (Next != null)
            {
                Next.Display();
            }
        }

    }


    public class LinkedListNode
    {
        public LinkNode Root;

        public LinkedListNode()
        {
            this.Root = null;
        }

        public void RemoveEndElement()
        {
            if (this.Root == null)
            {
                return;
            }

            if (this.Root.Next == null)
            {
                this.Root = null;
                return;
            }

            RemoveEndElement(this.Root);
        }


        public void RemoveFirstElement()
        {
            if (this.Root == null)
            {
                return;
            }

            this.Root = this.Root.Next;

        }

        public void RemoveElementBy(int data)
        {
            if (this.Root == null)
            {
                return;
            }

            if (this.Root.Data == data)
            {
                this.Root = this.Root.Next;
                return;
            }

            RemoveElementBy(this.Root, data);
        }

        public void AddToEndNode(int data)
        {
            if (GetSetRootData(data))
            {
                return;
            }
            // Add end element to linked list
            AddToEnd(this.Root, data);
        }

        public void AddToBegin(int data)
        {
            if (GetSetRootData(data))
            {
                return;
            }

            var tempNode = new LinkNode(data);
            tempNode.Next = this.Root;
            this.Root = tempNode;
        }

        public void AddToAfter(int find, int data)
        {
            if (GetSetRootData(data))
            {
                return;
            }

            AddToAfterNode(Root, find, data);
        }

        public void AddToBefore(int find, int data)
        {
            if (GetSetRootData(data))
            {
                return;
            }

            AddToBeforeNode(Root, find, data);
        }

        private void RemoveEndElement(LinkNode node)
        {
            if (node.Next == null)
            {
                node.Next = null;
                return;
            }
            RemoveEndElement(node.Next);
        }

        private void RemoveElementBy(LinkNode node, int data)
        {
            if (node.Next != null)
            {
                if (node.Next.Data == data)
                {
                    node.Next = node.Next.Next;
                    return;
                }
                else
                {
                    RemoveElementBy(node.Next, data);
                }
            }
            else
            {
                return;
            }
        }


        private void AddToAfterNode(LinkNode node, int find, int data)
        {
            if (node.Next == null && node.Data != find)
            {
                return;
            }

            if (node.Data == find)
            {
                var tempNode = new LinkNode(data);
                tempNode.Next = node.Next;
                node.Next = tempNode;
            }
            else
            {
                AddToAfterNode(node.Next, find, data);
            }
        }

        private void AddToBeforeNode(LinkNode node, int find, int data)
        {
            if (node.Next == null)
            {
                if (node.Data != find)
                {
                    return;
                }
                else
                {
                    AddToBegin(data);
                    return;
                }
            }

            if (node.Next.Data == find)
            {
                var tempNode = new LinkNode(data);
                tempNode.Next = node.Next;
                node.Next = tempNode;
            }
            else
            {

                AddToBeforeNode(node.Next, find, data);
            }
        }


        private void AddToEnd(LinkNode node, int data)
        {
            if (node.Next == null)
            {
                node.Next = new LinkNode(data);
                return;
            }
            else
            {
                this.AddToEnd(node.Next, data);
            }
        }


        public void Print()
        {
            if (this.Root != null)
            {
                this.Root.Display();
            }
        }


        private bool GetSetRootData(int data)
        {
            if (this.Root == null)
            {
                this.Root = new LinkNode(data);
                return true;
            }
            return false;
        }

        public void PrintReverse(LinkNode node)
        {
            if (node == null)
            {
                return;
            }

            PrintReverse(node.Next);

            Console.Write(node.Data + " ");
        }

        public void ReverseElement(LinkNode node)
        {
            if (node.Next == null)
            {
                Root = node;
                return;
            }

            ReverseElement(node.Next);

            var next =  node.Next;

            next.Next = node;

            node.Next = null;
        }

             
    }

    #endregion   Linked list data structure

    #region     ArrayWork link
    public class ArrayWork
    {
        private int[] inits;
        private int count;

        public ArrayWork(int capacity)
        {
            inits = new int[capacity];
        }

        public void Add(int item)
        {
            if (inits.Length == count)
            {
                var newArrayWork = new int[count * 2];

                for (int i = 0; i < count; i++)
                {
                    newArrayWork[i] = inits[i];
                }

                inits = newArrayWork;
            }

            inits[count++] = item;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(inits[i]);
            }
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentException("Index out of range");
            }

            count--;

            if (index < count)
            {
                for (int i = index; i < count; i++)
                {
                    inits[i] = inits[i + 1];
                }
            }

            inits[count] = default(int);
        }
    }
    #endregion  ArrayWork link
}
