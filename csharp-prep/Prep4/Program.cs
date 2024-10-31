using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        int addedNumber = 1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, enter 0 when finished.");
        do{
            Console.Write("Enter a number: ");
            addedNumber = int.Parse(Console.ReadLine());
            if(addedNumber != 0){
            numbers.Add(addedNumber);
            }

        }while (addedNumber != 0);

        int sum = 0;
        int largestNumber = -9999999;
        foreach (int num in numbers){
            sum += num;
        }
        Console.WriteLine($"The sum of the list is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of the list is {average}");

        foreach (int num in numbers){
            if (num > largestNumber){
                largestNumber = num;
            }
        }
        Console.WriteLine($"The largest number is {largestNumber}");

        int bigNum = 1000000;
        foreach (int num in numbers){
            if (num > 0 && num < bigNum){
                bigNum = num;
            }
        }
        Console.WriteLine($"The smallest positive number is {bigNum}");

        numbers.Sort();
        foreach (int num in numbers){
            Console.WriteLine(num);
        }

    }
}