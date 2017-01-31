using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionCoinFlips
{
    class Program
    {
        //Test
        static void Main(string[] args)
        {
            bool stopflipping = false;
            Coin penny = new Coin();

            while (!stopflipping)
            {
                for (int i = 0; i < 1000000; i++)
                {
                    penny.FlipCoin();
                }
                penny.DisplayFlipStatistics();
                if (QueryYesOrNo())
                {
                    stopflipping = false;
                }
                else
                {
                    stopflipping = true;
                }
            }
        }

        private static bool QueryYesOrNo()
        {
        //ResetDisplay();
        bool answer;
        string userResponse;
        Console.Write("Would you like to flip again? Type yes or no:");

        userResponse = Console.ReadLine().ToUpper();
        switch (userResponse)
        {
            case "YES":
                answer = true;
                break;
            case "NO":
                answer = false;
                break;
            default:
                answer = false;
                break;
        }
        Console.Clear();
        return answer;
        }

        private static void ResetDisplay()
        {
            DisplayContinuePrompt();
            Console.Clear();
        }

        private static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    
    }
}
