using System;
using System.Collections;
using System.Reflection;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello! \nWelcome to the game! \nTo Start choose one of the three choices to throw out.");
        gameLoop();

        if (!(looping))
        {
            Console.WriteLine("Game Over! \nNumber of Wins: " + winCount + " \nNumber Of Losses: " + lossCount+ " \nNumber Of Ties: " + tieCount);
        }

        else
        {
            gameLoop();
        }
    }
    public static Random random = new Random();
    public static int winCount = 0;
    public static int lossCount = 0;
    public static int tieCount = 0;

    public static bool looping;
    public static int GenerateRandomNumber() //generate a random number between 0 and 2 
    {


        int AIchoice = random.Next(0, 3); // 0, 1, or 2
        switch (AIchoice)
        {
            case 0:
                Console.WriteLine("AI chose Rock");
                break;
            case 1:
                Console.WriteLine("AI chose Paper");
                break;
            case 2:
                Console.WriteLine("AI chose Scissors");
                break;

        }
        return AIchoice;
        //0 rock
        //1 paper 
        //2 sciscors
    }

    public static void gameLoop()
    {
        int choice = 0;
        Console.WriteLine("Rock, Paper, or Scissors");
        string userIn = Console.ReadLine();
        userIn.ToLower();
        switch (userIn)
        {
            case "rock":
                choice = 0;
                break;
            case "paper":
                choice = 1;
                break;
            case "scissors":
                choice = 2;
                break;
            default:
                Console.WriteLine("bad statement");
                break;
        }
        int genNum = GenerateRandomNumber();

        switch (choice)
        {
            case 0:
                if (genNum == 0)
                {
                    Console.WriteLine("tie");
                }
                else if (genNum == 1)
                {
                    Console.WriteLine("lose");

                }
                else if (genNum == 2)
                {
                    Console.WriteLine("win");

                }
                break;
            case 1:
                if (genNum == 0)
                {
                    Console.WriteLine("win");
                    break;
                }
                if (genNum == 1)
                {
                    Console.WriteLine("tie");
                    break;
                }
                if (genNum == 2)
                {
                    Console.WriteLine("loss");
                    break;
                }
                break;
            case 2:
                if (genNum == 0)
                {
                    Console.WriteLine("loss");
                }
                else if (genNum == 1)
                {
                    Console.WriteLine("win");
                }
                else if (genNum == 2)
                {
                    Console.WriteLine("tie");
                }
                break;
        }


    }
}
