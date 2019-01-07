using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNCalculator
{
    class Program
    {
        // Opening Screen when application is run.
        static void Main()
        {
            Console.WriteLine("Welcome to Jason's C# Calculator:");
            Console.WriteLine("Select 1 for Addition\nSelect 2 for Subtract\nSelect 3 for Multiplication\nSelect 4 for Division");
            int userOperation = int.Parse(Console.ReadLine());
            OperationRouter(userOperation);
        }

        // Router that handles user input of what arithmetic operation is wanted.
        static void OperationRouter(int userOperation)
        {
            switch (userOperation)
            {
                //Addition
                case 1:
                    Addition();
                    break;
                //Subtraction
                case 2:
                    Subtraction();
                    break;
                //Multiplication
                case 3:
                    Multiplication();
                    break;
                //Division
                case 4:
                    Division();
                    break;
                //Operation Unrecognized
                default:
                    Console.WriteLine("Selection Out of Range. Please Try Again");
                    Main();
                    return;
            }
        }

        // Addition method
        static void Addition()
        {
            Console.WriteLine("What numbers would you like to add together?");
            int[] numberArray = new int[2];
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("You Selected " + numberArray[i] + ". You have " + (numberArray.Length - (i + 1)) + " choices left.");
            }
            int solution = numberArray[0] + numberArray[1];
            Console.WriteLine("Your solution is " + solution + ".");
            Console.ReadLine();
        }

        // Subtraction method
        static void Subtraction()
        {
            Console.WriteLine("What numbers would you like to subtract?");
            int[] numberArray = new int[2];
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("You Selected " + numberArray[i] + ". You have " + (numberArray.Length - (i + 1)) + " choices left.");
            }
            int solution = numberArray[0] - numberArray[1];
            Console.WriteLine("Your solution is " + solution + ".");
            Console.ReadLine();
        }

        // Multiplication method
        static void Multiplication()
        {
            Console.WriteLine("What numbers would you like to multiply?");
            int[] numberArray = new int[2];
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("You Selected " + numberArray[i] + ". You have " + (numberArray.Length - (i + 1)) + " choices left.");
            }
            int solution = numberArray[0] * numberArray[1];
            Console.WriteLine("Your solution is " + solution + ".");
            Console.ReadLine();
        }

        // Division method
        static void Division()
        {
            Console.WriteLine("What numbers would you like to divide?");
            int[] numberArray = new int[2];
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
                if (numberArray[i] == 0)
	            {
                Console.WriteLine("You cannot divide by zero. Please select a different integer.");
                numberArray[i] = int.Parse(Console.ReadLine());
	            }
                Console.WriteLine("You Selected " + numberArray[i] + ". You have " + (numberArray.Length - (i + 1)) + " choices left.");
	           
                
            }
            int solution = numberArray[0] / numberArray[1];
            Console.WriteLine("Your solution is " + solution + ".");
            Console.ReadLine();
        }
    }
}
