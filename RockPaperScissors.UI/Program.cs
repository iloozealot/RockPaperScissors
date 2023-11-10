// RockPaperScissors
// Author: Justin Spencer
// This program simulates the popular hand game Rock, Paper, Scissors.


bool gameLoop = true;
int userPoints = 0;
int computerPoints = 0;

while (gameLoop)
{
    Console.WriteLine("Welcome to Rock, Paper, Scissors");
    Console.WriteLine("Please type 1, 2, or 3 for your choice: ");
    Console.WriteLine("1. Rock, 2. Paper, 3. Scissors ");

    string? userChoice = Console.ReadLine();

    Random randomChoice = new Random();
    int computerChoice = randomChoice.Next(1, 4);

    switch (computerChoice)
    {
        case 1:
            if (userChoice == "1")
            {
                //this is a tie
                Console.WriteLine("User chose rock");
                Console.WriteLine("Computer chose rock");
                Console.WriteLine("It is a tie");
            }

            else if (userChoice == "2")
            {
                Console.WriteLine("User chose paper");
                Console.WriteLine("Computer chose rock");
                Console.WriteLine("It is a user win");
                userPoints++;
            }

            else if (userChoice == "3")
            {
                Console.WriteLine("User chose scissors");
                Console.WriteLine("Computer chose rock");
                Console.WriteLine("It is a computer win");
                computerPoints++;
            }
            break;

        case 2:
            if (userChoice == "1")
            {
                Console.WriteLine("User chose rock");
                Console.WriteLine("Computer chose paper");
                Console.WriteLine("It is a computer win");
                computerPoints++;
            }

            else if (userChoice == "2")
            {
                Console.WriteLine("User chose paper");
                Console.WriteLine("Computer chose paper");
                Console.WriteLine("It is a tie");
            }

            else if (userChoice == "3")
            {
                Console.WriteLine("User chose scissors");
                Console.WriteLine("Computer chose paper");
                Console.WriteLine("It is a computer loss");
                userPoints++;
            }
            break;

        case 3:
            if (userChoice == "1")
            {
                Console.WriteLine("User chose rock");
                Console.WriteLine("Computer chose scissors");
                Console.WriteLine("It is a computer loss");
                userPoints++;
            }

            else if (userChoice == "2")
            {
                Console.WriteLine("User chose paper");
                Console.WriteLine("Computer chose scissors");
                Console.WriteLine("It is a computer win");
                computerPoints++;
            }

            else if (userChoice == "3")
            {
                Console.WriteLine("User chose scissors");
                Console.WriteLine("Computer chose scissors");
                Console.WriteLine("It is a tie");
            }
            break;
    }

    Console.WriteLine("Do you want to play again?");
    Console.WriteLine("Enter Y or N");

    string? playAgain = Console.ReadLine();  

    if (playAgain != null)
    {
        if (playAgain == "N" || playAgain == "n" || playAgain== "no")
        {
            gameLoop = false;
            Console.WriteLine($"User has {userPoints} and Computer has {computerPoints}");


        }
    }

}


