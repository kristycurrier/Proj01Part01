using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01Part1
{
    class Program
    {

        public static int DigitCheck(int length , string Number1 , string Number2)  //function to check digits
        {

            int i = 1;
            int a = int.Parse(Number1[0].ToString());      //Convert first digit of first input from char to int
            int b = int.Parse(Number2[0].ToString());      //Convert first digit of second input from char to int
            int AddValue = a + b;                          //Add first digits together

            while (i < length)
            {
                int x = int.Parse(Number1[i].ToString());   //Find the digit at a specific index of first integer and convert to int
                int y = int.Parse(Number2[i].ToString());   //Find the digit at a specific index of second integer and convert to int

                int Value = x + y;                          //Add digits together

                if (AddValue == Value)                      //Check if value of the sum of first digits are equal to the value of the digits at index i
                {
                    i++;                                    //add one and repete
                }
                else
                {
                    i = length + 1;                         //If the values are not the same add one to the total length of the string to break the loop
                }

            }

            return i;                                       //return i

        }


        static void Main(string[] args)
        {
            String num1;
            String num2;  //treat each number as a string

            Console.WriteLine("Please enter the first integer number:");     //ask for input from user
            num1 = Console.ReadLine();                                       //read input from user in string format

            Console.WriteLine("Please enter the second integer number:");    //ask for input from user
            num2 = Console.ReadLine();                                       //read input from user in string format


            /* Check that input was two integers*/
            int a = 0;
            int b = 0;

            bool result1 = int.TryParse(num1, out a); //return true if the 1st input was a valid integer
            bool result2 = int.TryParse(num2, out b); //return true if the 2nd input was a valid integer

            if (result1 == false || result2 == false)  //if value is not an integer return error message
            {
                Console.WriteLine("Sorry the value inputted was not an integer!");
                Console.ReadKey();
                return;
            }

            /* Check to see if values have same length*/
            int length1 = num1.Length;
            int length2 = num2.Length;
            int length = length2;

            if (length1 != length2)                          //if length one is not the same as length two return error message
            {
                Console.WriteLine("Sorry, the values inputted do not have the same amount of digits!");
                Console.ReadKey();
                return;
                
            }
            else                                             //else set variable length to the value of length1
            {
                length = length1;
            }

            int Result = DigitCheck(length, num1, num2);    //send into the function to check digits

            if(Result <= length)                            //if the function made it to the end of the checking digits return true
            {
                Console.WriteLine("True");
                Console.ReadKey();
            }
            else                                            //if the function had sums of digits that did not have equal value return false
            {
                Console.WriteLine("False");
                Console.ReadKey();
            }

        }

    }
}