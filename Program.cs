using System;
using System.Collections;
using System.Reflection;

public static class Program
{
    public static void Main(string[] args)
    {
        bool looping = true;
        //this code here is to start up the game, introduce the player to it 
        Console.WriteLine("Hello! \nWelcome to the game! \nTo Start choose one of the three choices to throw out.");
        GameLoop play = new GameLoop();
        while(looping)//while looping is true it will keep playing, and keep adding more score to the win, loss, and tie scores
        {
            string yn = GameLoop.gameLoop();
            if(yn.ToUpper() == "Y")
            {
                looping = true;
            }
            else
            {
                int wins = play.getWinCount();
                int losses = play.getLossCount();
                int ties = play.getTieCount();
                looping = false;//when the player answers N to the question, it breaks out of the loop and outputs the final score 
                Console.WriteLine("Game Over! \nNumber of Wins: " + wins + " \nNumber Of Losses: " + losses + " \nNumber Of Ties: " + ties);
            }
        }
    }
}
