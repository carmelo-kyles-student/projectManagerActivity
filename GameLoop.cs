using System;

public class GameLoop
{
    public static int winCount = 0;
    public static int lossCount = 0;
    public static int tieCount = 0;
    public static Random random = new Random();
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
    public static string gameLoop()
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
                    tieCount++;
                }
                else if (genNum == 1)
                {
                    Console.WriteLine("lose");
                    lossCount++;

                }
                else if (genNum == 2)
                {
                    Console.WriteLine("win");
                    winCount++;
                }
                break;
            case 1:
                if (genNum == 0)
                {
                    Console.WriteLine("win");
                    winCount++;
                }
                if (genNum == 1)
                {
                    Console.WriteLine("tie");
                    tieCount++;
                }
                if (genNum == 2)
                {
                    Console.WriteLine("loss");
                    lossCount++;
                }
                break;
            case 2:
                if (genNum == 0)
                {
                    Console.WriteLine("loss");
                    lossCount++;
                }
                else if (genNum == 1)
                {
                    Console.WriteLine("win");
                    winCount++;
                }
                else if (genNum == 2)
                {
                    Console.WriteLine("tie");
                    tieCount++;
                }
                break;
        }

        Console.WriteLine("Y/N to going again?");
        return Console.ReadLine();
    }

    public int getwinCount()
    {
        return winCount;
    }
    public int getlossCount()
    {
        return lossCount;
    }
    public int gettieCount()
    {
        return tieCount;
    }
}