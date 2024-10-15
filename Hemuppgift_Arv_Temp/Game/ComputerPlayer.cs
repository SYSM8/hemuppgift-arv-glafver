using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(string userId) : base(userId) { }

        // Implementation of the method for the computer to randomly take pins
        public override int TakePins(Board board)
        {
            Console.WriteLine($"\n{UserId} is thinking...");
            Thread.Sleep(2000);
            Random random = new Random();
            int pins = random.Next(1, 3);
            board.TakePins(pins);

            Console.WriteLine($"{UserId} took {pins} pins.");
            return pins;
        }
    }
}
