using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            double biggestNum = 0;
            Console.Write("Please enter a number: ");
            double numOne = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double numTwo = Convert.ToDouble(Console.ReadLine());

            double delta = numOne - numTwo;
            if (delta <0 )
            {
                biggestNum = numTwo;
            }
            else if (delta >=0)
            {
                biggestNum = numOne;
            }
            Console.WriteLine("the biggest value is: " + biggestNum);
        }
    }
}
