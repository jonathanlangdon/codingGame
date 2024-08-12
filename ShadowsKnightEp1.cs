// passed all tests

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
        
        
		List<int> PossibleY = new List<int>();
		List<int> PossibleX = new List<int>();
		int MovesMade = 0;

		int NextPosition(string direction, string axis)
		{
            if (axis == "Y")
            {
			    return PossibleY[PossibleY.Count() / 2];
            }
            else if (axis == "X")
            {
                return PossibleX[PossibleX.Count() / 2];   
            }
            else return 0;
		}


		void InitialPossible(string direction, string vertex)
		{
			int Position = 0;
			int Max = 0;
			if (vertex == "Y")
			{
				Position = Y0;
				Max = H - 1;
			}
			else if (vertex == "X")
			{
				Position = X0;
				Max = W - 1;
			}
			int FirstY = direction == "L" ? 0 : direction == "G" ? Position + 1 : Position;
			int CountPossible = direction == "L" ? Position - 1 : direction == "G" ? Max - Position : 1;
			if (vertex == "Y")
			{
				PossibleY = Enumerable.Range(FirstY, CountPossible).ToList();
			}
			else if (vertex == "X")
			{
				PossibleX = Enumerable.Range(FirstY, CountPossible).ToList();
                Console.Error.WriteLine($"X Possible: {String.Join(", ", PossibleX)}");
			}
		}

		void UpdatePossible(string direction, string vertex)
		{
			List<int> ActiveList = new List<int>();
			int Position = 0;

			if(vertex == "Y")
			{
				ActiveList = PossibleY;
				Position = Y0;
			}
			else if (vertex == "X")
			{
				ActiveList = PossibleX;
				Position = X0;
			}
            if (direction == "L")
            {
                ActiveList = ActiveList.Where(y => y < Position).ToList();
            }
            if (direction == "G")
            {
                ActiveList = ActiveList.Where(y => y > Position).ToList();
            }
			if(vertex == "Y")
			{
				PossibleY = ActiveList;
			}
			else if (vertex == "X")
			{
				PossibleX = ActiveList;
			}
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

                        // G = greater, L = Less
			string DirectionY = bombDir.Contains("U") ? "L" : bombDir.Contains("D") ? "G" : "No";
			string DirectionX = bombDir.Contains("L") ? "L" : bombDir.Contains("R") ? "G" : "No";

			if(MovesMade == 0) 
			{
				InitialPossible(DirectionY, "Y");
				InitialPossible(DirectionX, "X");
			}
			else
			{
				UpdatePossible(DirectionY, "Y");
				UpdatePossible(DirectionX, "X");
			}
			MovesMade += 1;
			Y0 = NextPosition(DirectionY, "Y");
			X0 = NextPosition(DirectionX, "X");

            // the location of the next window Batman should jump to.
            Console.Error.WriteLine($"Going to {X0} {Y0}");
            Console.WriteLine($"{X0} {Y0}");
        }
    }
}