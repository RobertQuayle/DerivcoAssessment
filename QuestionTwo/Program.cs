using System;
using DerivcoGames;

namespace QuestionTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setup
            string[] testRange = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "14", "15", "16", "17", "18", "19", "20", };

            string[] testSets = { "Clubs", "Diamonds", "Hearts", "Spades", "Manxs" };

            // Test 1: No Params
            HighCard testOne = new();

            Console.WriteLine("\n*** TEST ONE ***\n");

            for (int i = 0; i < 10; i++)
            {
                testOne.Play();
                Console.WriteLine("");
            }

            // Test 2: Custom Range Param
            HighCard testTwo = new(testRange);

            Console.WriteLine("\n*** TEST TWO ***\n");

            for (int i = 0; i < 10; i++)
            {
                testTwo.Play();
                Console.WriteLine("");
            }

            // Test 3: Custom Sets Param
            HighCard testThree = new(null, testSets);

            Console.WriteLine("\n*** TEST THREE ***\n");

            for (int i = 0; i < 10; i++)
            {
                testThree.Play();
                Console.WriteLine("");
            }

            // Test 4: Custom Range & Sets Params
            HighCard testFour = new(testRange, testSets);

            Console.WriteLine("\n*** TEST FOUR ***\n");

            for (int i = 0; i < 10; i++)
            {
                testFour.Play();
                Console.WriteLine("");
            }

            // Test 5: Custom Range, Custom Sets & Compare sets on tie Params
            HighCard testFive = new(testRange, testSets, true);

            Console.WriteLine("\n*** TEST FIVE ***\n");

            for (int i = 0; i < 10; i++)
            {
                testFive.Play();
                Console.WriteLine("");
            }

            // Test 6: Custom Range, Custom Sets, Compare sets on tie & No-Tie Params
            HighCard testSix = new(testRange, testSets, true, true);

            Console.WriteLine("\n*** TEST SIX ***\n");

            for (int i = 0; i < 10; i++)
            {
                testSix.Play();
                Console.WriteLine("");
            }

            // Test 7: Custom Range, Custom Sets, Compare sets on tie, No-Tie & Wildcard Params
            HighCard testSeven = new(testRange, testSets, true, true, true);

            Console.WriteLine("\n*** TEST SEVEN ***\n");

            for (int i = 0; i < 10; i++)
            {
                testSeven.Play();
                Console.WriteLine("");
            }

        }
    }

}