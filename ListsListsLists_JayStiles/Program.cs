using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsListsLists_JayStiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> theList = new List<string>();
            theList.Add("10");
            theList.Add("20");
            theList.Add("30");
            theList.Add("40");
            theList.Add("50");
            theList.Add("60");
            theList.Add("70");

            Console.WriteLine("What would you like to do today? ");
            Console.WriteLine("Edit the List, press (1) ");
            Console.WriteLine("Search the List, press (2) ");
            Console.WriteLine("See the List, press (3) ");
            string listChoice = Console.ReadLine();

            //Choices
            if (listChoice == "1")
            {
                Console.WriteLine("Please enter something to add to the list: ");
                string newInfo = Console.ReadLine();
                var newList = new List<string>();
                newList.Add(newInfo);
                theList = newList;

            }
            if (listChoice == "2")
            {
                Console.WriteLine("What are you searching for: ");
                string searchTerm = Console.ReadLine();
                if (theList.Contains(searchTerm))
                {
                    Console.WriteLine($"{searchTerm} was found.");
                }
            }
            if (listChoice == "3")
            {
                
                Console.WriteLine("Ordered: ");
                theList.OrderBy(x => x).ToList();
                Console.WriteLine(theList);
            }
            else
            {
                Console.WriteLine("Please enter 1, 2, or 3: ");
                listChoice = Console.ReadLine();
            }


        }


    }


}
