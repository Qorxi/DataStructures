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
            #region      List Data structure

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

            //LinkedListNode link = new LinkedListNode();
            //link.AddToBegin(10);
            //link.AddToEndNode(20);
            //link.AddToEndNode(30);
            //link.AddToBefore(30, 40);
            //link.AddToEndNode(50);
            //link.RemoveElementBy(50);
            //link.ReverseElement(link.Root);
            //link.Print();

            //link.Print();

            #endregion

            #region     Double LinkedList strucuture

            //var doubleNode = new DoubleLinkedList();
            //doubleNode.InsertAtHeadNode(2);
            //doubleNode.Print();
            //Console.WriteLine();
            //doubleNode.ReversePrintElement();
            //Console.WriteLine();

            //doubleNode.AddLastNodeToElement(4);
            //doubleNode.Print();
            //Console.WriteLine();
            //doubleNode.ReversePrintElement();
            //Console.WriteLine();

            //doubleNode.AddLastNodeToElement(6);
            //doubleNode.Print();
            //Console.WriteLine();
            //doubleNode.ReversePrintElement();
            //Console.WriteLine();

            #endregion  Double LinkedList strucuture

            #region     Stack 

            #region     Stack structure(Array version)

            //var stk = new StackArray();
            //if (stk.IsEmpty)
            //{
            //    Console.WriteLine("Stack is empty");
            //}

            //stk.Push(10);
            //stk.Push(6);
            //stk.Push(9);

            //stk.Print();
            //Console.WriteLine();

            //stk.Pop();
            //stk.Print();
            //Console.WriteLine();
            //stk.Pop();
            //stk.Push(20);
            //stk.Print();
            //Console.WriteLine();

            //for (int i = 0; i < 400; i++)
            //{
            //    stk.Push(i);
            //}

            #endregion  Stack structure(Array version)

            #region     Stack structure(Linkedlist version)

            var stc = new LinkedStack();
            stc.Push(10);
            stc.Push(6);
            stc.Push(90);
            stc.Print();
            Console.WriteLine();
            Console.WriteLine(stc.Top);
            stc.Pop();
            stc.Pop();

            stc.Push(-45);
            stc.Print();
            Console.WriteLine(stc.Top);



        #endregion  Stack structure(Linkedlist version)

            #endregion  Stack 

            Console.ReadKey();
        }
    }

    #region      Stack structure
    
    #region      Version 1(Array implemented)
    public class StackArray
    {
        /// <summary>
        /// MAX_SIZE_STACK static stack array size
        /// </summary>
        private readonly int MAX_SIZE_STACK = 200;

        /// <summary>
        /// Top element index stored
        /// </summary>
        private int _top = -1;

        /// <summary>
        /// private stack element
        /// </summary>
        private int[] items;

        /// <summary>
        /// Constructor StackArray initialize array for static size
        /// </summary>
        public StackArray()
        {
            // initialize local array
            items = new int[MAX_SIZE_STACK];
        }

        /// <summary>
        /// Add First in Last out element to stack
        /// </summary>
        /// <param name="data"></param>
        public void Push(int Data)
        {
            if (_top == MAX_SIZE_STACK - 1)
            {
                throw new Exception("Stack overflow");
            }
            items[++_top] = Data;
        }

        /// <summary>
        /// Delete top element from stack
        /// </summary>
        public void Pop()
        {
            items[_top--] = default(int);
        }


        /// <summary>
        /// Get top index 
        /// </summary>
        /// <returns></returns>
        public int Top()
        {
            return _top;
        }

        /// <summary>
        /// Print method for all element writed console 
        /// </summary>
        public void Print()
        {
            for (int i = 0; i <= _top; i++)
            {
                Console.Write(items[i] + " ");
            }
        }


        /// <summary>
        /// Stack is empty , if _top == -1 then is empty else stack is full
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty
        {
            get
            {
                if (_top == -1)
                {
                    return true;
                }

                return false;
            }
        }

    }

    #endregion   Version 1(Array implemented)

    #region      Version 2(Linked list implementation)
    public class LinkedStack
    {
        private StackNode _top;

        public LinkedStack()
        {
            _top = null;
        }

        public void Push(int data)
        {
            var node = new StackNode(data);

            if (_top == null)
            {
                _top = node;
                return;
            }

            node.Next = _top;
            _top = node;
        }

        public void Pop()
        {
            if (_top == null)
            {
                return;
            }

            _top = _top.Next;
        }

        public void Print()
        {
            this._top.Print();
        }

        public int Top
        {
            get
            {
                if (_top == null)
                {
                    throw new ArgumentNullException("Argument null and not return integer");
                }

                return _top.Data;
            }
        }


        public bool IsEmpty
        {
            get
            {
                if (_top == null)
                {
                    return true;
                }

                return false;
            }
        }




        private class StackNode
        {
            public int Data { get; set; }

            public StackNode Next { get; set; }

            public StackNode(int data)
            {
                this.Data = data;
                this.Next = null;
            }

            public void Print()
            {
                Console.Write(Data + " ");
                if (Next != null)
                {
                    Next.Print();
                }
            }
        }
  
    }
    #endregion   Version 2(Linked list implementation)

    #endregion   Stack structure

    #region        Doubled linked list

    /// <summary>
    /// Double link node class
    /// </summary>
    public class DoubleNode
    {
        /// <summary>
        /// Data example stored data
        /// </summary>
        public int Data { get; set; }

        /// <summary>
        /// Next DoubleNode this class model
        /// </summary>
        public DoubleNode Next { get; set; }
        /// <summary>
        /// Previus DoubleNode this class model
        /// </summary>
        public DoubleNode Previus{ get; set; }

        /// <summary>
        ///  Constructor is the
        /// </summary>
        /// <param name="data"></param>
        public DoubleNode(int data)
        {
            this.Data = data;
            this.Next = null;
            this.Previus = null;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public DoubleNode() : this(default(int))
        {

        }

        /// <summary>
        /// Recursive print methid everythin next node calling and printing
        /// </summary>
        public void Print()
        {
            Console.Write(this.Data + " |");
            if (Next != null)
            {
                Next.Print();
            }
        }

    }

    public class DoubleLinkedList
    {
        // Head globl variable stored stack
        private DoubleNode Head;

        /// <summary>
        /// Default constructor
        /// </summary>
        public DoubleLinkedList()
        {
            // Initialize head is null
            this.Head = null;
        }


        /// <summary>
        /// Method added new node to head return type is integer type
        /// </summary>
        /// <param name="data">
        /// data is integer parametr
        /// </param>
        public void InsertAtHeadNode(int data)
        {
            // Get new double node
            var temp = GetNewNode(data);

            // Head is null then bind new node to head and return function
            if (this.Head == null)
            {
                this.Head = temp;
                return;
            }

            // temp Node Next pointer set this head Node
            temp.Next = this.Head;
            // Head previous pointer set temp node
            this.Head.Previus = temp;
            // Head node set to temp node
            this.Head = temp;

        }

        /// <summary>
        /// ReversePrint method recursivly print all node in double linked list
        /// </summary>
        private void ReversePrint(DoubleNode node)
        {
            // Node is null then base condition for recursiv calling
            if (node == null)
            {
                return;
            }

            // recurion calling
            ReversePrint(node.Next);

            // executed last exit condition after print part
            Console.Write(node.Data + " |");

        }

        /// <summary>
        /// ReveresePrint all element publicnu method
        /// </summary>
        public void ReversePrintElement()
        {
            this.ReversePrint(this.Head);
        }


        /// <summary>
        /// New node add last 
        /// </summary>
        /// <param name="data">
        /// variable integer variable
        /// </param>
        public void AddLastNodeToElement(int data)
        {
            // Get create new node
            var temp = GetNewNode(data);

            // Check head node double linked list
            if (this.Head == null)
            {
                // Set temp node to heads
                this.Head = temp;
                return;
            }

            // Get element last node
            var node = this.Head;

            // Whiile loopig and get last node
            while(node.Next != null)
            {
                node = node.Next;
            }

            // Set new node to last node
            node.Next = temp;
            temp.Previus = node;

        }

        public void AddAfterNode(int data)
        {
            // temp Node
            var node = GetNewNode(data);

            if (this.Head == null)
            {
                this.Head = node;
                return;
            }


        }

        /// <summary>
        /// Private local method for Creation new node
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private DoubleNode GetNewNode(int data)
        {
            // Initialize new double node 
            var node = new DoubleNode(data);
            // Node next prop set null
            node.Next = null;
            // Node previous node set nulls
            node.Previus = null;
            // return current creation node
            return node;
        }


        /// <summary>
        /// Print all current data
        /// </summary>
        public void Print()
        {
            this.Head.Print();
        }
    }

    #endregion     Doubled linked list

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
