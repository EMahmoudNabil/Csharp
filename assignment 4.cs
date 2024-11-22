using System.ComponentModel;
using System.Drawing;
using System.Reflection.PortableExecutable;

namespace Day4
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            //Part1:
            //2.Design and implement a class for the employees in a company
            //3.Employee is identified by an ID, salary, hire date and Gender.
            //4.Develop a Structure to represent the HiringDate Data Type consisting of
            //fields to hold the day, month and Years.
            //5.We want to provide the Employee structure with the standard capabilities
            //to represent Employee data in a string Form().
            //6.Create an array of Employees with size from user input
            //7.Write down all the necessary Properties(Instead of setters and getters)
            //8.Define all the Necessary Constructors for the class 9.Sort the
            //employees array based on their hire date
            //9. Print the sorted array.




            ////enter number of employee 
            Console.WriteLine("Enter Number of Employee");
            int numOFEmployee = int.Parse(Console.ReadLine());

            Employee[] employees = new Employee[numOFEmployee];
            //Employee employee = new Employee();

            for (int i = 0; i < employees.Length; i++)
            {

                Console.WriteLine($"Enter data of Employee number {i + 1}:");

                Console.Write("Enter ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter Salary: ");
                double salary = double.Parse(Console.ReadLine());

                Console.Write("Enter Gender (male/Female): ");
                string gender = Console.ReadLine();

                Console.WriteLine("Enter Hire Date:");
                Console.Write("Day: ");
                int day = int.Parse(Console.ReadLine());
                Console.Write("Month: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("Year: ");
                int year = int.Parse(Console.ReadLine());

                HiringDate hireDate = new HiringDate(day, month, year);
                employees[i] = new Employee(id, salary, hireDate, gender);

            }


            ////display 
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"the Data of Employee {i + 1} ");
                Console.WriteLine($"\n the ID is {employees[i].ID}  Salary : {employees[i].Salary}  Gender : {employees[i].Gender} Date : {employees[i].ToString()} ");
            }

            // Sort Employees 
            for (int i = 1; i < employees.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    // Compare Hire Dates
                    if (CompareDates(employees[j - 1].HireDate, employees[j].HireDate) > 0)
                    {

                        Employee temp = employees[j];
                        employees[j] = employees[j - 1];
                        employees[j - 1] = temp;
                    }
                    else
                    {
                        break; // 
                    }
                }
            }




            //// Method to compare two HiringDate objects
            static int CompareDates(HiringDate date1, HiringDate date2)
            {
                if (date1.Year != date2.Year)
                    return date1.Year - date2.Year; // Compare by year
                else if (date1.Month != date2.Month)
                    return date1.Month - date2.Month; // Compare by month
                else
                    return date1.Day - date2.Day; // Compare by day
            }


            Console.WriteLine("\nEmployees sorted by Hire Date:");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i]);
            }

            #endregion



        }





        #region Part1
        //Part1:
        //2.Design and implement a class for the employees in a company
        //3.Employee is identified by an ID, salary, hire date and Gender.
        //4.Develop a Structure to represent the HiringDate Data Type consisting of
        //fields to hold the day, month and Years.
        //5.We want to provide the Employee structure with the standard capabilities
        //to represent Employee data in a string Form().
        //6.Create an array of Employees with size from user input
        //7.Write down all the necessary Properties(Instead of setters and getters)
        //8.Define all the Necessary Constructors for the class 9.Sort the
        //employees array based on their hire date
        //9. Print the sorted array.
        class Employee()
    {
        string gender;
        //properties
        public int ID { get; set; }
        public double Salary { get; set; }

        public HiringDate HireDate { get; set; }
        public string Gender
        {
            set
            {
                if (value == "male" || value == "female")
                    gender = value;
                else
                    throw new Exception("Please write 'male' or 'female'.");
            }
            get
            {
                return gender;

            }
        }

        //Constractor
        public Employee(int id, double salary, HiringDate hireDate, string gender):this()
        {
            ID = id;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Salary: {Salary}, Gender: {Gender}, Hire Date: {HireDate}";
        }





    }

    #region struct Hier date
    struct HiringDate
    {


        // Properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }



        //constractor
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }



    }
        #endregion



        #endregion

    




}