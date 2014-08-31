using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Review
{
    class Program
    {
        //declare a global variable to hold the total number of loops executed
        static int loopCount = 0;

        static void Main(string[] args)
        {
            CapitalizeAVowel("Edgy MySpace writing makes me a cool individual and people want to like me");
            
            //print out the number of loops performed
            Console.WriteLine(loopCount);

            ListPractice();

            Console.ReadKey();
        }

        //building a string
        //Take in a string, and output a string with all vowels capitalized
   

        static void CapitalizeAVowel(string input) 
        {
           //declare a string to hold our output
            string output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                //get a letter from the input
                string letter = input[i].ToString();

                string vowels = "aeiou";

                if (vowels.Contains(letter.ToLower()))
                {
                    //it is a vowel, add a uppercase letter to our output
                    output = output + letter.ToUpper();

                }
                else
                {
                    //it's not a vowel, add a lowercase letter to output
                    output = output + letter.ToLower();
                }
                //we did a loop, hooray! add one to the loopcount
                loopCount++;
            }
            //print the output
            Console.WriteLine(output);

        }
        
        //working with LISTS
        static void ListPractice()
        {
            //declare a new list
            List<String> sportsList = new List<string>() { "Baseball", "Basketball", "Badminton", "La Crosse", "Luge", "Curling" };

            //print out the contents of sportsList using a for loop
            //in ascending order
            for (int i = 0; i < sportsList.Count; i++)
            {
                Console.WriteLine(sportsList[i]);
                //we did a loop, count it on the total
                loopCount++;
            }
            
            //print out the contents of spoortsList using a for loop in reverse order
            //note: .count -1 >= 0
            for (int i = sportsList.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(sportsList[i]);
                //we did a loop, count it on the total
                loopCount++;
            }

            //list out the contents of the sportsLIst using a foreach loop

            foreach (var item in sportsList)
            {
                Console.WriteLine(item);
            }

        }
    }
    




}
