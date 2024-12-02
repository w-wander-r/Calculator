using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("======================================");
        Console.WriteLine("Chose option '+', '-', '*', '/' : ");
        string chosenOperator = Console.ReadLine();

        switch (chosenOperator)
        {
            case "+":
            {
                Add();
                break;
            }
            case "-":
            {
                Subtract();
                break;
            }
            case "*":
            {
                Multiply();
                break;
            }
            case "/":
            {
                Divide();
                break;
            }
            default:
                Console.WriteLine("The program have no idea what to do with this option...");
                break;
        }
    }

    static double[] userInput()
    {
        Console.WriteLine("--------------------------------------");

        Console.WriteLine("Enter first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("--------------------------------------");


        return new double[] {number1, number2};
    }

    static void Add()
    {
        double[] numbers = userInput();
        Console.Write("The result will be: ");
        Console.WriteLine(numbers[0]+numbers[1]);
        Console.WriteLine("======================================");
    }

    static void Subtract()
    {
        double[] numbers = userInput();
        Console.Write("The result will be: ");
        Console.WriteLine(numbers[0]-numbers[1]);
        Console.WriteLine("======================================");
    }

    static void Multiply()
    {
        double[] numbers = userInput();
        Console.Write("The result will be: ");
        Console.WriteLine(numbers[0]*numbers[1]);
        Console.WriteLine("======================================");
    }

    static void Divide()
    {
        double[] numbers = userInput();
        if(numbers[1] == 0)
        {
            Console.WriteLine("Do you know what happens when u dividing number by zero? We can`t do this here...");
        }
        else
        {
            Console.Write("The result will be: ");
            Console.WriteLine(numbers[0]/numbers[1]);   
        }
        Console.WriteLine("======================================");
    }
}