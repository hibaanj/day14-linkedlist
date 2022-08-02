using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC5_linkedlist
{
    internal class Linkedlist
    {

        public Node head;
        //method add
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine($"{node.data} addaed to linked list");
        }
        //to add value in the front instead of last
        public void Infront(int data) // add front to the list
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = null;
            else
            {
                node.next = this.head; //shifting the address from head to new nodes next
                this.head = node;
            }
            Console.WriteLine($" {node.data} is added to the front");
        }
        public void InMiddle(int data) // add niddle to the list
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = this.head;
                Node middle = this.head;
                while (temp.next != null && temp.next.next != null)
                {
                    temp = temp.next.next;
                    middle = temp.next;
                }
                node.next = middle.next;
                middle.next = node;

            }
            Console.WriteLine($"{node.data} added in middle to the middle");
        }

        //todisplay the value
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("linked list is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }

        }





        public void RemoveFirst() // remove the first node in the list
        {
            if (this.head == null)
            {
                Console.WriteLine("Empty linked list");
            }
            this.head = this.head.next;
            Console.WriteLine($"{ this.head} is the removed node");
        }
    }
}
