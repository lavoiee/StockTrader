using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrader
{
    class Stock
    {
        private string company;
        private decimal sharePrice;
        private string tickerSymbol;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public decimal SharePrice
        {
            get { return sharePrice; }
            set { sharePrice = value; }
        }
        
        public string TickerSymbol
        {
            get { return tickerSymbol; }
            set { tickerSymbol = value; }
        }

        //
        // Constructors
        //
        public Stock()
        {

        }

        public Stock(string company)
        {
            this.company = company;
        }

        public Stock(string company, decimal sharePrice)
        {
            this.company = company;
            this.sharePrice = sharePrice;
        }

        public Stock(string company, decimal sharePrice, string tickerSymbol)
        {
            this.company = company;
            this.sharePrice = sharePrice;
            this.tickerSymbol = tickerSymbol;
        }


        //
        // Methods
        //
        public string GetCompany()
        {
            return this.company;
        }

        public decimal GetSharePrice()
        {
            return this.sharePrice;
        }

        public string GetPriceAsString()
        {
            string price = this.sharePrice.ToString();
            price = String.Format("{0:0.00}", price);
            return price;
        }

        public string GetTickerSymbol()
        {
            return this.tickerSymbol;
        }
    }
}
