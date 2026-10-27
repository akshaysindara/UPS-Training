
using System;

class NumberAnalyzer
{
    static void Main()
    {
        int[] numbers = new int[8];
        int count = 0;

        
        while (count < 8)
        {
            Console.Write($"Enter integer {count + 1}: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                numbers[count] = number;
                count++;
            }
            else
            {
                Console.WriteLine("Invalid input! Enter a valid integer.");
            }
        }

        int even = 0, odd = 0;
        int positive = 0, negative = 0, zero = 0;

        
        foreach (int n in numbers)
        {
            if (n % 2 == 0)
                even++;
            else
                odd++;

            if (n > 0)
                positive++;
            else if (n < 0)
                negative++;
            else
                zero++;
        }

        Console.WriteLine("\n--- Number Analysis ---");
        Console.WriteLine($"Even numbers: {even}");
        Console.WriteLine($"Odd numbers: {odd}");
        Console.WriteLine($"Positive numbers: {positive}");
        Console.WriteLine($"Negative numbers: {negative}");
        Console.WriteLine($"Zero values: {zero}");

        
        int largest = 0, secondLargest = 0;
        bool hasLargest = false, hasSecond = false;

        foreach (int n in numbers)
        {
            if (!hasLargest || n > largest)
            {
                if (hasLargest)
                {
                    secondLargest = largest;
                    hasSecond = true;
                }

                largest = n;
                hasLargest = true;
            }
            else if (n < largest &&
                     (!hasSecond || n > secondLargest))
            {
                secondLargest = n;
                hasSecond = true;
            }
        }

        if (hasSecond)
            Console.WriteLine($"Second-largest distinct number: {secondLargest}");
        else
            Console.WriteLine("No second-largest distinct number exists.");

        
        Console.WriteLine("\nOriginal array:");
        foreach (int n in numbers)
            Console.Write(n + " ");

        for (int i = 0, j = numbers.Length - 1; i < j; i++, j--)
        {
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }

        Console.WriteLine("\nReversed array:");
        foreach (int n in numbers)
            Console.Write(n + " ");

        Console.WriteLine();
    }
}
