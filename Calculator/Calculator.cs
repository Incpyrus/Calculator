using System;

namespace Calculator
{
    class MainClass
    {
        static void Main(string[] args)
        {

            double firstNumber;
            double secondNumber;
            double a;
            double b;
            double result1;
            double result2;
            double result3;
            double result4;
            double result5;



            Console.WriteLine("First Number");
            firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Second Number");
            secondNumber = double.Parse(Console.ReadLine());


            Add add = new Add();
            Subtract subtract = new Subtract();
            Multiply multiply = new Multiply();
            Divide divide = new Divide();
            Percentage percentage = new Percentage();

            result1 = add.Addition(firstNumber, secondNumber);
            Console.WriteLine("Addition: " +result1);

            result2 = subtract.Subtraction(firstNumber, secondNumber);
            Console.WriteLine("Subtraction: " + result2);

            result3 = multiply.Multiplication(firstNumber, secondNumber);
            Console.WriteLine("Multiplication: " + result3);

            result4 = divide.Division(firstNumber, secondNumber);
            Console.WriteLine("Division: " + result4);

            Console.WriteLine("Press 1 to calculate Percentage or any other number to exit the program");
            double x = double.Parse(Console.ReadLine());

            if(x == 1){
                Console.WriteLine("Enter the x: " );
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the y: ");
                b = double.Parse(Console.ReadLine());
                result5 = percentage.Percent(a, b);
                Console.WriteLine("Percentage: " + result5 +"%");

            }
            else{
                Console.WriteLine("Ending now!");

            }
        }
    }
}
