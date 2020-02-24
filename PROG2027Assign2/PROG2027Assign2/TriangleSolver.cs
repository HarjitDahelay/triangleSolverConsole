using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2027Assign2
{
    public static class TriangleSolver
    {
        public static string Analyze(int a ,int b, int c)
        {
            while (true)
            {

                string Result = "";

               
                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    Result = ("They do not form traingle");
                }

           
                if (a == b && b == c && b == a)
                {
                    Result += (a + b + c) + ("Equilateral triangle");

                }
               
                else if (a == b || b == c || b == a)
                {
                    Result += (a + b + c) + ("Isosceles triangle");

                }
               
                else if (a != b && b != c && b != a)
                {
                    Result += (a + b + c) + ("Scalene triangle");

                }
                else
                {
                    Console.WriteLine("You Must Enter 3 Integer Numbers!");
                    Console.ReadLine();
                }

                return Result;
            }
    }
}
