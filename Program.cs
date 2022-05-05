using System;

namespace LineComparisonComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Line Comparison Computation Program");

            //Initialising an instance of the class LineCompComputation
            LineCompComputation lineObj = new LineCompComputation();

            //Calling methods to execute the required logic to find the length of lines and compare their length 
            lineObj.Line1Modelling();
            lineObj.Line2Modelling();
            lineObj.LineEqualityCheck();
            Console.ReadKey();

        }
    }
}
