// shortest... output odd nums through N

using System;
class Solution
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)if (i % 2 != 0) Console.WriteLine(i);
    }
}