using System.ComponentModel;
using System.Drawing;
using System.Numerics;
using System.Reflection.PortableExecutable;
using static Day5.Program;

namespace Day5
{

    internal class Program
    {
        static void Main(string[] args)
        {

            #region  Part1
            //Design a Class to represent the Question Object, Question is  constructed from a Body, Marks, and Header and ........
            // We want the application to accept different Question Types, True or False, Choose One and Choose All each has a different way off representation.
            // We need to define a Base Question class and every type as an inherited one.
            // Write down all the necessary Properties(Instead of setters and getters)
            // Define all the Necessary Constructors for the class
            // We want to provide the class’s with the standard capabilities to
            //represent data in a string
            // Create array of question that accept only question type :True or False,
            //Choose One and Choose All.

            // Create an Array of Questions
            Question[] questions = new Question[]
            {
            new TrueFalseQuestion("General Knowledge", "The Earth is flat.", 5, false),
            new ChooseOneQuestion(
                "Math",
                "What is 2 + 2?",
                10,
                new string[] { "3", "4", "5" },
                1
            ),
            new ChooseAllQuestion(
                "Science",
                "Which of these are planets?",
                15,
                new string[] { "Mercury", "Sun", "Venus", "Moon" },
                new bool[] { true, false, true, false }
            )
            };

            // Display All Questions
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i].ToString());
                Console.WriteLine("___________________________________________");

            }

            #endregion

            #region part2
            //Write a program with a Math class that has four methods: Add, Subtract,
            //Multiply, and Divide, each of which takes two parameters.Call each
            //method from Main().
            // Modify the program so that you do not have to create an instance of Math
            //to call the four methods


            //call methode
            Console.WriteLine("Enter First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = int.Parse(Console.ReadLine());

            //with create object
            Math obj1 = new Math(num1, num2);
            Console.WriteLine(obj1.ToString());

            //without create object


            Console.WriteLine($"The sum of two numbers: {Math1.Add(num1, num2)}");
            Console.WriteLine($"The subtraction of two numbers: {Math1.Sub(num1, num2)}");
            Console.WriteLine($"The multiplication of two numbers: {Math1.Mul(num1, num2)}");
            Console.WriteLine($"The division of two numbers: {Math1.Div(num1, num2)}");

            #endregion

            #region Part3
            #region quesion
            //Define Class Duration To include Three Attributes(Hours, Minutes,Seconds)
            //Support All Required Constructors to Produce this output:
            //Duration D1 = new Duration(1, 10, 15);
            //D.getstring();
            //Output: Hours: 1, Minutes: 10 , Seconds: 15
            //Duration D1 = new Duration(3600);
            //D.getstring();
            //Output: Hours: 1, Minutes: 0 , Seconds: 0
            //Duration D2 = new Duration(7800);
            //D.getstring();
            //Output: Hours: 2, Minutes: 10 , Seconds: 0
            //Duration D3 = new Duration(666);
            //D.getstring();
            //Output: Minutes: 11 , Seconds: 6
            //Implement All required Operators overloading’s to enable this Code
            //D3 = D1 + D2
            //D3 = D1 + 7800
            //D3 = 666 + D3
            //D3 = D1++(Increase One Minute)
            //D3 = --D2; (Decrease One Minute)
            //D1 = -D2;
            //If(D1 > D2);
            //If(D1 <= D2);
            //If(D1);
            //DateTime Obj = (DateTime)D1
            #endregion
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.getstring());
            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.getstring());
            Duration D5 = new Duration(7800);
            Console.WriteLine(D5.getstring());
            Duration D4 = new Duration(666);
            Console.WriteLine(D4.getstring());


            //Implement All  Operator
            Duration D3  = D1 + D2;
            Console.WriteLine(D3.getstring());
            Duration D7 = D1 + 7800;
            Console.WriteLine(D7.getstring());
            Duration D8 = D1++;
            Console.WriteLine(D8.getstring());
            Duration  D6 = --D2;
            Console.WriteLine(D6.getstring());
            Duration D9 = -D2;
            Console.WriteLine(D9.getstring());
            if (D1 > D2)
                Console.WriteLine("D1 is greater than D2");
            else
                Console.WriteLine("D1 is not greater than D2");

            if (D1)
                Console.WriteLine("D1 is valid and greater than zero.");

            DateTime dt = (DateTime)D1;
            Console.WriteLine($"Converted DateTime: {dt}");

            #endregion


        }

        #region  Part1
        public class Question
        {
            public string Header { get; set; }
            public string Body { get; set; }
            public int Marks { get; set; }

            //Constractor
            public Question(string header, string body, int marks)
            {

                Header = header;
                Body = body;
                Marks = marks;

            }

            // Virtual Method for String Representation
            public virtual string ToString()
            {
                return $"Header: {Header}\nBody: {Body}\nMarks: {Marks}";
            }


        }

        // True or False Question Class
        public class TrueFalseQuestion : Question
        {
            public bool Answer { get; set; }

            public TrueFalseQuestion(string header, string body, int marks, bool answer) : base(header, body, marks)
            {
                Answer = answer;
            }

            public override string ToString()
            {
                return $"[True/False]\n{base.ToString()}\nAnswer: {Answer}";
            }
        }
        // Choose One Question Class
        public class ChooseOneQuestion : Question
        {
            public string[] Options { get; set; }
            public int CorrectOption { get; set; }

            public ChooseOneQuestion(string header, string body, int marks, string[] options, int correctOption)
                : base(header, body, marks)
            {
                Options = options;
                CorrectOption = correctOption;
            }

            public override string ToString()
            {
                return $"[Choose One]\n{base.ToString()}\nOptions: {string.Join(", ", Options)}\nCorrect Option: {CorrectOption}";
            }
        }

        // Choose All Question Class
        public class ChooseAllQuestion : Question
        {
            public string[] Options { get; set; }
            public bool[] CorrectAnswers { get; set; }

            public ChooseAllQuestion(string header, string body, int marks, string[] options, bool[] correctAnswers)
                : base(header, body, marks)
            {
                Options = options;
                CorrectAnswers = correctAnswers;
            }

            public override string ToString()
            {
                string correctAnswersDisplay = string.Join(", ", CorrectAnswers);
                return $"[Choose All]\n{base.ToString()}\nOptions: {string.Join(", ", Options)}\nCorrect Answers: {correctAnswersDisplay}";
            }
        }


    }

    #endregion

        #region part2
    // Write a program with a Math class that has four methods: Add, Subtract,
    //Multiply, and Divide, each of which takes two parameters.Call each
    //method from Main().
    // Modify the program so that you do not have to create an instance of Math
    //to call the four methods
    public class Math
        {
           //proberties
           public int number1 {  get; set; }
            public int number2 { get; set; }

            //constractor
            public Math(int number1 ,int number2 )
            {
                this.number1 = number1;
                this.number2 = number2; 
            }
            public int Add()
            {
                return number1 + number2;
            }
            public int Sub() {
                return number1 - number2; }
            public int Mul() {
                return number1 * number2; }
            public int Div() {
                return number1 / number2; }

            //call 
            public string ToString()
            {
                return $"the sum of Two Number {Add()}\n the substraction of Two Number {Sub()}\n the Multiblication of Two Number {Mul()}\n the diviation of Two Number {Div()}\n ";
            }


         


        }
        #region static
        // Modify the program so that you do not have to create an instance of Math
        //to call the four methods
        public static class Math1
        {
            //proberties
            public static int number1 { get; set; }
            public static int number2 { get; set; }

        
            public static int Add(int number1 , int number2)
            {
                return number1 + number2;
            }
            public static int Sub(int number1, int number2)
            {
                return number1 - number2;
            }
            public static int Mul(int number1, int number2)
            {
                return number1 * number2;
            }
            public static int Div(int number1, int number2)
            {
                return number1 / number2;
            }

            
         
        }
        #endregion

        #endregion

        #region Part3:
        public class Duration
        {
            //properties
            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }

            //constractor
            public Duration(int hour, int min, int sec)
            {
                this.Hours = hour;
                this.Minutes = min;
                this.Seconds = sec;
                ConvertTime();
            }

            public Duration(int sec)
            {
                this.Seconds = sec;
                ConvertTime();


            }
            public string getstring()
            {
                string txt;
                if(Hours == 0)
                    txt= $" Minutes :{Minutes} , Seconds :{Seconds}";
                else
                    txt = $"Hours: {Hours}, Minutes :{Minutes} , Seconds :{Seconds}";

               return txt ;
            }


            private void ConvertTime()
            {
                if (Seconds >= 60)
                {
                    Minutes += Seconds / 60;
                    Seconds %= 60;
                }
                if (Minutes >= 60)
                {
                    Hours += Minutes / 60;
                    Minutes %= 60;
                }
            }
            public static Duration operator +(Duration x, Duration y)
            {
                return new Duration(x.Hours + y.Hours, x.Minutes + y.Minutes, x.Seconds + y.Seconds);

            }
            // Overload + operator for Duration + int (seconds)
            public static Duration operator +(Duration x, int seconds)
            {
                return new Duration(x.Hours, x.Minutes, x.Seconds + seconds);
            }
            // Overload + operator for int (seconds) + Duration
            public static Duration operator +(int seconds, Duration x)
            {
                return x + seconds;
            }

            // increase one minute
            public static Duration operator ++(Duration x)
            {
                x.Minutes++;
                x.ConvertTime();
                return x;
            }

            //  decrease one minute
            public static Duration operator --(Duration x)
            {
                x.Minutes--;
                x.ConvertTime();
                return x;
            }

            // - 
            public static Duration operator -(Duration x)
            {
                return new Duration(-x.Hours, -x.Minutes, -x.Seconds);
            }

            //  > operator
            public static bool operator >(Duration x, Duration y)
            {
                return x.TotalSeconds() > y.TotalSeconds();
            }

            //  < operator
            public static bool operator <(Duration x, Duration y)
            {
                return x.TotalSeconds() < y.TotalSeconds();
            }

            //  >= operator
            public static bool operator >=(Duration x, Duration y)
            {
                return x.TotalSeconds() >= y.TotalSeconds();
            }

            //  <= operator
            public static bool operator <=(Duration x, Duration y)
            {
                return x.TotalSeconds() <= y.TotalSeconds();
            }

            //  true/false
            public static bool operator true(Duration x)
            {
                return x.TotalSeconds() > 0;
            }

            public static bool operator false(Duration x)
            {
                return x.TotalSeconds() <= 0;
            }

            //  DateTime
            public static explicit operator DateTime(Duration x)
            {
                return new DateTime(1, 1, 1, x.Hours, x.Minutes, x.Seconds);
            }

            // Method to get total seconds for comparison
            private int TotalSeconds()
            {
                return Hours * 3600 + Minutes * 60 + Seconds;
            }

        }
         #endregion


        }
}