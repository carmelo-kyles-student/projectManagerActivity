using System;

public class GameLoop
{
    public static int winCount = 0;
    public static int lossCount = 0;
    public static int tieCount = 0;
    public static Random random = new Random();
    /**
    We wanted a simple yet effective way to create a new random number and to be able to print out the "AI's" choice
    This function here was the first one we wanted to get finished as quickly as possible due to its necessity to the rest of the functions
    
    
    **/
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
    /**
    gameLoop
    returns a string of Y or N which conntrols the looping of the game. 
    starts by taking an input of a string of rock, paper, or scissors. 
    then that gets converted into an int to help with ease of debugging and human readability
    the use of switch statements was again also for better reading 
    **/

    
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
            case 0://IF PLAYER CHOOSES ROCK
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
            case 1://IF PLAYER CHOOSES PAPER
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
            case 2://IF PLAYER CHOOSES SCISSORS
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

    public int getWinCount()
    {
        return winCount; //RETURNS THE COUNT OF WINS
    }
    public int getLossCount()
    {
        return lossCount;//RETURNS THE COUNT OF LOSSES
    }
    public int getTieCount()
    {
        return tieCount;//RETURNS THE COUNT OF TIES 
    }
}