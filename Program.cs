using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            String num1;
            String num2;  //treat each number as a string

            Console.WriteLine("Please enter the first integer number:");
            num1 = Console.ReadLine();

            Console.WriteLine("Please enter the second integer number:");
            num2 = Console.ReadLine();


            /* Check that input was two integers*/
            int a = 0;
            int b = 0;

            bool result1 = int.TryParse(num1, out a); //return true if the 1st input was a valid integer
            bool result2 = int.TryParse(num2, out b); //return true if the 2nd input was a valid integer
                                                      /*
                                                                 if (result1 == false)  //if value is not an integer return error message
                                                                  {
                                                                      Console.WriteLine("Sorry the value inputted was not an integer!");
                                                                      Console.ReadKey();
                                                                  }*/

            if (result1 == false || result2 == false)  //if value is not an integer return error message
            {
                Console.WriteLine("Sorry the value inputted was not an integer!");
                Console.ReadKey();
            }

            /* Check to see if values have same length*/
            int length1 = num1.Length;
            int length2 = num2.Length;

            if (length1 != length2)                          //if length one is not the same as lengt two return error message
            {
                Console.WriteLine("Sorry, the values inputted do not have the same amount of digits!");
                Console.ReadKey();
            }


        }

    }
}