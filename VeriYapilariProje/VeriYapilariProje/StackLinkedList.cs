using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje
{
    public class StackLinkedList
    {
        public Node Head = null;
        public int count = 0;

        public string DisplayElements()
        {
            string sonuc=" ";
           
           
            {
                Node temp = Head;
                while (temp != null)
                {

                    sonuc += ("{0}->", temp.Data);

                    temp = temp.Next;
                }
            }
            return sonuc;
        }

        public bool IsEmpty()
        {
            if (Head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Peek()
        {
            if (Head == null)
            {
                return null;

            }
            return Head.Data;
        }

        public object Pop()
        {
            Node temp;
            if (Head == null)
            {
                return null;

            }
            temp = Head;
            Head = Head.Next;
            return temp.Data;
        }

        public void Push(object item)
        {
            Node newNode = new Node(item);
            if (Head == null)
            {
                newNode.Next = null;
            }
            else
            {
                newNode.Next = Head;
            }
            Head = newNode;
            count++;
        }
    }
}
