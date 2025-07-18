using System;

class Program
{
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string input = Console.ReadLine();
        return input; 
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string num = Console.ReadLine();
        int inputNum = int.Parse(num);
        
        return inputNum;
    }

    static int SquareNumber(int inputNum)
    {

        int Square = (inputNum * inputNum);

        return Square;
    }


    static void Main(string[] args)
    {
        string name = PromptUserName();
        

        int number = PromptUserNumber();
        

        int square = SquareNumber(number);
        

        Console.Write($"{name}, the square of your number is {square}");

    }
}