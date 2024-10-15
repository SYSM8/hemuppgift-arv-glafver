using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string userId) : base(userId) { }

        // Implementation of the method for a human player to take pins
        public override int TakePins(Board board)
        {
            Console.WriteLine("How many pins would you like to take (1 or 2)?");
            int pins;

            // Ensures valid input (1 or 2)
            while (!int.TryParse(Console.ReadLine(), out pins) || (pins != 1 && pins != 2))
            {
                Console.WriteLine("Invalid input. Please choose 1 or 2.");
            }

            board.TakePins(pins);
            return pins;
        }
    }
}
