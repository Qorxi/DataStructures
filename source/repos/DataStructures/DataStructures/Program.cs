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
            #region       Data structure implement(example part) (C#) [...]

            #region       Linear data structures

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

            //var stc = new LinkedStack();
            //stc.Push(10);
            //stc.Push(6);
            //stc.Push(90);
            //stc.Print();
            //Console.WriteLine();
            //Console.WriteLine(stc.Top);
            //stc.Pop();
            //stc.Pop();

            //stc.Push(-45);
            //stc.Print();
            //Console.WriteLine(stc.Top);



            #endregion  Stack structure(Linkedlist version)

            #endregion  Stack 

            #region      Queue 

            #region      Array implementation

            //QueueStructure que = new QueueStructure(4);
            //que.Enqueue(10);
            //que.Enqueue(20);
            //que.Enqueue(30);
            //que.Enqueue(40);
            //que.Dequeue();
            //que.Dequeue();
            //que.Dequeue();
            ////Console.WriteLine(que.Front());
            //que.Enqueue(50);
            //que.Enqueue(60);
            //Console.WriteLine(que.Dequeue());
            ////Console.WriteLine(que.Front());
            //Console.WriteLine(que.Dequeue());
            //Console.WriteLine(que.Dequeue());


            //Console.WriteLine(que.Dequeue());

            #endregion   Array implementation

            #region      LinkedList implementation

            //QueueLinkedinStructure queueLink = new QueueLinkedinStructure();
            //queueLink.Enqueue(10);
            //queueLink.Dequeue();
            //queueLink.Dequeue();

            //// list array
            //queueLink.Dequeue();




            #endregion   LinkedList implementation

            #endregion  End of paritito Queue 

            #endregion    End of Linear data structures

            #region       Tree, traversal, graph data structures

            #region       Binary tree

            BinarySearchTree bnTree = new BinarySearchTree();
            bnTree.RootNode = bnTree.InsertRecursion(bnTree.RootNode, 15);
            bnTree.RootNode = bnTree.InsertRecursion(bnTree.RootNode, 10);
            bnTree.RootNode = bnTree.InsertRecursion(bnTree.RootNode, 20);

            bnTree.RootNode = bnTree.InsertRecursion(bnTree.RootNode, 25);
            bnTree.RootNode = bnTree.InsertRecursion(bnTree.RootNode, 30);


            ///Console.WriteLine(bnTree.FindMinElementRecursiv(bnTree.RootNode));
            //Console.WriteLine(bnTree.FindMaxDepth(bnTree.RootNode));

            //bnTree.LevelOrderTraversal(bnTree.RootNode);

            bnTree.InOrderTraversal(bnTree.RootNode);



            /* @@@@@@@@@@@@@@@@@@@ This approach for iterative search @@@@@@@@@@@@@@@@@@

            while(string.IsNullOrWhiteSpace(exitMessage))
            {
                var num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(bnTree.Search(bnTree.RootNode, num) ? "Found" : "NotFound");
                Console.WriteLine("Are you sure exit ? ");
                exitMessage = Console.ReadLine();
            }


            if (string.IsNullOrWhiteSpace(exitMessage))
            {
                Console.WriteLine(bnTree.Search(bnTree.RootNode, Convert.ToInt32(Console.ReadLine())) ? "Found" : "NotFound");
            }
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@ End of part @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ */

            /*@@@@@@@@@@@@@ Recursive variant method example search method @@@@@@@@@@@@@*/

            #endregion    Binary tree

            #endregion    End of Tree, traversal, graph data structures

            #endregion    End of Data structure implement(example part) (C#) [...]


            Console.ReadKey();
        }
    }


    #region      Data structure implement(implementattions part) (C#) [...]

    #region      Linear data structures implamenetation part   [...]

    #region     Queue structure

    #region      Array implementation

    //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@  Array implementation structure algorithm @@@@@@@@@@@@@@@@@@@@@@@@@@@@
    /* Queue structure front and rear. Front ve rear başlanğıc qiymetleri ilk zaman -1 beraberdir.
     * Front növbenin başlandığı hissedir, növbe ilk element əlavə edildiyi zaman front hemin index
     * alır qiymetini yeni increment ve 1 olur rear her element əlavə edildiyi zaman index ona uyğun
     * olaraq bir qiymət artım göstərir.Hər element lavə edilsin vı rear qiymət artsın silinmə zamanı
     * front qitməti bir artırılır sağa sürüşdürmə edilir, rear isə öz yerinde qalır.
     * Uyğun əməliyyatlar zamanl massiv front yeni başlanğıcdan silinmə olduğuna görə
     * elementlər boşluq yaranır bun qarşısına əsasən circylar array anlayışı istifadə olunur
     * yəni next pos element element_index % array.length edilerek tapılır.Rear son indexe
     * qədər gəlib isə bu zaman rear qiymət artır maasiv ölçüsünden eve % mod alma zamanı
     * index 0 qayıtdığından başdaj  dequqe olunan elementlerə yeniləri əlavə edilir.
     * İmplementasiya aşağıdakı kimidir.
     */
    //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    public class QueueStructure
    {
        // local array
        private int[] array;

        /// <summary>
        /// Local number for less then zeor num (queue tail)
        /// </summary>
        private int rear = -1;

        /// <summary>
        /// Local number for lesst then zeor (Queue head point)
        /// </summary>
        private int front = -1;


        // Array size
        private int N;


        /// <summary>
        /// Constructor is strcute queue class
        /// </summary>
        /// <param name="arraySize"></param>
        public QueueStructure(int arraySize)
        {
            // ser local array to size
            array = new int[arraySize];
            N = array.Length;
        }

        /// <summary>
        /// Enqueue method is 
        /// </summary>
        /// <param name="data"> whatever integer </param>
        public void Enqueue(int data)
        {
            // Array is full
            if ((rear + 1) % N == front)
            {
                Console.WriteLine("Queue is fulled");
                return;
            }

            // If first element pushed to queue
            if (this.front == -1 && this.rear == -1)
            {
                ++front;
            }


            // Settin element to queue
            array[(rear++ + 1) % N] = data;
        }


        /// <summary>
        /// Dequeue function element remove the array first left,
        /// and rear and front equal -1 then return throw exception
        /// Element rear great then N array lenth and rear mode length equal fron element index
        /// then element rear and front set -1 else condition fron circylar increment set value
        /// return temp remove element
        /// </summary>
        /// <returns></returns>
        public int Dequeue()
        {
            // rear and frot eqeual -1 queue equl 
            if (this.rear == -1 && this.front == -1)
            {
                throw new Exception("Queue is empty, dont dequque element from empty queue");
            }

            // Get removed element from array temp
            var temp = array[front];

            // array remove element set default elementy
            array[front] = default(int);

            // condition removed element first .. range array and circylar condition return -1 both 
            if (this.rear == this.front || (this.rear > N && ((this.rear) % N) == this.front))
            {
                this.rear = this.front = -1;
            }
            else
            {
                // front circylar increment
                front = (front + 1) % N;
            }


            return temp;
        }

        /// <summary>
        /// Empty property queue is empty or full
        /// </summary>
        public bool IsEmpty
        {
            get
            {
                // return queue is empty nothing added element
                if (this.rear == -1 && this.front == -1)
                {
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// Front method return queue start element
        /// </summary>
        /// <returns></returns>
        public int Front()
        {
            // return queue start at index'th element
            return array[front];
        }

    }

    #endregion   End of part

    #region      LinkedList implementation
    //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@  Algortih quque implement to linkedlist @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    /* Elementləri əlavə etmək üçün fron və rear adlı iki dəyişən istifadə edilir. Front anlam laraq linkedList
     * normal qaydalardan bəlli olan list head olaraq anlaşılmalıdır. Queue implementasiya time complexity 
     * Big(O(1)) olamalıdır. Normal qayidə ilə implementasiya zamanı linkedlist 1 element olduğundan yeni emelent
     * head əlavə edilrkən Big((1)) və remove yəni dequque() method zamanı O(1) time complexity bırabır olur. Ancaq
     * listə yeni ele element əlav etmək üçün normal qaydalar head node istifadə edərək,son elementə qədər getməli
     * (bu iteariya və ya dovr quraraq mümkündür) və sondakı elemet=nt next pointerına yeni vahid əlavə edilinir.Bu
     * əməliyyat zamanı Big(O(n)) baş veriri bu queueb implementasiya zamanı aşdıqdan dolayı linkedList yeni implementasiya
     * yəni quyruq(tail) və ya rear saxlanılacaq, fron linkedList head nodu rear isə itereasoya elementi olacaq bu zaman
     * bütün element əəliyyatlar enqueue, dequque time complexity = Big(O(1)) -olur */
    //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    public class QueueLinkedinStructure
    {

        // Front start element or list head root
        private LinkNode front;

        // Element rear iteration
        private LinkNode rear;

        private LinkNode returnElement;

        /// <summary>
        /// Enqueue method add element to 
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(int data)
        {
            // Get new node
            var node = GetNode(data);

            // First element added to list
            if (this.rear == null && this.front == null)
            {
                this.front = this.rear = node;
                return;
            }

            // Addd new element
            this.rear.Next = node;
            this.rear = node;
        }

        /// <summary>
        /// Dequeue method remove queue element and return removed element
        /// </summary>
        /// <returns></returns>
        public LinkNode Dequeue()
        {
            // rear and front equal null then queue is empty
            if (this.front == null && this.rear == null)
            {
                throw new Exception("Queue is empty");
            }

            // temp removed element
            returnElement = this.front;

            // removed element next is null then rear equal null
            if (returnElement.Next == null)
            {
                this.rear = null;
            }

            // removed head front element next pointer after element
            this.front = this.front.Next;

            // return removed element
            return returnElement;
        }


        /// <summary>
        /// Front element return property 
        /// </summary>
        public LinkNode Front
        {
            get
            {
                // Front element is equal null then property return null
                if (this.front == null)
                {
                    return null;
                }

                return this.front;
            }
        }


        /// <summary>
        /// Property queue is empty or fulled 
        /// </summary>
        public bool Empty
        {
            get
            {
                return this.rear == null && this.front == null ? true : false;
            }
        }


        /// <summary>
        /// Method retur new node 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private LinkNode GetNode(int data)
        {
            // Get node
            var node = new LinkNode(data);
            return node;
        }
    }



    #endregion   End of part

    #endregion  Queue structure

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
        public DoubleNode Previus { get; set; }

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
            while (node.Next != null)
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

            var next = node.Next;

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

    #endregion   End of Linear data structures implamenetation part  [...]

    #endregion   End of Data structure implement(implementattions part) (C#)[...]

    #region      NoneLinear Data Structure [...]

    #region      Binary Tree

    /// <summary>
    /// Binary tree Node
    /// </summary>
    public class BinaryNode
    {
        /// <summary>
        /// Data integer storaged 
        /// </summary>
        public int Data { get; set; }

        /// <summary>
        /// Left node storaged, left tree nodes
        /// </summary>
        public BinaryNode LeftNode { get; set; }

        /// <summary>
        /// Right node storaged, right tree nodes
        /// </summary>
        public BinaryNode RightNode { get; set; }

        /// <summary>
        /// Constrauctor TreeNoe clas
        /// </summary>
        /// <param name="Data"></param>
        public BinaryNode(int Data)
        {
            // Data node 
            this.Data = Data;
            // Left and Right tree self nodes
            this.LeftNode = null;
            this.RightNode = null;
        }
    }


    /// <summary>
    ///Class storaged binary tree implementattion methods
    /// </summary>
    public class BinarySearchTree
    {
        // Tree root node
        public BinaryNode RootNode = null;

        /// <summary>
        /// Class default constructor
        /// </summary>
        public BinarySearchTree()
        {

        }


        /// <summary>
        /// Binary tree insert using recursion method
        /// </summary>
        /// <param name="node">new Node</param>
        /// <param name="data">input parametr</param>
        /// <returns></returns>
        public BinaryNode InsertRecursion(BinaryNode node, int data)
        {
            if (node == null)
            {
                node = GetNewNode(data);
            }
            else if (node.Data > data)
            {
                node.LeftNode = InsertRecursion(node.LeftNode, data);
            }
            else if (node.Data < data)
            {
                node.RightNode = InsertRecursion(node.RightNode, data);
            }

            return node;
        }

        /// <summary>
        /// Insert data to binary tree with iterativ method
        /// </summary>
        /// <param name="data">
        /// nonegeneric data type Integer
        /// </param>
        public void Insert(int data)
        {
            // Root node is null
            if (this.RootNode == null)
            {
                this.RootNode = GetNewNode(data);
                return;
            }

            // Current node is equal root node
            var current = this.RootNode;
            // Added is falses
            bool IsAdded = false;

            // Recursice loop is not added
            while (!IsAdded)
            {
                // Cuurent node data greate then data is num match left node
                if (current.Data > data)
                {
                    // Current is not a left node
                    if (current.LeftNode == null)
                    {
                        // Added left node
                        current.LeftNode = GetNewNode(data);
                        // Added is true
                        IsAdded = !IsAdded;
                    }
                    else
                    {
                        // Added is not change node to left 
                        current = current.LeftNode;
                    }
                }
                else
                {
                    // Cuurent node is match right node 
                    if (current.RightNode == null)
                    {
                        // This node is right node equal null then set right nide
                        current.RightNode = GetNewNode(data);
                        // Added element is added set trues
                        IsAdded = !IsAdded;
                    }
                    else
                    {
                        // Change rotation to right node
                        current = current.RightNode;
                    }
                }
            }
        }


        public BinaryNode DeleteNode(BinaryNode node, int data)
        {
            // Tree is empty
            if (node == null)
            {
                return node;
            }
            // Data is great and direction to right sub tree
            else if(node.Data > data)
            {
                node.RightNode = DeleteNode(node.RightNode, data);
            }
            // Data is less then direction to left sub tree
            else if (node.Data < data)
            {
                node.LeftNode = DeleteNode(node.LeftNode, data);
            }
            else // Found the element
            {
                // 1. Case delete element from tree, No chield
                if (node.LeftNode == null && node.RightNode == null)
                {
                    node = null;
                }
                // 2. Case one chield
                else if (node.LeftNode == null)
                {
                    node = node.RightNode;
                }
                else if (node.RightNode == null)
                {
                    node = node.LeftNode;
                }
                // 3. Case two chield
                else
                {
                    var tempNode = GetNewNode(FindMinElementRecursiv(node.RightNode));
                    node = tempNode;
                    DeleteNode(node.RightNode, data);
                }
            }
            return node;
        }


        /// <summary>
        /// Search in binary tree
        /// </summary>
        /// <param name="node"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Search(BinaryNode node, int data)
        {
            // Node is null then false
            if (node == null)
            {
                return false;
            }
            // Node data is equal search node data then return true
            else if (node.Data == data)
            {
                return true;
            }
            // Node data is lesst then data then rotation root direction to left node
            else if (node.Data > data)
            {
                return Search(node.LeftNode, data);
            }
            // Node data is great then data rotation root direction to right node
            else if (node.Data < data)
            {
                return Search(node.RightNode, data);
            }
            // This constitin return false
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Method is recursivle min element found is tree
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int FindMinElementRecursiv(BinaryNode node)
        {
            // Root element is null
            if (node == null)
            {
                Console.WriteLine("Tree is empty ");
                return default(int);
            }

            // Node left node is null then serchabe min element array is this
            if (node.LeftNode == null)
            {
                return node.Data;
            }

            // return recursion
            return FindMinElementRecursiv(node.LeftNode);
        }

        /// <summary>
        /// Fin minimum element from binaty tree(Iterative using)
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int FindMinElement(BinaryNode node)
        {
            // If root is null
            if (node == null)
            {
                Console.WriteLine("Tree is empty");
                return default(int);
            }

            // While looping direction enf od the left node
            while (node.LeftNode != null)
            {
                node = node.LeftNode;
            }

            // Return node data
            return node.Data;
        }


        /// <summary>
        /// Find max element in tree using Recuirsive method
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int FindMaxElementRecursiv(BinaryNode node)
        {
            // Root element is null
            if (node == null)
            {
                Console.WriteLine("Tree is empty ");
                return default(int);
            }

            // Node left node is null then searchable max element array is this
            if (node.RightNode == null)
            {
                return node.Data;
            }

            // return recursion
            return FindMaxElementRecursiv(node.LeftNode);
        }


        /// <summary>
        /// Method finding max element in tree(Iterative using)
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int FindMaxElement(BinaryNode node)
        {
            // If root is null
            if (node == null)
            {
                Console.WriteLine("Tree is empty");
                return default(int);
            }

            // While looping direction enf od the rigth node
            while (node.RightNode != null)
            {
                node = node.LeftNode;
            }

            // Return node data
            return node.Data;
        }



        /// <summary>
        /// Private maxt depth recursive element
        /// </summary>
        /// <param name="node"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        private int FindMaxDepth(BinaryNode node, int level)
        {
            if (node == null)
            {
                return level - 1;
            }
            level++;

            return Math.Max(FindMaxDepth(node.LeftNode, level), FindMaxDepth(node.RightNode, level)) ;
        }


        /// <summary>
        /// Find maxt depth element of binary tree
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int FindMaxDepth(BinaryNode node)
        {
            // return max depth tree root
            return FindMaxDepth(node, 0);
        }


        #region      Binary Tree Traversal

        #region      Level order traversal (Breadht)
        /// <summary>
        /// Binary tree breadth traversal with queue
        /// </summary>
        /// <param name="node"></param>
        public void LevelOrderTraversal(BinaryNode node)
        {
            // Node is null return traversal
            if (node == null)
            {
                Console.WriteLine("Binary tree is empty");
                return;
            }

            // create queue for level traversal tree
            var queue = new Queue<BinaryNode>();

            // Added tree to queue
            queue.Enqueue(node);

            // Queue count greate then zero
            while(queue.Count > 0)
            {
                // Current element at queue
                var current = queue.Peek();
                // Print element data
                Console.WriteLine(current.Data);
                // Current left node is not nll then added queue
                if (current.LeftNode != null)
                {
                    queue.Enqueue(current.LeftNode);
                }
                // Current right node is not null then added queue
                if (current.RightNode != null)
                {
                    queue.Enqueue(current.RightNode);
                }
                
                //Remove element in queue
                queue.Dequeue();
            }

        }

        #endregion   End of level order traversal

        #region      Deapth Level traversal

        /// <summary>
        /// PreOrder traversal in binary tree
        /// </summary>
        /// <param name="node">
        /// Every node storaged integer type data
        /// </param>
        public void PreOrderTraversal(BinaryNode node)
        {
            // Node is null then return method
            if (node == null)
            {
                return;
            }

            // Print element to console
            Console.Write(node.Data + " ");
            // Recursive left sub tree
            PreOrderTraversal(node.LeftNode);
            // Recursive right sub tree
            PreOrderTraversal(node.RightNode);
        }


        /// <summary>
        /// InOrder traversal sub tree 
        /// </summary>
        /// <param name="node">
        /// Every node storaged integer type data
        /// </param>
        public void InOrderTraversal(BinaryNode node)
        {
            // Node is null return method or base exit condition recursive method
            if (node == null)
            {
                return;
            }

            // Recursive left sub tree
            InOrderTraversal(node.LeftNode);
            // print to console
            Console.Write(node.Data + " ");
            // Recursibe right sub tree
            InOrderTraversal(node.RightNode);
        }


        /// <summary>
        /// PostOrder traversal sub tree
        /// </summary>
        /// <param name="node">
        /// Every node storaged integer type data
        /// </param>
        public void PostOrderTraversal(BinaryNode node)
        {
            // Node is null return method or base exit condition recursive method
            if (node == null)
            {
                return;
            }
           
            // Recursive left sub tree
            PostOrderTraversal(node.LeftNode);
            // Recursive right sub tree
            PostOrderTraversal(node.RightNode);
            // Print to console
            Console.Write(node.Data + " ");
        }

        #endregion   End of deapth Level traversal

        #endregion   End of binary Tree Traversal


        /// <summary>
        /// Get create new node
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private BinaryNode GetNewNode(int data)
        {
            // Create new node
            var newNode = new BinaryNode(data);
            return newNode;
        }


    }



    #endregion   End of Binary tree

    #endregion   NoneLinear Data Structure [...]


}
