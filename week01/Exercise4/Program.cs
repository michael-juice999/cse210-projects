using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.Write("Enter a list of numbers, type 0 when finished: ");

        // numbers.Add(number);
        // Console.Write(numbers);
        // int outPut = Console.Read();

        while (true)
        {
            Console.WriteLine("Enter number: ");
            string num = Console.ReadLine();
            int number = int.Parse(num);

            if (number == 0)
            {
                break;
            }

            else if (number != 0)
            {
                numbers.Add(number);
                Console.Write(numbers);
                int outPut = Console.Read();
            }

            

            

        }

        
    }
}