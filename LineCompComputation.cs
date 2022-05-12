using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    public class LineCompComputation
    {
        // Initialising the variables to store the line length values
        public static double Line1Length = 0; 
        public static double Line2Length = 0;
        //Function/method containing logic to find the length of the line 1
        public static void Line1Modelling()
        {
            Console.Write("Please enter the Line 1 coordinate x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the Line 1 coordinate y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the Line 1 coordinate x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the Line 1 coordinate y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double length = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            Line1Length = Math.Sqrt(length);
            Console.WriteLine("The Length of the line 1 is {0}", Line1Length);
            Console.WriteLine("");

        }

        //Function/Method containing logic to find the length of the line 2
        public static void Line2Modelling()
        {
            Console.Write("Please enter the Line 2 coordinate x3: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the Line 2 coordinate y3: ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the Line 2 coordinate x4: ");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the Line 2 coordinate y4: ");
            int y4 = Convert.ToInt32(Console.ReadLine());

            double length = Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2);
            Line2Length = Math.Sqrt(length);
            Console.WriteLine("The Length of the line 2 is {0}", Line2Length);
            Console.WriteLine("");

        }

        //Function/Method containing logic to check the equality of the two lines
        public static void LineEqualityCheck()
        {
            if (Line1Length == Line2Length)
            {
                Console.WriteLine("The Lines are equal in length");
            }
            else
            {
                Console.WriteLine("The Lines are not equal in length");
            }
        }

        //Function/Method containing logic to compare the length of two lines
        public static void LineComparison()
        {
            if (Line1Length > Line2Length)
            {
                Console.WriteLine("The length of Line 1 is greater than line 2");
            }
            else if (Line1Length < Line2Length)
            {
                Console.WriteLine("The length of Line 2 is greater than line 1");
            }
            else
            {
                Console.WriteLine("The lines are equal in length");
            }
        }
    }
}
