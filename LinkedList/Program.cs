using System;

namespace LinkedList
{
    class Progrem
    {
        static void Main(string[] args)
        {
            CustomLinkedList list = new CustomLinkedList();
            

            const int MAX = 3;
            for (int i = 0; i< MAX;i++)
            {
                var str =Console.ReadLine();
                list.AddItam(str);
            }
        }

       

    }
    

    //        static void Main(string[] args)
    //    {
    //        CustomLinkedList linkedList = new CustomLinkedList();
            

    //        linkedList.Add("Item1");
    //        {
    //            var value = Item1;
    //        }
    //        linkedList.Add("Item2");

    //        linkedList.Delete();
    //        linkedList.ToString();
    //        Console 
    //    }
    //}
}
