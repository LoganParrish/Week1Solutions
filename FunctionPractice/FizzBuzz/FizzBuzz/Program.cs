using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 35; i++)
            {
                FizzBuzz(i);
            }
            for (int i = 92; i >= 79; i--)
            {
                FizzBuzz(i);
            }
            Yodaizer("I like code");
            TrueYodaizer("I like code");
            TextStats("Three sentences is what you ask for? Three sentences is what you get. ARE YOU NOT SATISFIED?");
            IsPrime(7);
            TrueDashInsert(8675309);
            Console.ReadKey();
        }


        static void FizzBuzz(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0))
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
        static void Yodaizer(string text)
        {
            List<string> list = text.Split(' ').ToList();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
        static void TrueYodaizer(string text)
        {
            List<string> list = text.Split(' ').ToList();
            if (list.Count == 3)
            {
                Console.WriteLine(list[2] + ", " + list[0] + " " + list[1]);
            }

        }
        static void TextStats(string input)
        {
            int vowelCount = 0;
            int spaceCount = 0;
            int specialCount = 0;
            char space = ' ';
            Console.WriteLine(input);
            Console.WriteLine("The number of characters in the string is: " + input.Length);
            Console.WriteLine("The number of words in the string is: " + input.Split(' ').Length);
            for (int i = 0; i < input.Length; i++)
            {
                string letter = input[i].ToString();

                string vowels = "aeiou";
                
                string special = "!?;,.<>/[]{}':-=*&^%$#@`~";

                if (vowels.Contains(letter.ToLower()))
                {
                    vowelCount++;
                }
                else if (letter == space.ToString())
                {
                    spaceCount++;
                }
                    //I'm aware that I could catagorize space a special character, but just why not.
                else if(special.Contains(letter))
                {
                    specialCount++;
                }
              

            }
            Console.WriteLine("There are " + vowelCount + " vowels in the string");
            Console.WriteLine("There are " + spaceCount + " spaces in the string. Because why not.");
            Console.WriteLine("There are " + specialCount + " special characters in the string. Also because why not.");


        }
        static void IsPrime(int number) 
        {
            bool isNotPrime = false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isNotPrime = true;
                    break;
                }
            }
            if (isNotPrime)
            {
                Console.WriteLine(number + " is not a prime number.");
            }
            else
            {
                Console.WriteLine(number + " is most certainly a prime number.");
            }
            
        }
        static void TrueDashInsert(int number)
        {
            string stringThing = number.ToString();
            string tempString = string.Empty;

            if (stringThing.Length <= 1)
            {
                Console.WriteLine("Please give a number over 2 characters long");
            }
            foreach (char i in stringThing)
            {
                if (tempString.Length == 0)
                {
                    tempString = tempString + i;
                }
                else if (Convert.ToInt32(i) > 0 && Convert.ToInt32(i) % 2 != 0 && Convert.ToInt32(tempString[tempString.Length - 1]) % 2 != 0)
                {
                    tempString = tempString + "-" + i;
                }
                else
                {
                    tempString = tempString + i;
                }
            }
            Console.WriteLine(tempString);
        }
    }
}

