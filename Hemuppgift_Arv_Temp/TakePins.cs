using Hemuppgift_Arv_Temp.Game;

namespace Hemuppgift_Arv_Temp
{
    public class TakePinsGame
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to game!");
            Board board = new Board();
            board.SetUp(10);

            Player human = new HumanPlayer("Human");
            human.TakePins(board);
            Console.WriteLine($"Remaining pins: {board.GetNoPins()}");
        }

    }
}
