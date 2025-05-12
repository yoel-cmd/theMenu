using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theMenu
{
    internal class Program
    {


        // הדפסה בסדר כניסה
        static void PrintArrayInOrder(double[] num)
        {
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        } 
        

        //פונקצייה להדפסה הפוך
        static void PrintArrayReversOrder(double[] num)
        {
            for (int i = num.Length-1; i >= 0; i--)
            {
                Console.WriteLine(num[i]); 
            }
        }


        //פונקצייה למיון מערך
        static double[] sortArr(double[] num)
        {
            double temp = 0;
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length - 1 - i; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        temp = num[j];
                        num[j] = num[j +1];
                        num[j +1] = temp;
                    }
                }
            }
            return num;
        }
        

        // פונקצייה שמקבלת מערך ממוין ומוציאה את הראשון 
          static void printMaxItem(double[] sortArryNum)
        {

            Console.WriteLine(sortArryNum[sortArryNum.Length-1]); 
        }
        
        // פונקצייה שמקבלת מערך ממוין ומוציאה את האחרון 
          static void printMinItem(double[] sortArryNum)
        {

            Console.WriteLine(sortArryNum[0]); 
        }






        // בדיקה של קליטת בחירה מהמשתמש 
        static void coise()
        {
            // לשנות את המערך לduble כי רק ככה אני יכול לבדוק שהוא מספר - ולדאוג שיכניס את זה עם רווחים
            Console.WriteLine("Enter your coise - To enter a series, press 1 to display, press 2 to display in reverse order, press 3 to display in sorted order, press 4 to display the highest number, press 5 to display the smallest number, press 6 to display the average, press 7 to display the number of elements, press 8 to display the sum of the series, press 9 to exit, press 10 ");
            double num = Convert.ToInt32(Console.ReadLine());

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


        // main
        static void Main(string[] args)
        {
            Console.WriteLine( " new branch");

        }
    }
}
