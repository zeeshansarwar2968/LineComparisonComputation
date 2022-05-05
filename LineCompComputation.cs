using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    public class LineCompComputation
    {
        // Initialising the variable to store the line length 
        double lineLength;
        
        //Function containing logic to find the length of the line
        public void LineModelling()
        {
            Console.Write("Please enter the Point 1 coordinate x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the Point 1 coordinate y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the Point 2 coordinate x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the Point 2 coordinate y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double length = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            lineLength = Math.Sqrt(length);
            Console.WriteLine("The Length of the line is {0}",lineLength);

        }
    }
}
