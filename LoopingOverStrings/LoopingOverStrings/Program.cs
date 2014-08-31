using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingOverStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            FindALetter("e", "The United States of 'Murica");

            FindAWord("and", "and AND and and AnD and anD and ALKDSFLKALSDANDADNADNALKSDFLKJADSAND");
            Console.ReadKey();
            
        }

        //create a new function to loop over the letters of a string, and count the number of a certain letter
        static void FindALetter(string letterToFind, string text)
        {
            //declare a variable to hold the # of letter matches
            int letterCount = 0;
            //loop over the string
            for (int i = 0; i < text.Length; i++)
            {
                //get the current letter we're looking at to a string for ease of use
                string letter = text[i].ToString();

                //is this a letter we need to find?
                if (letter.ToLower() == letterToFind.ToLower())
                {
                    //found a letter, increment out counter
                    letterCount++;
                }
            }
            //time to display output
            Console.WriteLine("Found " + letterCount + " " + letterToFind + "'s in " + text);
        }
        //create a function to loop over words in a string
        static void FindAWord(string wordToFind, string text)
        { 
            //counter to count the number of words found
            int wordCount = 0;
            //split the string into words first and convert the array to a list for ease of use
            List<string> words = text.Split(' ').ToList();
            //loop over each word
            for (int i = 0; i < words.Count; i++)
            {
                //get the current word in our loop
                string word = words[i];
                //compare the lowercase word with the wordToFind
                if (word.ToLower() == wordToFind.ToLower())
                {
                    wordCount = wordCount + 1;
                }
            }
            //output
            Console.WriteLine("Found " + wordCount + " " + wordToFind + "'s in " + text);
        }
    }
}
