using System;

namespace LineComparisonComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Displaying the options to the user
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t Welcome to Line Comparison Computation Program");
            Console.WriteLine("1. [UC1] Compute the length of a line");
            Console.WriteLine("");
            Console.WriteLine("2. [UC2] Compare the equality of two lines");
            Console.WriteLine("");
            Console.WriteLine("3. [UC3] Compare the length of two lines and print the output");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t Press 0 to exit the program");
            Console.WriteLine("");

            //Initiating loop to ask user for input and execute the required program
            int flag = 0;
            while (flag == 0)
            {
                Console.Write("\nPlease Enter Your Option to choose the program to execute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        flag = 1;
                        break;
                    case 1:
                        LineCompComputation.Line1Modelling();
                        break;
                    case 2:
                        LineCompComputation.Line1Modelling();
                        LineCompComputation.Line2Modelling();
                        LineCompComputation.LineEqualityCheck();
                        break;
                    case 3:
                        LineCompComputation.Line1Modelling();
                        LineCompComputation.Line2Modelling();
                        LineCompComputation.LineComparison();
                        break;                    
                    default:
                        Console.WriteLine("Please Enter from the given options");
                        break;

                }
            }

        }
    }
}
