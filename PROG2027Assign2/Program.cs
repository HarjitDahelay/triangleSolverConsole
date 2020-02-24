using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2027Assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool value = true;

            do
            {
                Console.WriteLine("Select any option: ");
                Console.WriteLine("1.Enter Triangle Dimensions");
                Console.WriteLine("2.Exit");

                string userOption = Console.ReadLine();

                if (userOption == "1")
                {
                    value = true;
                    do
                    {
                        Console.WriteLine("\nEnter 3 sides of triangle:");
                        try
                        {
                            int side1 = Convert.ToInt32(Console.ReadLine());
                            int side2 = Convert.ToInt32(Console.ReadLine());
                            int side3 = Convert.ToInt32(Console.ReadLine());

                            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                            {
                                Console.WriteLine("The side of triangle cannot be less than or equal to zero.");
                            }
                            value = false;

                            Console.WriteLine(TriangleSolver.Analyze(side1, side2, side3));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("ERROR: Please Try Again " + e.Message);
                        }
                    } while (value);
                    value = true;
                }
                else if (userOption == "2")
                {
                    value = false;
                }
                else
                {
                    Console.WriteLine("Wrong Input,Choose Option Again\n");
                }
            } while (value);
        }
    }
}

