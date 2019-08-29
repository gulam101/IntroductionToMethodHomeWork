using System;



namespace CalculatorApp
{
    class Program : Calculator
    {

        static void Main()
        {
            Console.WriteLine("C# Calculater, Created By Gulam Qasim");

            Console.WriteLine("-----------------------------------"); // Draws a line between the first writeline and the second writeline

            Input input = new Input(); 
            BMI bmi = new BMI();                           
            


            Console.WriteLine("1 for Calculator");
            Console.WriteLine("2 for the BMI");
            Console.WriteLine(""); //Keeps a space between the message and the user choice

            Console.Write("Please type in the option you want: ");

            string text = Console.ReadLine();
            if (text == "1")
            {
                input.userSelection(); //Just calling the selection method
            }
            else if (text == "2") {
                bmi.BMICalcu();
            }
            else 
            {
                Console.WriteLine("Invalid command, please use the keys 1 and 2");
                Main();
            }
            Console.ReadKey();
        }
    }



    class Calculator
    {
        public double Multiply(double a, double b)
        {
            return a * b;
        }



        public double Adding(double a, double b)
        {
            return a + b;
        }



        public double Subtraction(double a, double b)
        {
            return a - b;
        }


        public double Remainder(double a, double b)
        {
            return a % b;
        }


        public double Divide(double a, double b)
        {
            return a / b;
        }
    }



    class BMI
    {

        public void BMICalcu()
        {
            double userBMI;
            Console.WriteLine("BMI ");
            Console.Write("Please enter your weight in kg: ");
            double userHeight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter your height in cm: ");
            double userWeight = Convert.ToDouble(Console.ReadLine());

            userBMI = userWeight * 10000 / (userHeight * userHeight);

            if (userBMI <= 18.5)
            {
                Console.WriteLine("You're underweight!");
            }
            else if (userBMI >= 18.5 && userBMI <= 24.9)
            {

                Console.WriteLine("You are healthy weight!");
            }
            else if (userBMI >= 25 && userBMI <= 29.9)
            {
                Console.WriteLine("You are overweight!");
            }
            else if (userBMI >= 30)
            {
                Console.WriteLine("You are overweight!");
            }
        }
    }


    class Input
    {
        public void userSelection()
        {
            Calculator calc = new Calculator(); //Creating an object to access the calculator methods

            
            Console.Write("Please enter the first number: ");
            double testnum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the operator: ");
            string operators = Console.ReadLine();
            Console.Write("Please enter the second number: ");
            double testnum2 = Convert.ToDouble(Console.ReadLine());
            if (operators == "+") { Console.WriteLine("Total: " + calc.Adding(testnum, testnum2)); }
            else if (operators == "-") { Console.WriteLine("Total: " + calc.Subtraction(testnum, testnum2)); }
            else if (operators == "*") { Console.WriteLine("Total: " + calc.Multiply(testnum, testnum2)); }
            else if (operators == "/") { Console.WriteLine("Total: " + calc.Divide(testnum, testnum2)); }
            else if (operators == "%") { Console.WriteLine("Total: " + calc.Remainder(testnum, testnum2)); }
                else
                    {
                Console.WriteLine("Invalid control, please try again!");
                userSelection();
                }
        }
    }
}