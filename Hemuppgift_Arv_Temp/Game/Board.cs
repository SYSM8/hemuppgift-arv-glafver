using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class Board
    {
        private int noPins;

        // Method to set the number of pins on the board
        public void SetUp(int pins)
        {
            noPins = pins;
        }

        // Method to remove a certain number of pins from the board
        public void TakePins(int pins)
        {
            if (pins < 1 || pins > 2)
            {
                Console.WriteLine("You can only take 1 or 2 pins.");
                return;
            }

            if (pins > noPins)
            {
                Console.WriteLine("You can't take more pins than what's left.");
                return;
            }

            noPins -= pins;
        }

        // Method to get the number of remaining pins
        public int GetNoPins()
        {
            return noPins;
        }
    }
}
