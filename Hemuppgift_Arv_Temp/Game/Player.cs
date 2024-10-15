using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public abstract class Player
    {
        public string UserId { get; set; }

        // Constructor for creating a player with a user ID
        public Player(string userId)
        {
            UserId = userId;
        }

        // Method to return the player ID
        public string GetUserId()
        {
            return UserId;
        }

        // Abstract method to take pins (must be implemented by subclasses)
        public abstract int TakePins(Board board);
    }
}
