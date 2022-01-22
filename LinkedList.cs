using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();

        A:
            Console.WriteLine("select an operation ?\n\tAdd Element in LinkedList : Press 1\n\tDelete Element from LinkedList : Press 2\n\tCheck Element at Any Node : Press 3\n\tDisplay LinkedList Elements : Press 4");
            int reply = Convert.ToInt32(Console.ReadLine());

            if (reply == 1)
            {
                Console.WriteLine("How many elements would you like to add to Linked List ?");
                int howMany = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= howMany; i++)
                {
                    Console.WriteLine("Put Element in Linked List");
                    string elementToPut = Console.ReadLine();
                    list.Add(elementToPut);
                }
            }
            else if (reply == 2)
            {
                Console.WriteLine("Which node would you like to Delete ? e.g 4");
                int elementToDelete = Convert.ToInt32(Console.ReadLine());
                list.Delete(elementToDelete);
            }
            else if (reply == 3)
            {
                Console.WriteLine("At Which node would you like to Check ? e.g 3");
                int elementToCheck = Convert.ToInt32(Console.ReadLine());

                list.Retrieve(elementToCheck);
            }
            else if (reply == 4)
            {
                Console.WriteLine("Here is Your LinkedList");
                list.ListNodes();
            }
            goto A;

        }
    }
    public class Node
    {
        public object NodeContent;
        public Node Next;

        public Node(object Content)
        {
            this.NodeContent = Content;
        }
    }
    public class List
    {
        public Node head;
        public Node current;
        private int size;

        public int Count
        {
            get
            {
                return size;
            }
        }
        public List()
        {
            size = 0;
            head = null;
        }
        public void Add(object content)
        {
            size++;

            Node node = new Node(content);

            if (head == null)
            {
                head = node;
            }
            else
            {
                current.Next = node;
            }
            current = node;
        }
        public void ListNodes()
        {
            Node tempNode = head;

            while (tempNode != null)
            {
                Console.WriteLine(tempNode.NodeContent);
                tempNode = tempNode.Next;
            }
        }
        public void Retrieve(int Position)
        {
            if (head == null)
            {
                Console.WriteLine("Linklist Empty");
            }
            else
            {
                Node tempNode = head;
                Node retNode = null;
                int count = 0;

                while (tempNode != null)
                {
                    if (count == Position - 1)
                    {
                        retNode = tempNode;
                        break;
                    }
                    count++;
                    tempNode = tempNode.Next;
                }
                Console.WriteLine("The Element at Node " + Position + " is " + retNode.NodeContent);

            }
        }
        public bool Delete(int Position)
        {
            if (Position == 1)
            {
                //Node tempNode = head;
                //head.Next = tempNode;
                //head = tempNode;

                //head = null;
                //current = null;

                Console.WriteLine("This operation can not be completed with node selected, please again with an alternative node");

                return true;
            }
            if (Position > 1 && Position <= size)
            {
                Node tempNode = head;

                Node lastNode = null;
                int count = 0;

                while (tempNode != null)
                {
                    if (count == Position - 1)
                    {
                        lastNode.Next = tempNode.Next;
                        return true;
                    }
                    count++;

                    lastNode = tempNode;
                    tempNode = tempNode.Next;
                }
            }
            return false;
        }
    }
}
