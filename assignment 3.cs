
//Day3 Lab3
//Part 1
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System;

namespace Day3
{
    class Lab3
    {
        static void Main()
        {

            #region Write a program that store student age for many tracks
            //// -take number of student and tracks from user
            //// - enter student ages
            ////-print the array
            ////-calculate age avg for each track.

            Console.WriteLine("Enter number of Track");

            int numOfTrack = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of Student");
            int numOfStudent = int.Parse(Console.ReadLine());

            int[,] TrakAgeArr = new int[numOfTrack, numOfStudent];

            //loop
            for (int i = 0; i < numOfTrack; i++)
            {
                for (int j = 0; j < numOfStudent; j++)
                {
                    Console.WriteLine($"Enter age of Student {j + 1} in Track {i + 1}:");
                    int ageOfStudent = int.Parse(Console.ReadLine());
                    //store
                    TrakAgeArr[i, j] = ageOfStudent;
                }

            }
            //display
            Console.WriteLine("Student Ages by Track:");
            for (int i = 0; i < numOfTrack; i++)
            {
                Console.WriteLine($"Track {i + 1}");
                int sumOfTrack = 0;
                for (int j = 0; j < numOfStudent; j++)
                {

                    Console.Write($"{TrakAgeArr[i, j]} " + "  ");
                    sumOfTrack += TrakAgeArr[i, j];
                    //Console.WriteLine(sumOfTrack);
                }
                double avgOfTrack = (double)sumOfTrack / numOfStudent;
                Console.WriteLine($"\nAverage Age for Track {i + 1}: {avgOfTrack}");
            }
            #endregion

            #region Write a program that generates a multiplication table using a two-dim array.
            ////-Declare and initialize a 10x10 array.
            ////-Fill the array such that the element at[i, j] is equal to (i + 1) * (j + 1).
            ////- Print the multiplication table.
            ////define muli array with size 10*10
            int[,] multiplication = new int[10, 10];

            //loop 

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    multiplication[i, j] = i * j;
                }
            }

            ////display

            Console.WriteLine("Multiblication table");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"********************* Table {i} ***************************");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"{i}*{j}=  {multiplication[i, j]}");
                }
            }


            //Bonus:
            //    -handle a scenario where the number of students is not the same for each track


            //// Get the number 
            Console.Write("Enter the number of tracks: ");
            int numTracks = int.Parse(Console.ReadLine());
            //decler  arr
            int[][] studentAges = new int[numTracks][];

            // Loop to input the student ages for each track
            for (int i = 0; i < numTracks; i++)
            {
                // Get the number of students 
                Console.Write($"Enter the number of students for Track {i + 1}: ");
                int numStudents = int.Parse(Console.ReadLine());

                studentAges[i] = new int[numStudents];

                // get age in trake
                Console.WriteLine($"Enter the ages for Track {i + 1}:");
                for (int j = 0; j < numStudents; j++)
                {
                    Console.Write($"Age of student {j + 1}: ");
                    studentAges[i][j] = int.Parse(Console.ReadLine());
                }
            }

            // Display 
            Console.WriteLine("Student Ages by Track:");
            for (int i = 0; i < numTracks; i++)
            {
                Console.WriteLine($"Track {i + 1}: {studentAges[i]}");
            }

            // Calculate and display the average age 
            Console.WriteLine("Average Age for Each Track:");
            for (int i = 0; i < numTracks; i++)
            {
                // Calculate the average age 
                double sum = 0;
                for (int j = 0; j < studentAges[i].Length; j++)
                {
                    sum += studentAges[i][j];
                }
                double avgAge = sum / studentAges[i].Length;
                Console.WriteLine($"Track {i + 1} Average Age: {avgAge}");
            }







            #endregion

            #region Write a program that store student age for many tracks
            //// -take number of student and tracks from user
            //// - enter student ages
            ////-print the array
            ////-calculate age avg for each track

            ////enter the number of track 
            Console.WriteLine("Enter the Number of Track");
            int numOfTrack = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number of student");
            int numOfStudent = int.Parse(Console.ReadLine());

            int[,] TrackOfAgeStudent = new int[numOfTrack, numOfStudent];

            //loop 
            for (int i = 0; i < numOfTrack; i++)
            {
                Console.WriteLine($"Track {i + 1}");

                for (int j = 0; j < numOfStudent; j++)
                {
                    Console.WriteLine($"Enter age of Student {j + 1} in Track {i + 1}:");
                    int ageOfStudent = int.Parse(Console.ReadLine());
                    //store
                    TrackOfAgeStudent[i, j] = ageOfStudent;
                }
            }

            ////display

            Console.WriteLine("Student Ages by Track:");
            for (int i = 0; i < numOfTrack; i++)
            {
                Console.Write($"Track {i + 1}:");
                int sumOfTrack = 0;
                for (int j = 0; j < numOfStudent; j++)
                {
                    Console.Write($" {TrackOfAgeStudent[i, j]} " + "  ");
                    sumOfTrack += TrackOfAgeStudent[i, j];
                    //Console.WriteLine(sumOfTrack);
                }
                double avgOfTrack = (double)sumOfTrack / numOfStudent;
                Console.WriteLine($"\nAverage Age for Track {i + 1}: {avgOfTrack}");
            }



            #endregion

            #region Define a struct named Rectangle with two properties: Width and Height.
            //-Implement All the Necessary Getters&Setters Functions on the Structure
            //-Add methods Area and Perimeter to calculate the area and perimeter of the rectangle.
            //- Add a method Getstring to display the rectangle's dimensions. 

            Rectangle rec1 = new Rectangle(5.5, 3.2);
            Console.WriteLine(rec1.GetString());
            Console.WriteLine($"Area: {rec1.Area()}");
            Console.WriteLine($"Perimeter: {rec1.Perimeter()}");

            #endregion

            #region Define a struct named TimeSpan with three properties: Hours, Minutes, and Seconds.
            //-Implement All the Necessary Getters&Setters Functions on the Structure
            //-Add a method TotalSeconds that calculates the total number of seconds represented by the time span.
            //- Add a method Getstring to display the time span in HH: MM: SS format.
            //-Create an array of time, take array size &data from user and print it


            //Get the number of time spans from the user

            Console.Write("Enter the number of time spans: ");
            int size = int.Parse(Console.ReadLine());

            TimeSpan[] timeSpans = new TimeSpan[size];

            // Input each time span
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter TimeSpan {i + 1} details:");

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Minutes: ");
                int minutes = int.Parse(Console.ReadLine());

                Console.Write("Seconds: ");
                int seconds = int.Parse(Console.ReadLine());

                // Initialize the TimeSpan 
                timeSpans[i] = new TimeSpan(hours, minutes, seconds);
            }

            // Display each time span and its total seconds
            Console.WriteLine("Time Spans Entered:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"TimeSpan {i + 1}: {timeSpans[i].GetString()}, Total Seconds: {timeSpans[i].TotalSeconds()}");
            }


            //Bonus:
            //    - try to sort array using sort function, if it doesn’t work try to implement your
            //    own sort fun

            for (int i = 0; i < timeSpans.Length ; i++)
            {
                for (int j = 0; j < timeSpans.Length; j++)
                {
                    if (timeSpans[i].TotalSeconds() > timeSpans[j].TotalSeconds())
                    {
                        TimeSpan temp = timeSpans[i];
                        timeSpans[i] = timeSpans[j];
                        timeSpans[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array sort in Decending order");
           
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"TimeSpan  {i + 1}: {timeSpans[i].GetString()}, Total Seconds: {timeSpans[i].TotalSeconds()}");
            }
            #endregion
        }
    }

#region Struct Rectangle
    struct Rectangle
    {
        //member
        double width;
        double height;

        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                { throw new ArgumentException("Width must be positive."); }

            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                { throw new ArgumentException("Height must be positive."); }

            }
        }


        // Constructor  width and height
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Method to calc the area
        public double Area()
        {
            return Width * Height;
        }

        // Method to calc the perimeter 
        public double Perimeter()
        {
            return 2 * (Width + Height);
        }

        // Method to return a string representing the rectangle’s dimensions
        public string GetString()
        {
            return $"Rectangle Dimensions: Width = {Width}, Height = {Height}";
        }

    }


    }

#endregion

#region Struct TimeSpan
struct TimeSpan

{
    // properties
     int hours;
     int minutes;
     int seconds;

    // setter && getter for hour
    public int Hours
    {
        get { return hours; }
        set
        {
            if (value >= 0)
            {
                this.hours = value;
            }
            else
            {
                throw new ArgumentException("Hours must be non-negative.");
            }
        }
    }

    // setter && getter for Minutes
    public int Minutes
    {
        get { return minutes; }
        set
        {
            if (value >= 0 && value < 60)
            {
               this.minutes = value;
            }
            else
            {
                throw new ArgumentException("Minutes must be between 0 and 59.");
            }
        }
    }

    // setter && getter for second
    public int Seconds
    {
        get { return seconds; }
        set
        {
            if (value >= 0 && value < 60)
            {
                this.seconds = value;
            }
            else
            {
                throw new ArgumentException("Seconds must be between 0 and 59.");
            }
        }
    }

    // Constructor 
    public TimeSpan(int hours, int minutes, int seconds)
    {
        Hours = hours;   
        Minutes = minutes; 
        Seconds = seconds; 
    }

    // Method to calculate the total number of seconds
    public int TotalSeconds()
    {
        return (Hours * 3600) + (Minutes * 60) + Seconds;
    }


 

    // Method to return a string representing the time span in HH:MM:SS format
    public string GetString()
    {
        return $"{Hours}:{Minutes}:{Seconds}";
    }
}

#endregion






