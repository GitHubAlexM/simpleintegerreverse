using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseIntegerOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            //opening line
            Console.WriteLine("Enter a number: ");
            //user's input
            int number = Convert.ToInt32(Console.ReadLine());
            //variables
            int num = number, reverse = 0;
            //while loop to reverse num
            while (num != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
            }
            //output
            Console.WriteLine("The reverse of {0} is {1}.",number, reverse);

            //now with validation through numbers of 1-10000
            //opening line
            Console.WriteLine("\nEnter a number between 1 and 10000: ");
            //user's input
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number2 <= 1 || number2 >= 10000)
            {
                Console.WriteLine("Error, invalid number.");
                Environment.Exit(0);
            }
            //variables
            int num2 = number2, reverse2 = 0;
            //while loop to reverse num
            while (num2 != 0)
            {
                reverse2 = reverse2 * 10;
                reverse2 = reverse2 + num2 % 10;
                num2 = num2 / 10;
            }
            //output
            Console.WriteLine("The reverse of {0} is {1}.", number2, reverse2);
        }
    }
}
