using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionCoinFlips
{
    class Coin
    {
        //
        // Fields
        //
        public bool heads;
        public int flips = 0;
        public int numberOfHeads = 0;
        public int numberOfTails = 0;
        public double bias;
        Random random = new Random();


        //
        // Properties
        //
        public double Bias
        {
            get { return bias; }
            set { bias = value; }
        }


        public int Flips
        {
            get { return flips; }
            set { flips = value; }
        }

        public bool Heads
        {
            get { return heads; }
            set { heads = value; }
        }

        //
        // Constructors
        //
        public Coin()
        {

        }

        public Coin(bool heads)
        {
            this.heads = heads;
        }

        public Coin(bool heads, int flips)
        {
            this.heads = heads;
            this.flips = flips;
        }

        public Coin(bool heads, int flips, double bias)
        {
            this.heads = heads;
            this.flips = flips;
            this.bias = bias;
        }

        //
        // Methods
        //
        public bool FlipCoin()
        {
            //
            // Get a random integer and use to set whether the coin being
            // flipped is heads or tails. Increment number of flips.
            flips += 1;
            int randomNum;
            //randomNum = random.Next(0, 9);
            randomNum = random.Next(1, 2);

            //////////////////NEW METHOD USING MODULO///////////////////////
            if (randomNum % 2 != 0)
            {
                heads = true;
                numberOfHeads += 1;
            }
            else
            {
                heads = false;
                numberOfTails += 1;
            }
            //FlipNotification(heads);
            return heads;




            //////////////////FIRST METHOD//////////////////////////////////
            //
            // If 5 or less the coin being flipped will be heads
            // if more than 5 it will be tails.
            //
            // Maybe switch this to check if it is even or odd and
            // use that to set the bool instead. Seems to be coming up
            // heads more ofter with this method as it is now.
            //
            //if (randomNum <= 5)
            //{
            //    heads = true;
            //    numberOfHeads += 1;
            //}
            //else
            //{
            //    heads = false;
            //    numberOfTails += 1;
            //}
            //FlipNotification(heads);
            //return heads;
        }

        public void FlipNotification(bool heads)
        {
            Console.WriteLine("Flipping Coin...");
            ResetDisplay();
            if (heads)
            {
                Console.WriteLine("The coin flipped heads!");
            }
            else
            {
                Console.WriteLine("The coin flipped tails!");
            }
            ResetDisplay();
        }

        public void DisplayFlipStatistics()
        {
            Console.WriteLine($"Number of heads:{numberOfHeads}");
            Console.WriteLine($"Number of tails:{numberOfTails}");
            Console.WriteLine($"Total number of flips:{flips}");
            Console.WriteLine($"Percentage of heads:{Percentagizer((double)numberOfHeads / flips)}%");
            ResetDisplay();
        }

        private object Percentagizer(double v)
        {
            v *= 100;
            return v;
        }

        public void ResetDisplay()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
