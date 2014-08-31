using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myMenu = new List<string>()
            {
                "Pizza", "Tacos", "Hummus", "Instant Potatoes" 
            };
            myMenu.Add("Deep fried Twix");

            //Loop through our menu and print each item

            for (int i = 0; i < myMenu.Count; i++)
            {
                Console.WriteLine(myMenu[i]);
            }
            
            //remove things from a list
            myMenu.Remove("Pizza");
            //remove by index
            myMenu.RemoveAt(1);
            
            //Another EASIER way of printing out an array, the ", " is a separator, it can also be \n for a new line
            Console.WriteLine(string.Join(", ", myMenu));

            //Loop through the List again, to make Twix pop
            for (int i = 0; i < myMenu.Count; i++)
            {
                string item = myMenu[i];
                if (item.ToLower().Contains("Twix"))
                {
                    //found a twix, make it capitalized
                    Console.WriteLine(item.ToUpper());
                }
                else
                {
                    Console.WriteLine(item);
                }

            }
            
            //always read key don't forget to read key READ KEY READ KEY
            //READ. 
            //KEY.

            Console.ReadKey();
        }
    }
}
