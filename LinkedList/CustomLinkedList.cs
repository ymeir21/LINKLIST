using System;


namespace LinkedList
{
    public class CustomLinkedList
    {
        Item Head = null;
        public void AddItam(string str)
        {
            if (Head == null)
            {
                Head = new Item();
                Head.name = str;
                Head.prev = null;
                Head.next = null;
            }
            else
            {
                Item newItem = new Item();
                newItem.name = str;


                Item curr = Head;
                while (curr.next != null)
                {
                    curr = curr.next;
                }

                curr.next = newItem;
                newItem.prev = curr;
            }
        }
        public void Delete()
        {
          
            Item curr = Head;
            while (curr.next != null)
            {
                curr = curr.next;

            }

            Item temp = curr; 
            curr = curr.prev;
            curr.next = null;
            temp.prev = null;
        }
        public string ToString()
        {
            Item curr = Head;
            String res = " "; 
            while (curr.next != null)
            {
                res = (res + curr.name + ",");
                curr = curr.next;
            }
            return res;
        }

    }

}
