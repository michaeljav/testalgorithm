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

            Node slow = head;
            Node fast = head;
            Node prev = null;

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
            Node firstNode = new Node(3);
            Node secondNode = new Node(4);
            Node thirdNode = new Node(5);
            Node fourthNode = new Node(6);
            Node fifNode = new Node(7);
            Node sixthNode = new Node(8);

            linkedlist.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;

            fourthNode.next = fifNode;
            fifNode.next = sixthNode;

            linkedlist.displayContents();
            linkedlist.deleteBackHalf();
            Console.WriteLine();
            linkedlist.displayContents();
            

        }
    }
}
