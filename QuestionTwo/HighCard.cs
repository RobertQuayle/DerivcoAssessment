using System;

namespace DerivcoGames
{
    /*
     HighCard is an instantiable class for a card game.

     The card game puts player one and two against each other and the player with the
     highest card value/set wins.

     This class is highly customisable via the Constructor and optional params.
     */

    public class HighCard
    {
        // Fields
        private string[] range = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        private string[] sets = { "Clubs", "Diamonds", "Hearts", "Spades" };
        private bool tieCompareSets = false;
        private bool noTie = false;
        private bool wildcard = false;

        // Constructor(s)
        public HighCard(string[] customRange = null, string[] customSets = null, bool compareTie = false, bool noTie = false, bool wildcard = true)
        {
            if (customRange != null)
            {
                this.range = customRange;
            }

            if (customSets != null)
            {
                this.sets = customSets;
            }

            this.tieCompareSets = compareTie;

            this.noTie = noTie;

            this.wildcard = wildcard;
        }

        // Public Methods
        public void Play()
        {
            Random rnd = new();

            int wildcardValue = 0;
            int wildcardSet = 0;

            if (wildcard == true)
            {
                wildcardValue = rnd.Next(range.Length);
                wildcardSet = rnd.Next(sets.Length);
            }

            int playerOneCard = rnd.Next((range.Length));
            int playerOneSet = rnd.Next((sets.Length));
            Console.WriteLine($"Player 1: {range[playerOneCard]} of {sets[playerOneSet]}");

            int playerTwoCard = rnd.Next((range.Length));
            int playerTwoSet = rnd.Next((sets.Length));
            if (playerTwoCard == playerOneCard)
            {
                while (playerTwoSet == playerOneSet)
                {
                    playerTwoSet = rnd.Next(sets.Length);
                }
            }
            Console.WriteLine($"Player 2: {range[playerTwoCard]} of {sets[playerTwoSet]}");

            if (wildcard == true && playerOneCard == wildcardValue && playerOneSet == wildcardSet)
            {
                Console.WriteLine("Player One Wins by Wildcard!!!");
            }
            else if (wildcard == true && playerTwoCard == wildcardValue && playerTwoSet == wildcardSet)
            {
                Console.WriteLine("Player Two Wins by Wildcard!!!");
            }
            else if (tieCompareSets == true && playerOneCard == playerTwoCard)
            {
                if (playerOneSet > playerTwoSet)
                {
                    Console.WriteLine("Player One Wins!");
                }
                else if (playerOneSet < playerTwoSet)
                {
                    Console.WriteLine("Player Two Wins!");
                }
            }
            else if (playerOneCard > playerTwoCard)
            {
                Console.WriteLine("Player One Wins!");
            }
            else if (playerTwoCard > playerOneCard)
            {
                Console.WriteLine("Player Two Wins!");
            }
            else
            {
                if (noTie == true)
                {
                    Console.WriteLine("Re-Draw!");
                    Play();
                }
                else
                {
                    Console.WriteLine("It's a Tie!");
                }
            }

        }

    }

}