using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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


        //Checking if everything is numbers
        static bool checkIfNumbers(string[] inputArr)
        {
            if (inputArr.Length < 3)
            {
                Console.WriteLine("error 1");
                return false;
            }
            for (int i = 0; i < inputArr.Length; i++)
            {
                try
                {
                   int num = Convert.ToInt32(inputArr[i]);
                }
                catch
                {
                    Console.WriteLine("error 2 ");
                    return false;
                }
            }
            return true;
        }
        // checked if there are at least 3 numbers  
        //static bool CheckThreePositive(int[] inputArr)
        //{
        //    if (inputArr.Length < 3)
        //    {
        //        return false;
        //    }
            
        //    return false;
        //}



        //function input user
        static string[] userInput()
        {
            
            Console.WriteLine("Enter a series of at least 3 numbers with a space between them.");
            string[] inputStringArr = Console.ReadLine().Split(' ');

            return inputStringArr;
        }




        




        static string[] menu(string[] inputStringArr)
        {
            //Receiving a series of numbers from the user
            int[] originalInputArr = new int[inputStringArr.Length];

            //Check if all are numbers if so then check if at least size 3 if so then at least 3 are positive
            
            
                for (int i = 0; i < inputStringArr.Length; i++)
                {
                    originalInputArr[i] = Convert.ToInt32(inputStringArr[i]);
                }



            bool flag =true;

            //int[] arrNum = { 33, 52, 3, 14, 25, 66, 7 };
            //PrintArrayInOrder(arrNum);

            Console.WriteLine(" ");

            //Sorting the array while preserving the original array
            int[] sortedInputArr = sortArr((int[])originalInputArr.Clone());




            while (flag)
            {

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


                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 10)
                {
                    Console.WriteLine("exit \n");
                    flag = false;
                    continue;
                }

                Console.WriteLine(" ");

                switch (num)
                {
                    case 1:
                       Console.WriteLine("Okay, you chose to enter the series of numbers from the beginning. \n");
                       inputStringArr=  inputTrue(userInput());
                        flag = false;
                        Console.WriteLine("Error ");

                        break;
                    case 2:
                        PrintArrayInOrder(originalInputArr);
                        break;
                    case 3:
                        Console.WriteLine("Display in reverse order \n");
                        PrintArrayReversOrder(originalInputArr);
                        break;
                    case 4:
                        Console.WriteLine("Sorted display");
                        printSortArr(sortedInputArr);
                        break;
                    case 5:
                        Console.WriteLine("Show the highest number \n");
                        printMaxItem(sortedInputArr);
                        break;
                    case 6:
                        Console.WriteLine("Displaying the smallest number \n");
                        printMinItem(sortedInputArr);
                        break;
                    case 7:
                        Console.WriteLine("Showing the average \n");
                        printAvgItem(sortedInputArr);
                        break;
                    case 8:
                        Console.WriteLine("Displaying the number of organs \n");
                        printCountElements(sortedInputArr);
                        break;
                    case 9:
                        Console.WriteLine("Show the series sum \n");
                        printSumItem(sortedInputArr);
                        break;
                    default :
                        Console.WriteLine("Does not comply with the writing rules");
                        break;
                }
                
            }
            Console.WriteLine("Error ");
            return inputStringArr;
        }
         static string[] inputTrue(string[] input)
        {
            while (!checkIfNumbers(input))
            {
                input = userInput();

            }
            return input;
        }


        // main
        static void Main(string[] args)
        {
            while (true)
            {
                args = inputTrue(args);

                args = menu(args);

            }
        }
    }
}
