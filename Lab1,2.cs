//Day2 Lab3
//Part 1
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day2
{
    class Lab2
    {
        static void Main()
        {



            #region program to take a character from the user, and then display its ASCII code
            // //enter character
            Console.WriteLine("Enter Character Want to convert");
            string input = Console.ReadLine().ToString();
            //check
            if (input.Length == 1)
            {
                //convert
                char character = input[0];
                int convertASC = (int)character;
                //display
                Console.WriteLine("The ASCII value is " + convertASC);
            }
            else
            {
                Console.WriteLine("Enter only one char");
            }
            #endregion
            #region Same program but vice versa.
            //enter numer
            Console.WriteLine("Please enter a number between 0 and 127");
            int number = int.Parse(Console.ReadLine());

            //check  
            if (number >= 0 && number <= 127)
            {
                //convert
                char character = (char)number;
                //display
                Console.WriteLine("The ASCII value is " + character);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 127.");
            }
            #endregion
            #region A program to take a num from user and display odd or even based on this num.
            ////enter numer from user
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            //check number even/odd
            if (num % 2 == 0)
            {
                Console.WriteLine("the nuber is even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }
            #endregion
            #region A program to take two numbers and print the sum, subtraction, multiplication.
            //int sum, sub, mult;
            //// Enter two number 
            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            int SecondNumber = int.Parse(Console.ReadLine());
            //pint & clc
            Console.WriteLine($"the Sum of Two number is :- {firstNumber + SecondNumber}");
            Console.WriteLine($"the subtraction of Two number is :- {firstNumber - SecondNumber}");
            Console.WriteLine($"the multiplication of Two number is :- {firstNumber * SecondNumber}");
            #endregion
            #region A program to take student degree and calculate grade 
            //enter the degee 
            Console.WriteLine("Please enter the degree to clculation the grade");
            int degree = int.Parse(Console.ReadLine());
            // clc
            // if --- else
            if (degree >= 0 && degree < 50)
            {
                Console.WriteLine(" you are fail");
            }
            else if (degree >= 50 && degree < 60)
            {
                Console.WriteLine("you have accept  ");
            }
            else if (degree >= 60 && degree < 75)
            {
                Console.WriteLine("you pass with good degree");
            }
            else if (degree >= 75 && degree < 85)
            {
                Console.WriteLine("you pass with very good degree");
            }
            else if (degree >= 85 && degree <= 100)
            {
                Console.WriteLine("you pass with exlent degree");
            }
            else
            {
                Console.WriteLine("Enter the correct degree");
            }
            #endregion
            #region Multiplication table
            //enter table 
            Console.WriteLine("enter the table multiblcation want to you");
            int table = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{table} * {i} = {table * i}");
            }


            #endregion
            #region -A program to store students grades in OOP course1
            //take number of student, student grades from user
            //- print grades
            //- calculate average for all students grades



            //////Enter number student
            Console.WriteLine("Enter number of student");
            double sum = 0, avrage = 0;

            int numberOfStudent = int.Parse(Console.ReadLine());
            double[] grades = new double[numberOfStudent];
            for (int i = 0; i < numberOfStudent; i++)
            {
                Console.WriteLine($"Enter the grade of student {i + 1}");
                grades[i] = double.Parse(Console.ReadLine());
                //Console.WriteLine($"the grade of student {i + 1}");
                sum += grades[i];
                avrage = sum / numberOfStudent;

            }


            for (int i = 0; i < numberOfStudent; i++)
            {
                Console.WriteLine($"the grade of student {i + 1} >>>> {grades[i]}");
            }
            Console.WriteLine(sum);
            Console.WriteLine($"the average of all student is {avrage}");
            #endregion

            #region Consider an Array of Integer values with size N, having values as in this  Example [7 0 0 0 5 6 7 5 0 7 5 3 ]
            ////Your task will be to write a program find the longest distance between
            ////Two equal cells. In this example.The distance is measured by the number
            ////Of cells- for example, the distance between the first and the fourth cell is 2(cell 2 and cell 3).
            ////In the example above, the longest distance is between the first 7 and the 10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st And the 10th 7s.
            ////Note:
            ////-Array values will be taken from the user
            ////-If you have input like 1111111 then the distance is the number of
            ////Cells between the first and the last cell.



            Console.WriteLine("Enter the size of Array");
            int sizeArr = int.Parse(Console.ReadLine());
            int[] cont = new int[sizeArr];
            int MaxDistance = 0;
            for (int i = 0; i < sizeArr; i++)
            {
                Console.WriteLine($"Enter Value {i + 1} ");
                cont[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < sizeArr; i++)
            {

                for (int j = sizeArr - 1; j >= 0; j--)
                {

                    if (cont[i] == cont[j])
                    {
                        int distance = i - j;
                        if (distance > MaxDistance)
                        {

                            MaxDistance = distance;
                        }

                    }
                }

            }


            Console.WriteLine($"The longest distance between two equal cells is: {MaxDistance}");

            #endregion



            //bounce
            #region Define array of integer ,take size and data from user
            ////1 - Write a program to calculate the sum of all elements in an integer array
            ////2 - Write a program to find the maximum element in an integer array
            ////3 - Write a program to reverse the elements of an array without using reverse function
            ////4 - Write a program to count the number of occurrences of a specific element in an array
            ////5 - Write a program to remove duplicate elements from an array.
            ////6 - Write a program to find the second largest element in an array.
            ////7 - Write a program to find the index of the minimum element in an array. 


            ////prog 1
            ////Write a program to calculate the sum of all elements in an integer array
            ////define array and user enter data
            Console.WriteLine("Enter size of array");
            double sum = 0, avrage = 0;

            int numberOfSizeArray = int.Parse(Console.ReadLine());
            int[] dataArray = new int[numberOfSizeArray];
            for (int i = 0; i < numberOfSizeArray; i++)
            {
                Console.WriteLine($"Enter value of Array {i + 1}");
                dataArray[i] = int.Parse(Console.ReadLine());

                sum += dataArray[i];
                avrage = sum / numberOfSizeArray;

            }

            ////display
            for (int i = 0; i < numberOfSizeArray; i++)
            {
                Console.WriteLine($"the Value of Array {i + 1} >>>> {dataArray[i]}");
            }
            Console.WriteLine($"the average of all student is {sum}");
            Console.WriteLine($"the average of all student is {avrage}");




            ////prog 2  use code 
            ////Write a program to find the maximum element in an integer array
            int maxNumber = 0;

            for (int i = 0; i < numberOfSizeArray; i++)
            {
                if (dataArray[i] > maxNumber)
                {
                    maxNumber = dataArray[i];
                }
            }

            Console.WriteLine($"the Max Number of Array is : - {maxNumber}");

            prog 2  func
            we can sort array and print last one or reverse it and print the first one


            ////prog 3 
            ////Write a program to reverse the elements of an array without using reverse function
            for (int i = numberOfSizeArray - 1; i >= 0; i--)
            {
                Console.WriteLine($"the data array reverse is {dataArray[i]}");
            }

            ////prog 4
            ////Write a program to count the number of occurrences of a specific element in an array
            int counter = 0;
            Console.WriteLine("Enter Number to count repete it");
            int numSpec = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfSizeArray; i++)
            {
                if (dataArray[i] == numSpec)
                {
                    counter++;
                }

            }
            Console.WriteLine($"the number {numSpec} is repeted {counter}");


            ////prog 5
            ////Write a program to remove duplicate elements from an array
            int[] unqieArr = new int[numberOfSizeArray];
            int uniqueCount = 0;
            for (int i = 0; i < numberOfSizeArray; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < uniqueCount; j++)
                {
                    if (dataArray[i] == unqieArr[j])
                    {
                        isDuplicate = true;
                        break;
                    }

                }
                if (!isDuplicate)
                {
                    unqieArr[uniqueCount] = dataArray[i];
                    uniqueCount++;
                }

            }

            for (int i = 0; i < uniqueCount; i++)
            {
                Console.WriteLine($"the Unquie Arr is {unqieArr[i]}");
            }



            // //prog 6
            // //Write a program to find the second largest element in an array
            int secondLargeNum = 0;
            int maxNumber = 0;

            for (int i = 0; i < numberOfSizeArray; i++)
            {
                if (dataArray[i] > maxNumber)
                {
                    secondLargeNum = maxNumber;
                    maxNumber = dataArray[i];
                }
                else if (dataArray[i] > secondLargeNum && dataArray[i] < maxNumber)
                {
                    secondLargeNum = dataArray[i];
                }
            }

             Console.WriteLine($"the second Large Num of Array is : - {secondLargeNum}");

            Console.WriteLine($"the Max Number of Array is : - {maxNumber}");


            ////prog 7
            ////Write a program to find the index of the minimum element in an array

            double minValue = double.PositiveInfinity;
            int minIndex = 0;

            for (int i = 0; i < numberOfSizeArray; i++)
            {
                if (dataArray[i] < minValue)
                {
                    minValue = dataArray[i];
                    minIndex = i;
                }

            }

            Console.WriteLine($"min value is : {minValue} and index it in array is {minIndex}");


            #endregion


            #region How can you count the occurrence of 1 from 1 to 99,999,999(1 short of 100million) and total up how many 1s were there
            //How can you count the occurrence of 1 from 1 to 99,999,999(1 short of 100million) and total up how many 1s were there.
            //(Convert Numbers to String in Case one and use String Functions to Count 1s,
            //Use Only Mathematical Functions and Numeric values in case 2 and see the difference in performance)
            // Is There Any Other Way to Do it in Approximately 1 Second or less


            //first 
            int countOfOne = 0;
            Console.WriteLine("Enter Number");
            int size = int.Parse(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                string numberStr = i.ToString();  // Convert number to string
                countOfOne += numberStr.Split('1').Length - 1;  // Count occurrences of '1'
            }

            Console.WriteLine($"Total occurrences of '1' from 1 to 99,999,999: {countOfOne}");



            //second
            //
            int countOfOnes = 0;
            int range = 99999999;  

            for (int position = 1; position <= range; position *= 10) 
            {
                int higher = range / (position * 10);  
                int current = (range / position) % 10;  
                int lower = range % position;  

              
                if (current == 0)
                    countOfOnes += higher * position;
                else if (current == 1)
                    countOfOnes += higher * position + lower + 1;
                else
                    countOfOnes += (higher + 1) * position;
            }

            Console.WriteLine($"Total occurrences of '1' from 1 to {range}: {countOfOnes}");


            //third 
            // 9  >>>>>>>  1
            // 99 >>>>>>>  20
            // 999 >>>>>>  300
            // 999 >>>>>>> 4000
            // 9999>>>>>>> 50000
            // so there are the relation between this number fall in this relation  (n*10^n-1)





            Console.Write("Enter the number of digits (n): ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            if (n < 1)
            {
                Console.WriteLine("n must be greater than or equal to 1.");
                return;
            }

            // Calculate the number of occurrences of '1'
            BigInteger tenPower = BigInteger.Pow(10, (int)(n - 1));
            BigInteger result = n * tenPower;

            Console.WriteLine($"The approximate count of '1s' from 1 to {BigInteger.Pow(10, (int)n) - 1} is: {result}");
            #endregion

            #region example to learn Jagged Array

            // تعريف Jagged Array يحتوي على 3 صفوف (تمثل الفصول)
            //int[][] grades = new int[3][];

            //// تعيين عدد الطلاب (العناصر) في كل فصل بشكل مستقل
            //grades[0] = new int[3]; // الفصل الأول يحتوي على 3 طلاب
            //grades[1] = new int[4]; // الفصل الثاني يحتوي على 4 طلاب
            //grades[2] = new int[2]; // الفصل الثالث يحتوي على 2 طلاب

            //// تعبئة المصفوفة بدرجات الطلاب
            //grades[0][0] = 85; // درجة الطالب الأول في الفصل الأول
            //grades[0][1] = 90; // درجة الطالب الثاني في الفصل الأول
            //grades[0][2] = 78; // درجة الطالب الثالث في الفصل الأول

            //grades[1][0] = 88; // درجة الطالب الأول في الفصل الثاني
            //grades[1][1] = 92; // درجة الطالب الثاني في الفصل الثاني
            //grades[1][2] = 76; // درجة الطالب الثالث في الفصل الثاني
            //grades[1][3] = 81; // درجة الطالب الرابع في الفصل الثاني

            //grades[2][0] = 93; // درجة الطالب الأول في الفصل الثالث
            //grades[2][1] = 87; // درجة الطالب الثاني في الفصل الثالث

            //// طباعة الدرجات لكل طالب في كل فصل
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.WriteLine($"class {i + 1}:");
            //    for (int j = 0; j < grades[i].Length; j++)
            //    {
            //        Console.WriteLine($"  Student {j + 1}: {grades[i][j]}");
            //    }
            //}
            #endregion
        }
    }
}