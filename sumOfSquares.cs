// return sum of squares of inputs

using System;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split(' ');
        int Sum = 0;
        for (int i = 0; i < N; i++)
        {
            int xi = int.Parse(inputs[i]);
            Sum += xi * xi;
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(Sum);
    }
}