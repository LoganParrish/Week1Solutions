using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashInsert
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void DashInsert(int number)
        {
            string oddNumbers = "13579";
            bool num1 = false;
            bool num2 = false;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                if (num1 == true)
                {
                    break;
                }
                else if (num1 == false)
                    if (oddNumbers.Contains(number.ToString()))
                    {
                        num1 = true;
                        break;

                    }
                if (num2 == true)
                {
                    break;
                }
                else if (num2 == false)
                    if (oddNumbers.Contains(number.ToString()))
                    {
                        num2 = true;
                        break;
                    }


            }
            if (num1 == num2)
            {
                Console.WriteLine(num1 + "-" + num2);
            }
        }
    }

}
