using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace Ships
{
    public class Ship
    {

        public int x, y;

        public char shipChar;

        public string shipType;

        public int rotation = 0; //Rotations - 0 = 0, 1 = right 90, 2 = 180, 3 = left 90

        public Ship(int xInput, int yInput,string shipTypeInput, int rotationInput = 0)
        {


            x = xInput;
            y = yInput;
            shipType = shipTypeInput;
            rotation = rotationInput;

            Console.WriteLine("Ship " + shipTypeInput + " created");


        }
    }
}
