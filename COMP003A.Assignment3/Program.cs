/*
 * Author: Aaron Abramson
 * Course: COMP-003A
 * Purpose: Week 3 Assignment
 *
*/
namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If-Else Section (Numeric to Letter Grade)-----------------------------

            Console.WriteLine("**************************************************");
            Console.WriteLine("If-Else Section (Numeric to Letter Grade)         ");
            Console.WriteLine("**************************************************");

            //User input prompt for grade number
            Console.WriteLine("\n\n");
            Console.Write("Enter your Numeric Grade (1-100) ");
            double numericGrade = Convert.ToDouble(Console.ReadLine());//----------<<<|User input is converted to double type and stored in variable.
            Console.WriteLine($"The numeric grade entered is {numericGrade}.");

            //The nested if-else statement
            if (numericGrade >= 0 && numericGrade <= 100)
            {
                if (numericGrade >= 90)
                {
                    Console.WriteLine("Letter Grade: A");
                }
                else if (numericGrade >= 80)
                {
                    Console.WriteLine("Letter Grade: B");
                }
                else if (numericGrade >= 70)
                {
                    Console.WriteLine("Letter Grade: C");
                }
                else if (numericGrade >= 60)
                {
                    Console.WriteLine("Letter Grade: D");
                }
                else
                {
                    Console.WriteLine("Letter Grade: F");
                }
            }
            else
            {
                Console.WriteLine("Input Invalid");
            }
            //---------------------------------------------------------------------

            //
        }
    }
}