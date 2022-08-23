namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder");
            int numberOfPlayers = 1;
            int startPosition = 0;

            Random random = new Random();
            int numberOnDie = random.Next(1, 7);
            Console.WriteLine(numberOnDie);

        }
    }
}