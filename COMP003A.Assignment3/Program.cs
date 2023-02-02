﻿/*
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
            Console.WriteLine("****************************************");
            Console.WriteLine("conditional (selection) statements");
            Console.WriteLine("****************************************");
            

            Console.WriteLine("1. single if statement");
            Console.WriteLine("\tEnter a whole positive number");
            int inputNumber = Convert.ToInt32(Console.ReadLine());//Store user input as an integer

            //single if statement
            if (inputNumber % 2 == 0)
            {
                //this code block executes if condition is true      
                Console.WriteLine("\tinputNumber is even.");
            }
            /************************************************************/
            Console.WriteLine("2. if-else statement");
            // if-else statement
            if (inputNumber % 2 == 0)
            {
                //code executes if condition statement is true
                Console.WriteLine("\tinputNumber is even.");
            }
            else
            {
                //code executes if condition statement is false
                Console.WriteLine("\tinputNumber is odd.");
            }

            /************************************************************/
            Console.WriteLine("3. Nested if statements");
            // nested if statements
            if (inputNumber % 2 == 0)
            {
                // this code block executes if inputNumber is divisible by 2
                Console.WriteLine("\tinputNumber is even.");

                if (inputNumber % 5 == 0)
                {
                    // this code block executes if inputNumber is
                    // divisible by 2 first, and divisible by 5 after
                    Console.WriteLine("\tinputNumber is also divisible by 5.");
                }
                else
                {
                    // this code block executes if inputNumber is
                    // divisible by 2 first, and NOT divisible by 5 after
                    Console.WriteLine("\tinputNumber is NOT divisible by 5.");
                }
            }
            else
            {
                // this code block executes if inputNumber is NOT divisible by 2
                Console.WriteLine("\tinputNumber is odd.");
            }
            /************************************************************/
            Console.WriteLine("4. multiple if-else statements");
            // multiple if-else statements
            if (inputNumber % 2 == 0)
            {
                // this code block executes if the above condition is true
                //  the rest of the conditions will no longer execute
                Console.WriteLine("\tinputNumber is divisible by 2.");
            }
            else if (inputNumber % 3 == 0)
            {
                // this code block executes if the above condition is true
                //  the rest of the conditions will no longer execute
                Console.WriteLine("\tinputNumber is divisible by 3.");
            }
            else if (inputNumber % 5 == 0)
            {
                // this code block executes if the above condition is true
                //  the rest of the conditions will no longer execute
                Console.WriteLine("\tinputNumber is divisible by 5.");
            }
            else if (inputNumber % 7 == 0)
            {
                // this code block executes if the above condition is true
                //  the rest of the conditions will no longer execute
                Console.WriteLine("\tinputNumber is divisible by 7.");
            }
            else
            {
                // this code block executes if the above conditions are NOT true
                Console.WriteLine("\tinputNumber is NOT divisible by 2/3/5/7.");
            }

            /************************************************************/

            Console.WriteLine("5. ternary operator");
            string outputMessage = inputNumber % 2 == 0
                ? "\tinputNumber is even."
                : "\tinputNumber is odd.";
            Console.WriteLine(outputMessage);

            /************************************************************/

            int randomNumber = new Random().Next(10); // generates a random number 10 or below
            Console.WriteLine("6. comparison operators");
            Console.WriteLine($"\t{inputNumber} == {randomNumber}: {inputNumber == randomNumber}");
            Console.WriteLine($"\t{inputNumber} != {randomNumber}: {inputNumber != randomNumber}");
            Console.WriteLine($"\t{inputNumber} > {randomNumber}: {inputNumber > randomNumber}");
            Console.WriteLine($"\t{inputNumber} >= {randomNumber}: {inputNumber >= randomNumber}");
            Console.WriteLine($"\t{inputNumber} < {randomNumber}: {inputNumber < randomNumber}");
            Console.WriteLine($"\t{inputNumber} <= {randomNumber}: {inputNumber <= randomNumber}");

            /************************************************************/

            Console.WriteLine("7. logical operators");
            Console.WriteLine($"\t{inputNumber} == {randomNumber} && {inputNumber} >= {randomNumber}: " + $"{inputNumber == randomNumber && inputNumber >= randomNumber}");
            Console.WriteLine($"\t{inputNumber} == {randomNumber} || {inputNumber} >= {randomNumber}: " + $"{inputNumber == randomNumber || inputNumber >= randomNumber}");
            Console.WriteLine($"\t!(true): {!(true)}");

            /************************************************************/

            Console.WriteLine("8. switch statement");
            // switch statement
            switch (inputNumber)
            {
                case 2:
                    // this code block executes if the case condition is true
                    Console.WriteLine("\tinputNumber is 2.");
                    break;  // the break keyword exits out of the switch
                case 3:
                    // this code block executes if the case condition is true
                    Console.WriteLine("\tinputNumber is 3.");
                    break;
                case 5:
                    // this code block executes if the case condition is true
                    Console.WriteLine("\tinputNumber is 5.");
                    break;
                case 7:
                    // this code block executes if the case condition is true
                    Console.WriteLine("\tinputNumber is 7.");
                    break;
                default:
                    // this code block executes if none of the cases above is true
                    Console.WriteLine("\tinputNumber is NOT 2, 3, 5, OR 7.");
                    break;
            }
        }
    }
}