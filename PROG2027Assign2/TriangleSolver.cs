using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2027Assign2
{
    public static class TriangleSolver
    {
        public static string Analyze(int a, int b, int c)
        {
            string output = "";

           
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                output = "Not valid traingle";
            }
            else if (a == b && b == c && b == a)
            {
                output += "This is a valid Equilateral triangle";

            }
            else if (a == b || b == c || b == a)
            {
                output += "This is a valid Isosceles triangle";

            }
            else
            {
                output += "This is Scalene triangle";

            }
           

            return output;

        }
    }
}
