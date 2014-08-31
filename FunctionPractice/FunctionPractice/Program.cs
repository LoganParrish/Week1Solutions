using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the HelloWorld() function
            HelloWorld();
            
            //call the greeting function
            Greet("Logan");

            //call the DoubleIt() function
            int myAgeDoubled = DoubleIt(20);
            Console.WriteLine(myAgeDoubled);
            Console.WriteLine(DoubleIt(myAgeDoubled));

            //call the Multiply() function
            Console.WriteLine(Multiply(myAgeDoubled, 4));

            //do a loop from 1->20 that 
            //triples each number
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Multiply(i, 3));
            }
            
            Console.ReadKey();
        }
        //FUNCTIONS GO BELOW HERE
        
        static void HelloWorld()
        {
            Console.WriteLine("Hello world!");
        }

        static void Greet(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        static int DoubleIt(int num)
        {
            return num * 2;
        }
 
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

    }
}
