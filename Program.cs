using System;
using System.Collections;
using System.Reflection;

public static class Program
{
    public static void Main(string[] args)
    {
        bool looping = true;
        Console.WriteLine("Hello! \nWelcome to the game! \nTo Start choose one of the three choices to throw out.");
        var play = new GameLoop();
        while(looping)
        {
            string yn = GameLoop.gameLoop();
            if(yn.ToUpper() == "Y")
            {
                looping = true;
            }
            else
            {
                int wins = play.getwinCount();
                int losses = play.getlossCount();
                int ties = play.gettieCount();
                looping = false;
                Console.WriteLine("Game Over! \nNumber of Wins: " + wins + " \nNumber Of Losses: " + losses + " \nNumber Of Ties: " + ties);
            }
        }
    }
}
