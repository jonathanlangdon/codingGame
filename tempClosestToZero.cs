// find closest temp to zero

using System;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] inputs = Console.ReadLine().Split(' ');

        int ClosestToZero = 999999999;
        if (n == 0) ClosestToZero = 0;
        else
        {
            foreach (string temp in inputs)
            {
                int TempInt = int.Parse(temp);
                int AbsTemp = Math.Abs(TempInt);
                int AbsClosestToZero = Math.Abs(ClosestToZero);
                if (AbsTemp < AbsClosestToZero) ClosestToZero = TempInt;
                else if (AbsTemp == AbsClosestToZero)
                {
                    if (TempInt > 0) ClosestToZero = TempInt;
                }
            }
        }

        Console.WriteLine(ClosestToZero);
    }
}