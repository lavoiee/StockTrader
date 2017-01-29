using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probabilitiesOdds
{
    class Player
    {
        Coin penny = new Coin();
        private double wager;
        private double bank;

        public double Bank
        {
            get { return bank; }
            set { bank = value; }
        }


        public double Wager
        {
            get { return wager; }
            set { wager = value; }
        }

        public Player()
        {

        }

        public Player(double wager)
        {
            this.wager = wager;
        }

        public Player(double wager, double bank)
        {
            this.wager = wager;
            this.bank = bank;
        }
    }
}
