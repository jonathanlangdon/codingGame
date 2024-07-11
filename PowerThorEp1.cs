// v1 of Power of Thor - Ep 1 - variables created, but need some troubleshooting

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTx = int.Parse(inputs[2]); // Thor's starting X position
        int initialTy = int.Parse(inputs[3]); // Thor's starting Y position

        int displaceX = lightX - initialTx;

        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.


            int displaceY = lightY - initialTy;
            int distX = Math.Abs(displaceX);
            int distY = Math.Abs(displaceY);
            string directionX = "";
            string directionY = "";
            if (displaceX > 0) directionX = "E";
            else directionX = "W";
            if (displaceY > 0) directionX = "S";
            else directionX = "N";


            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            for (int i = 0; i < distX; i++)
            {
                Console.WriteLine(directionX);
            }

            for (int i = 0; i < distY; i++)
            {
                Console.WriteLine(directionY);
            }

            // A single line providing the move to be made: N NE E SE S SW W or NW
        }
    }
}