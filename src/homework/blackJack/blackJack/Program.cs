using System;

namespace blackJack
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = GameStartMenu();
            }
            Console.ReadLine();
        }
        public static bool GameStartMenu()
        {

            Console.WriteLine("\nWelcome to the game of BLACKJACK!\n");

            Console.WriteLine("For exit, press \"X\"");
            Console.WriteLine("For new game to Start, press \"S\"");

            string userInput = Console.ReadLine();
            if (userInput == "x" || userInput == "X")
            {
                Console.WriteLine("You pressed: '" + userInput + "' Exit from game");
                return false;

            }
            else if (userInput == "s" || userInput == "S")
            {
                Console.Clear();
                Console.WriteLine("This is the Game of BlackJack\n");
                Console.WriteLine("For winning you should:");
                Console.WriteLine();
                Console.WriteLine("* Get 21 points, without a dealer blackjack\n" +
                               "* Reach a final score higher than the dealer without exceeding 21\n" +
                                "* Let the dealer draw additional cards until their hand exceeds 21");
                Game();
                //return false;
                return true;
                //Console.Clear();
            }
            else
            {
                Console.WriteLine("wrong key! Try again");
                return true;
            }
        }
        private static void Game()
        {
            int userCardValue = 0;
            int dealerCardValue = 0;
            int userScore = 0;
            int dealerScore = 0;

            Random random = new Random();
            userCardValue += (random.Next(1, 12));
            dealerCardValue += (random.Next(1, 12));


            Console.WriteLine("\nUus mäng\n");
            Console.WriteLine("Your total score is: " + userScore + " , House score ise " + dealerScore);

            

            //Console.Clear();

            while (true)
            {
                if (userCardValue == 21)
                {
                    Console.WriteLine("You have won!");
                    userScore++;
                    Console.WriteLine("House score: " + dealerScore + " vs Your score: " + userScore);

                    break;
                }
                Console.WriteLine("Your current card value is: " + userCardValue +
                    "\nTo you want another hit?\nIf yes, press \"h\", if no, press \"n\"");
                string userInput2 = Console.ReadLine();

                if (userInput2 == "H" || userInput2 == "h")
                {
                    Console.WriteLine("You pressed: " + userInput2);
                    userCardValue += (random.Next(1, 12));
                    if (userCardValue > 21 && dealerCardValue <= 21)
                    {
                        Console.WriteLine("Game over, you have exceeded 21. Your card value is: " + userCardValue);
                        break;
                    }
                }
                else if (userInput2 == "N" || userInput2 == "n")
                {
                    Console.WriteLine("You pressed: '" + userInput2 + "', so no card");
                    if (userCardValue < dealerCardValue || dealerCardValue == 21)
                    {
                        Console.WriteLine("House has won");
                        dealerScore++;
                        Console.WriteLine("House score: " + dealerScore + " vs Your score: " + userScore);
                        break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("You pressed a wrong key, try again");
                    continue;
                }
            }
            // Dealers turn
            if (userCardValue <= 21)
            {
                Console.WriteLine("Your card value is: " + userCardValue.ToString());
            }

            else
            {
                while (dealerCardValue < 21 && dealerCardValue < userCardValue)
                {
                    dealerCardValue += (random.Next(1, 12));

                }
                if (userCardValue == dealerCardValue || userCardValue > 21 && dealerCardValue > 21)
                {
                    Console.WriteLine("Player and house have tied");
                }
                else if (userCardValue < dealerCardValue && dealerCardValue <= 21)
                {
                    Console.WriteLine("House wins");
                    dealerScore++;
                    Console.WriteLine("House score: " + dealerScore + " vs Your score: " + userScore);

                }
                else if (dealerCardValue > 21 && dealerCardValue < userCardValue && userCardValue < 21)
                {
                    Console.WriteLine("House loses");
                    userScore++;
                    Console.WriteLine("House score: " + dealerScore + " vs Your score: " + userScore);

                }
                else if (dealerCardValue == 21)
                {
                    Console.WriteLine("House wins");
                    dealerScore++;
                    Console.WriteLine("House score: " + dealerScore + " vs Your score: " + userScore);

                }

            }
            Console.WriteLine("House had: " + dealerCardValue.ToString());
            Console.WriteLine("House score: " + dealerScore + " vs Your score: " + userScore);
        }
    }
}
