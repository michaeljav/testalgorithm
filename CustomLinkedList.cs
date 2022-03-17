using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testalgorithm
{
    class CustomLinkedList
    {
        Node head;

        public class Node
        {
            public int data;
            public Node next;

            public Node(int d) { data = d; }
        }

        public void deleteBackHalf()
        {
           if (head == null || head.next == null)
            {
                head = null;
            }

            Node prev = null;
            Node slow = head;
            Node fast = head;
           

            while (fast != null && fast.next !=null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }
            //this delete the middle node and everything after it
            prev.next = null;
        }
        public void displayContents()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + "->");
                current = current.next;
            }
        }
       
        static void Main(string[] args)
        {
            CustomLinkedList linkedlist = new CustomLinkedList();
            Node firstNode = new Node(1);
            Node secondNode = new Node(2);
            Node thirdNode = new Node(3);
            Node fourthNode = new Node(4);
            Node fifNode = new Node(5);
            Node sixthNode = new Node(6);
            Node sev = new Node(7);
            Node ei = new Node(8);
            Node nin = new Node(9);
            Node ten = new Node(10);
            Node el = new Node(11);
            Node tw = new Node(12);
            Node th = new Node(13);
            //Node el = new Node(14);

            linkedlist.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;

            fourthNode.next = fifNode;
            fifNode.next = sixthNode;
            sixthNode.next = sev;
            sev.next = ei;
            ei.next = nin;
            nin.next = ten;
            ten.next = el;
            el.next = tw;
            tw.next = th;



            linkedlist.displayContents();
            linkedlist.deleteBackHalf();
            Console.WriteLine();
            linkedlist.displayContents();

            //LinkedList<int> listTest = new LinkedList<int>();
            //for (int i = 0; i < 8; i++)
            //{
            //    listTest.AddLast(i);
            //}

            //listTest.Remove(5);
            


        }
    }
}
