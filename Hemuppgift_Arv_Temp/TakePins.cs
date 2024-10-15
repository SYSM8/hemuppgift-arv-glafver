using Hemuppgift_Arv_Temp.Game;
using System;
using System.Linq.Expressions;

namespace Hemuppgift_Arv_Temp
{
    public class TakePinsGame
    {
        //a) Klassen Player är superklass till klasserna HumanPlayer och ComputerPlayer.

        //b) Player p = new Player("Aegon"); - Korrekt
            //Player p = new HumanPlayer("Alicent"); - Korrekt
            //HumanPlayer p = new HumanPlayer("Rhaenyra"); - Korrekt
            //HumanPlayer p = new ComputerPlayer("Aemond");- Felaktig
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Take Pins game!");

            // Setting up the board with a number of pins
            Board board = new Board();
            board.SetUp(10);

            // Get the player's name

            string? humanName;

            do
            {
                Console.WriteLine("Enter your name: ");
                humanName = Console.ReadLine();

                if (string.IsNullOrEmpty(humanName))
                {
                    Console.WriteLine("Name cannot be empty. Please try again.");
                }

            } while (string.IsNullOrEmpty(humanName));

            // Creating players
            Player human = new HumanPlayer(humanName);
            Player computer = new ComputerPlayer("Computer");

            // Assign the first player (human starts the game)
            Player currentPlayer = human;

            // Continue while there are pins remaining
            while (board.GetNoPins() > 0)
            {
                Console.WriteLine($"\nRemaining pins: {board.GetNoPins()}");

                // Current player takes pins
                currentPlayer.TakePins(board);

                // Check if all pins are taken
                if (board.GetNoPins() == 0)
                {
                    Console.WriteLine($"\n{currentPlayer.GetUserId()} wins!");
                    break;
                }

                // Switch players after each turn
                currentPlayer = currentPlayer == human ? computer : human;

                // Introduce a delay for better pacing in the game
                Thread.Sleep(1000);
            }

            Console.WriteLine("Game over! Thanks for playing.");
        }

    }
}
