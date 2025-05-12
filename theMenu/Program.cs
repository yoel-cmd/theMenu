using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theMenu
{
    internal class Program
    {

        static void coise()
        {
            Console.WriteLine("Enter your coise - To enter a series, press 1 to display, press 2 to display in reverse order, press 3 to display in sorted order, press 4 to display the highest number, press 5 to display the smallest number, press 6 to display the average, press 7 to display the number of elements, press 8 to display the sum of the series, press 9 to exit, press 10 ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Enter a series");
                    break;
                case 10:
                    Console.WriteLine("To be presented in order of entry");
                    break;
                case 2:
                    Console.WriteLine("Display in reverse order");
                    break;
                case 3:
                    Console.WriteLine("Sorted display");
                    break;
                case 4:
                    Console.WriteLine("Show the highest number");
                    break;
                case 5:
                    Console.WriteLine("Displaying the smallest number");
                    break;
                case 6:
                    Console.WriteLine("Showing the average");
                    break;
                case 7:
                    Console.WriteLine("Displaying the number of organs");
                    break;
                case 8:
                    Console.WriteLine("Show the series sum");
                    break;
                case 9:
                    Console.WriteLine("exit");
                    break;
                default:
                    Console.WriteLine("No choice was made difficult.");
                    break;
            }




        }

        static void Main(string[] args)
        {
            Console.WriteLine( " new branch");

        }
    }
}
