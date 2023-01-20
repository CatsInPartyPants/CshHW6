using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHW6
{
    internal class ListOfBooks
    {
        private List<string> list;

        public ListOfBooks()
        {
            list = new List<string>();
        }

        public void showAll()
        {
            Console.WriteLine("\nBooks in list:");
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }
            
        }
        
        public static ListOfBooks operator +(ListOfBooks l, string bookName)
        {
            l.list.Add(bookName);
            return l;
        }

        public static ListOfBooks operator -(ListOfBooks l, int index)
        {
            l.list.RemoveAt(index-1);
            return l;
        }

        public void DeleteByName(string name)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i] == name)
                    list.RemoveAt(i);
            }
        }

        public string FindByName(string name)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == name)
                    return $"The book {name} is in the list on position {i+1}";
            }
            return $"The book {name} did not found";
        }





    }
}
