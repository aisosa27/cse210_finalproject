using System;

namespace BlackjackGamie
{
    class Program
    {
        static void Main(string[] args)
        {
            const double initialamount = 500.00;

            double playercash = initialamount;
            string name = "Unnamed";
            int age = 0;
            string Role = "Player";
            string skilllevel = "Beginner";
            string card = "Ace of Hearts";
            int gamesplayed = 0;
            string Nickname = "";

            Console.WriteLine("Please insert your name and press <Enter>:");
            name = Console.ReadLine();

            Console.WriteLine("Please insert your age and press <Enter>:");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please insert your nickname and press <Enter>:");
            Nickname = Console.ReadLine();

            if (Nickname == "")
            {
                Nickname = "No nickname";
            }

            Console.WriteLine("Enter how many games you have played so far and press <Enter>:");
            gamesplayed = int.Parse(Console.ReadLine());

            if (gamesplayed < 05)
            {
                skilllevel = "Beginner";
            }
            else if (gamesplayed < 10)
            {
                skilllevel = "Intermediate";
            }
            else if (gamesplayed < 20)
            {
                skilllevel = "Advanced";
            }
            else
            {
                skilllevel = "Expert";
            }

            Console.Title = "BlackJackLight";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  .-----------. ");
            Console.WriteLine(" /------------/|");
            Console.WriteLine("/.-----------/||");
            Console.WriteLine("| ~      ~   |||");
            Console.WriteLine("| BlackJack  |||");
            Console.WriteLine("|            |||");
            Console.WriteLine("|     -      |||");
            Console.WriteLine("|            |||");
            Console.WriteLine("|    Game    |||");
            Console.WriteLine("| ~       ~  ||/");
            Console.WriteLine("\\-----------./  ");
            Console.WriteLine("");
            Console.ResetColor();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine($"| {skilllevel} | {Role} | {name} {age} |  {Nickname} |");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine($"Hello {name}");
            Console.WriteLine($"{name}, your money count is: {playercash}$");
            Console.WriteLine("1. New game");
            Console.WriteLine("2. Reset stats");
            Console.WriteLine("3. Exit");

            Console.WriteLine("\nPlease type in menu option number and press <Enter>");
            string selectedMenuOption = Console.ReadLine();

            switch (selectedMenuOption)
            {
                case "1":
                    Console.WriteLine("Shuffling the deck..");
                    Console.WriteLine("Done shuffling the deck.");
                    Console.WriteLine("Serving the cards");

                    var randomGenerator = new Random();
                    var firstCardScore = randomGenerator.Next(1, 10);
                    var secondCardScore = randomGenerator.Next(1, 10);
                    var thirdCardScore = 0;

                    Console.WriteLine($"Your first card score is: {firstCardScore}");
                    Console.WriteLine($"Your second card score is: {secondCardScore}");
                    Console.WriteLine($"Would like to get served another card?\n1. Yes 2. No");
                    var shouldDeal = Console.ReadLine();

                    if (shouldDeal == "1")
                    {
                        thirdCardScore = randomGenerator.Next(1, 10);
                        Console.WriteLine($"Your third card score is: {thirdCardScore}");
                    }

                    var totalCardScore = firstCardScore + secondCardScore + thirdCardScore;

                    Console.WriteLine($"Total card score: {totalCardScore}");

                    if (totalCardScore > 21)
                    {
                        Console.WriteLine("Game over..\n\nPress any key to quit");
                        Console.ReadKey();
                        return;
                    }

                    var dealerHand = randomGenerator.Next(10, 21);

                    Console.WriteLine($"Your dealer total card score: {dealerHand}");

                    if (totalCardScore <= dealerHand)
                    {
                        Console.WriteLine("Dealer won! Game over..\n\nPress any key to quit");
                        Console.ReadKey();
                        return;
                    }

                    Console.WriteLine("Congratulations!!\nYou won!!\n\nPress any key to quit");
                    Console.ReadKey();
                    return;
                case "2":
                    Console.WriteLine("Are you sure you want to reset your stat?\n1. Yes\n2. No");
                    string promptAnswer = Console.ReadLine();
                    if (promptAnswer == "1")
                    {
                        gamesplayed = 0;
                        playercash = initialamount;
                        skilllevel = "Beginner";

                        Console.WriteLine("Stats were reset");
                    }
                    break;
                case "3":
                    Console.WriteLine("Exiting Blackjack");
                    return;
            }

            Console.ReadKey();
        }
    }
}