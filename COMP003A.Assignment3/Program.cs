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
            
            ////////////////////////////////////////////////////////////////////////
            Console.WriteLine("**************************************************");
            Console.WriteLine("If-Else Section (Numeric to Letter Grade)         ");
            Console.WriteLine("**************************************************");
            ////////////////////////////////////////////////////////////////////////

            //User input prompt for grade number
            Console.Write("Enter your Numeric Grade (1-100) ");
            double numericGrade = Convert.ToDouble(Console.ReadLine());//----------<<<|User input is converted to double type and stored in variable.
            Console.WriteLine($"The numeric grade entered is {numericGrade}.");

            //The nested if-else statement
            if (numericGrade >= 0 && numericGrade <= 100)//------------------------<<<|If statement qualifies user input is within range and if not reports invalid to user.
            {
                if (numericGrade >= 90)                  //
                {                                        //
                    Console.WriteLine("Letter Grade: A");//
                }                                        //
                else if (numericGrade >= 80)             //
                {                                        //
                    Console.WriteLine("Letter Grade: B");//
                }                                        //
                else if (numericGrade >= 70)             //------------------------<<<|If else ladder to evaluate user input and assign grade.
                {                                        //
                    Console.WriteLine("Letter Grade: C");//
                }                                        //
                else if (numericGrade >= 60)             //
                {                                        //
                    Console.WriteLine("Letter Grade: D");//
                }                                        //
                else                                     //
                {                                        //
                    Console.WriteLine("Letter Grade: F");//
                }
            }
            else
            {
                Console.WriteLine("Input Invalid");      
            }
            
            //---------------------------------------------------------------------//

            ////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n**************************************************");
            Console.WriteLine("Switch Section (Integer to String Day)            ");
            Console.WriteLine("**************************************************");
            ////////////////////////////////////////////////////////////////////////

            
            //User input prompt for integer.
            Console.Write("Enter the an Integer Day of the week (1-7) ");
            int numericDay = Convert.ToInt32(Console.ReadLine());//----------<<<|User input is converted to int type and stored in variable.
            Console.WriteLine($"You entered {numericDay}.");

            //The switch-case statement

            switch (numericDay)//--------------------------------------------<<<|Switch to compare value of numericDay to cases
            {
                case 1: 
                    Console.WriteLine("String Day: Monday");    //
                    break;                                      //
                                                                //
                case 2:                                         //
                    Console.WriteLine("String Day: Tuesday");   //
                    break;                                      //
                                                                //
                case 3:                                         //
                    Console.WriteLine("String Day: Wednesday"); //
                    break;                                      //
                                                                //
                case 4:                                         //-----------<<<|Cases with respective value to compare and match value of numericDay
                    Console.WriteLine("String Day: Thursday");  //
                    break;                                      //
                case 5:                                         //
                    Console.WriteLine("String Day: Friday");    //
                    break;                                      //
                                                                //
                case 6:                                         //
                    Console.WriteLine("String Day: Saturday");  //
                    break;                                      //
                                                                //
                case 7:                                         //
                    Console.WriteLine("String Day: Sunday");    //
                    break;                                      //
                                                                //
                default:                                        //<<---------<<<|Default action if no cases match numericDay
                    Console.WriteLine("Invalid day!");          //
                    break;                                      //
            }

            //---------------------------------------------------------------------//

        }
    }
}