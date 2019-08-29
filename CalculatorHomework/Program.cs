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
            


            Console.Write("1 for Calculator 2 for bmi: ");
            string text = Console.ReadLine();
            if (text == "1")
            {
                input.userSelection(); //Just calling the selection method
            }
            else if (text == "2") { }
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



        public double Divide(double a, double b)
        {
            return a / b;
        }
    }



    class BMI
    {



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
            if (operators == "-") { Console.WriteLine("Total: " + calc.Subtraction(testnum, testnum2)); }
            if (operators == "*") { Console.WriteLine("Total: " + calc.Multiply(testnum, testnum2)); }
            if (operators == "/") { Console.WriteLine("Total: " + calc.Divide(testnum, testnum2)); }
        }
    }



}