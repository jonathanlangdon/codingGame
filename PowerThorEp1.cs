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

        // Calculating direction needed and displacements
        int displaceX = lightX - initialTx;
        int displaceY = lightY - initialTy;
        int distX = Math.Abs(displaceX);
        int distY = Math.Abs(displaceY);
        string directionX = "";
        string directionY = "";
        if (displaceX > 0) directionX = "E";
        else directionX = "W";
        if (displaceY > 0) directionY = "S";
        else directionY = "N";

        // Console.Error.WriteLine($"distX:{distX}");
        // Console.Error.WriteLine($"distY:{distY}");
        // Console.Error.WriteLine($"disrectionX:{directionX}");
        // Console.Error.WriteLine($"diirectionY:{directionY}");

        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); 

            string NewDirection = "";

            if (distY > 0)
            {
                NewDirection = directionY;
                distY -= 1;
            }

            if (distX > 0)
            {
                NewDirection += directionX;
                distX -= 1;
            }

            Console.WriteLine(NewDirection);
        }
    }
}