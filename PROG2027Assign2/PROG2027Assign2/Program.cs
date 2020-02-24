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
            Boolean value = false;
           

            value = true;
            do
            {
                Console.WriteLine("\n1.Enter Triangle Dimensions");
                Console.WriteLine("2.Exit");

                string menu = "";
                Console.WriteLine("\nChoose the menu");
                menu = Console.ReadLine();

                if (menu == "1")
                {
                    Console.WriteLine("Enter First Integer");
                    int firstInput = int.Parse(Console.ReadLine());

                    string userinput = Console.ReadLine(); int a;
                    bool input1IsInteger = int.TryParse(userinput, out a);
                    if (input1IsInteger == false)
                    {
                        Console.WriteLine("Please Enter the Integer");
                        Console.ReadLine();

                        Console.WriteLine("Enter Second Integer");


                        int SecondInput = int.Parse(Console.ReadLine());

                    
                        string userinput2 = Console.ReadLine(); int b;
                        bool input2IsInteger = int.TryParse(userinput, out b);
                        if (input2IsInteger == false)
                        {
                            Console.WriteLine("Please Enter the Integer");
                            Console.ReadLine();
                        }

                 
                        Console.WriteLine("Enter Third Integer");
                        int thirdInput = int.Parse(Console.ReadLine());

                   
                        string userinput3 = Console.ReadLine(); int c;
                        bool input3IsInteger = int.TryParse(userinput, out c);

                        if (input3IsInteger == false)
                        {
                            Console.WriteLine("Please Enter the Integer");
                            Console.ReadLine();
                        }

                       
                        Console.WriteLine(TriangleSolver.Analyze(firstInput, SecondInput, thirdInput));
                        Console.ReadLine();
                    }
                }
                else if (menu == "2")
                {
                    value = false;
                }
                else
                {
                    Console.WriteLine("\nPlease Enter Valid Menu Option");
                }
            }
            while (value);
        }
    }
}
