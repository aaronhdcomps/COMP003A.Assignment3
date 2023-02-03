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
            Console.WriteLine("**************************************************");
            Console.WriteLine("If-Else Section (Numeric to Letter Grade)         ");
            Console.WriteLine("**************************************************");
            Console.WriteLine("\n\n");
            Console.Write("Enter your Numeric Grade (1-100) ");
            double numericGrade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your numeric grade is " + numericGrade);
        }
    }
}