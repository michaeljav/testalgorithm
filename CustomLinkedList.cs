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

            linkedlist.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;

            linkedlist.deleteBackHalf();
            

        }
    }
}
