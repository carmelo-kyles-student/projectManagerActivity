using System;


public class Program
{
    public static void Main(string[] args)
    {
    Console.WriteLine("Hello! \n Welcome to the game! \nTo Start choose one of the three choices to throw out.");
    gameLoop();

    if(!(looping))
        {
            Console.WriteLine("Game Over! \n Number of Wins: " + winCount + " \n Number Of Losses: " + lossCount);
        }
    }
    else
    {
        gameLoop();
    }
}
