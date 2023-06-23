// Display the sum of n natural number
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer:");
        int n = int.Parse(Console.ReadLine());

        int sum = CalculateSum(n);

        Console.WriteLine("The sum of the first {0} natural numbers is: {1}", n, sum);
    }

    static int CalculateSum(int n)
    {
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        return sum;
    }
}
