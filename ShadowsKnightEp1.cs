// passes first 5 tests... need to change function.

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
        
        
		int MoveCount = 1;
		int InitialGapY = 0;
		int InitialGapX = 0;

		int NextYPosition(string direction)
		{
			if (direction.Contains("U"))
			{
				return Y0 - (int)Math.Ceiling((InitialGapY / Math.Pow(2, MoveCount)));
			}
			if (direction.Contains("D"))
			{
				return Y0 + (int)Math.Ceiling((InitialGapY / Math.Pow(2, MoveCount)));
			}
			else return Y0;
		}

        int NextXPosition(string direction)
		{
			if (direction.Contains("L"))
			{
				return X0 - (int)Math.Ceiling((InitialGapX / Math.Pow(2, MoveCount)));
			}
			if (direction.Contains("R"))
			{
				return X0 + (int)Math.Ceiling((InitialGapX / Math.Pow(2, MoveCount)));
			}
			else return X0;
		}

        // game loop
        while (true)
        {
            string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)

            InitialGapY = bombDir.Contains("U") ? Y0 : bombDir.Contains("D") ? H - Y0 : 0;
            InitialGapX = bombDir.Contains("L") ? X0 : bombDir.Contains("R") ? W - X0 : 0;

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            Console.Error.WriteLine(bombDir);
            Console.Error.WriteLine($"starting x:{X0}, y:{Y0}");
            Console.Error.WriteLine($"building dimen W:{W}, H:{H}");

            // the location of the next window Batman should jump to.
            
            Y0 = NextYPosition(bombDir);
            X0 = NextXPosition(bombDir);
            Console.Error.WriteLine($"Going to {X0} {Y0}");
            Console.WriteLine($"{X0} {Y0}");
            MoveCount += 1;
        }
    }
}