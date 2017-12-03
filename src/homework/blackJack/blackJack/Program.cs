using System;

namespace blackJack
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of BLACKJACK!\n");


            Console.WriteLine("For exit, press \"X\"");
            Console.WriteLine("For new game, press \"N\"\n");

            Console.WriteLine("For winning you should:");
            Console.WriteLine("* Get 21 points, without a dealer blackjack\n" +
                              "* Reach a final score higher than the dealer without exceeding 21\n" +
                              "* Let the dealer draw additional cards until their hand exceeds 21");
            Console.WriteLine();

          

            /*
             * 
             *Heart,
             *Diamond,
             *Spade,
             *Club,
             *
             *Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, 
             *
             *Ten, Jack, Queen, King == 10
             *
             * Ace = 1 || 11;
             * 
             * 
             *random nr for user
             *random nr for dealer
             
             
            //You have been dealt:
            //House has been dealt: 

            //What do you want to do next?

            Hit: Take another card from the dealer.  "Press "H"
            Stand: Take no more cards.               "Press "S"   

            if pressed "H", deal a new card 
            elseif pressed "s" no card is added

            elseif pressed "n", new game
            elseif pressed "x", exit the game
            else "you pressed a wrong key!"


             if userSum == 21 "you got the BLACKJACK! (you are the winner)
             if dealerSum == 21 "dealer wins"
             if dealerSum < userSum "user wins"
             if dealerSum > userSum "dealer wins"



            your score: Wins / Loses

            */



            Console.ReadLine();
        }
    }
}
