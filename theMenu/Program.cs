using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theMenu
{
    internal class Program
    {


        // print in order
        static void PrintArrayInOrder(int[] num)
        {
            foreach (var item in num)
            {
                Console.Write(item + " ");
            }
        } 

        //  print revrs arr
        static void PrintArrayReversOrder(int[] num)
        {
            for (int i = num.Length-1; i >= 0; i--)
            {
                Console.Write(num[i]+ " "); 
            }
        }


        //sort arr 
        static int[] sortArr(int[] num)
        {
            int temp = 0;
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


        //function print arr sort
        static void printSortArr(int[] sortArryNum)
        {
            foreach (int item in sortArryNum)
            {
                Console.Write(item + " ");    
            }
            

            
        }
        

        // print max item in arr 
          static void printMaxItem(int[] sortArryNum)
        {

            Console.WriteLine(sortArryNum[sortArryNum.Length-1]); 
        }
        
        // print min item in arr
          static void printMinItem(int[] sortArryNum)
        {

            Console.WriteLine(sortArryNum[0]); 
        }



        //print avg num in arr 
        static void printAvgItem(int[] sortArryNum)
        {
            int sum = 0;
            for(int i = 0;i < sortArryNum.Length; i++)
            { 
                sum += sortArryNum[i];
            }
            Console.WriteLine(sum/sortArryNum.Length);

        }

        //print Number of elements in arr
        static void printCountElements(int[] sortArryNum)
        {
            Console.WriteLine(sortArryNum.Length);
        }


        //print sum num in arr 
        static void printSumItem(int[] sortArryNum)
        {
            int sum = 0;
            for (int i = 0; i < sortArryNum.Length; i++)
            {
                sum += sortArryNum[i];
            }
            Console.WriteLine(sum);

        }





            // בדיקה של קליטת בחירה מהמשתמש 
            static void coise()
        {

            int[] arrNum = { 33, 52, 3, 14, 25, 66, 7 };
            PrintArrayInOrder(arrNum);

            Console.WriteLine(" ");

            // Sorting the array while preserving the original array
            int[] arrNumSort = sortArr((int[])arrNum.Clone());
            PrintArrayInOrder(arrNumSort);
            while (true)
            {
                // לשנות את המערך לduble כי רק ככה אני יכול לבדוק שהוא מספר - ולדאוג שיכניס את זה עם רווחים
                Console.WriteLine(
                    "Enter your choice:\n" +
                    "To enter a series, press 1\n" +
                    "To display, press 2\n" +
                    "To display in reverse order, press 3\n" +
                    "To display in sorted order, press 4\n" +
                    "To display the highest number, press 5\n" +
                    "To display the smallest number, press 6\n" +
                    "To display the average, press 7\n" +
                    "To display the number of elements, press 8\n" +
                    "To display the sum of the series, press 9\n" +
                    "To exit, press 10"
                ); 
                double num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" ");

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enter a series");
                        break;
                    case 2:
                        PrintArrayInOrder(arrNum);
                        break;
                    case 3:
                        Console.WriteLine("Display in reverse order");
                        PrintArrayReversOrder(arrNum);
                        break;
                    case 4:
                        Console.WriteLine("Sorted display");
                        printSortArr(arrNumSort);
                        break;
                    case 5:
                        Console.WriteLine("Show the highest number");
                        printMaxItem(arrNumSort);
                        break;
                    case 6:
                        Console.WriteLine("Displaying the smallest number");
                        printMinItem(arrNumSort);
                        break;
                    case 7:
                        Console.WriteLine("Showing the average");
                        printAvgItem(arrNum);
                        break;
                    case 8:
                        Console.WriteLine("Displaying the number of organs");
                        printCountElements(arrNum);
                        break;
                    case 9:
                        Console.WriteLine("Show the series sum");
                        printSumItem(arrNum);
                        break;
                    case 10:
                        Console.WriteLine("exit");
                        break;
                    default:
                        Console.WriteLine("No choice was made difficult.");
                        break;
                }
            }
        }


        // main
        static void Main(string[] args)
        {
            coise();

        }
    }
}
