// make Batman find bomb... passes first 3 tests... but need to troubleshoot GetHalf function

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
        inputs = Console.ReadLine().Split(' ');
        int X0 = int.Parse(inputs[0]);
        int Y0 = int.Parse(inputs[1]);
        int HalfFactor = 2;
        int HalfToRight = GetHalf(X0, W);
        int HalfToLeft = GetHalf(X0, 0);
        int HalfToDown = GetHalf(Y0, H);
        int HalfToUp = GetHalf(Y0, 0);

        Console.Error.WriteLine($"HTR:{HalfToRight}, HTD:{HalfToDown}");

        int GetHalf(int position, int edge)
        {
            return (int)Math.Ceiling((double)(position + edge) / 2);
        }

        // game loop
        while (true)
        {
            string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            Console.Error.WriteLine(bombDir);
            Console.Error.WriteLine($"starting x:{X0}, y:{Y0}");
            Console.Error.WriteLine($"building dimen W:{W}, H:{H}");

            // the location of the next window Batman should jump to.
            
            Y0 = (bombDir.Contains("U") ? -HalfToUp : bombDir.Contains("D") ? HalfToDown : Y0);
            X0 = (bombDir.Contains("L") ? -HalfToLeft : bombDir.Contains("R") ? HalfToRight : X0);
            Console.Error.WriteLine($"Going to {X0} {Y0}");
            Console.WriteLine($"{X0} {Y0}");
            HalfFactor *= 2;
        }
    }
}