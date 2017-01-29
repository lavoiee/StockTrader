using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using probabilitiesOdds;

namespace probabilitiesOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stopflipping = false;

            //
            // Try instantiating two coins next.
            //
            Coin penny = new Coin();
            Player firstPlayer = new Player();

            //
            // How do I access the Coin class that is a member of Player?
            //

            while (!stopflipping)
            {
                
                penny.FlipCoin();
                penny.DisplayFlipStatistics();

                if (QueryYesOrNo())
                {
                    stopflipping = false;
                }
                else
                {
                    stopflipping = true;
                }
                //ResetDisplay();                
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
