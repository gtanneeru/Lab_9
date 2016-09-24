using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double numradius;
            string goAhead = " ";
            Console.WriteLine("Welcome to the Circle Tester");
          
                do
                {
                    Console.WriteLine("Enter radius");
                    bool i = Double.TryParse(Console.ReadLine(), out numradius);

                    Circle areaMeter = new Circle(numradius);
                    if (i == true)
                    {
                        Console.WriteLine("Circumference:\t" + areaMeter.getFormatedCircumference());
                        Console.WriteLine("Area:\t\t" + areaMeter.getFormatedArea());
                        Console.WriteLine("Continue?\t(y/n)");

                        goAhead = Console.ReadLine();
                        if (goAhead == "n")
                        {

                            Console.WriteLine("Goodbye. You created" + Circle.getObjectCount());
                        }

                    }
                    else
                        Console.WriteLine("Enter valid number");
                }
                while (goAhead == "y");
            }
           
        }
    }


