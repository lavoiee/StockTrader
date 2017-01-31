using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections; // BitArray
using System.Net.Sockets; //JSON QUANDL API Bring the data in Figure it out.
//using System.Net.WebSockets;
//using System.Net.Http;

//
// Experiment with Windows Forms Applications. And SQL Server.
// Locate a Scientific Graphing Library for graphing stock data.
// Can you use d3.js in C#? ILNumerics SVG Graphic math library
namespace StockTrader
{
    class Program
    {
        //TcpListener myfirstTcpListener = new TcpListener();
        //Thread myFirstThread = new Thread();
        //BitArray myBitArray = new BitArray();
        static Stock msft = new Stock("Microsoft", 65.78m, "MSFT");
        static Stock apple = new Stock("Apple", 121.95m, "AAPL");
        static Stock ford = new Stock("Ford", 12.49m, "F");
        static List<Stock> stocks = new List<Stock>();

        static bool exit = false;

        static void Main(string[] args)
        {
            InitializeList();                   
            while (!exit)
            {
                DisplayMenu();                
            }           
        }

        private static void DisplayTradeModule()
        {
            
        }

        private static void InitializeList()
        {
            stocks.Add(msft);
            stocks.Add(apple);
            stocks.Add(ford);
        }

        private static void DisplayCompaniesModule()
        {
            Console.WriteLine();
            Console.WriteLine("Displaying records...");
            Console.WriteLine();
            foreach (Stock stock in stocks)
            {                
                Console.WriteLine($"Company name:{stock.GetCompany()}");
                Console.WriteLine($"Price per share:{stock.GetPriceAsString()}");
                Console.WriteLine($"Ticker symbol:{stock.GetTickerSymbol()}");
                Console.WriteLine();
            }

        }

        private static void DisplayMenu()
        {
            ConsoleKey keypress;
            DisplayHeader();
            DisplayMenuBar();
            

            keypress = Console.ReadKey().Key;

            DisplayHeader();
            DisplayMenuBar();

            switch (keypress)
            {
                case ConsoleKey.Escape:
                    exit = true;
                    break;
                case ConsoleKey.V:
                    DisplayCompaniesModule();
                    break;
                case ConsoleKey.T:
                    DisplayTradeModule();
                    break;
                case ConsoleKey.R:
                    DisplaySimulationModule();
                    break;
                case ConsoleKey.H:
                    DisplayHelpModule();
                    break;
                default:
                    DisplayValidFeedback();
                    break;
            }
            //DisplayContinuePrompt();
        }

        private static void DisplayMenuBar()
        {

            ColorizeTextGreen("[ESC]", "Escape ");
            ColorizeTextGreen("[V]", "iew Companies ");
            ColorizeTextGreen("[T]", "rade ");
            ColorizeTextGreen("[R]", "un Simulation ");
            ColorizeTextGreen("[H]", "elp");
            Console.WriteLine();
        }

        private static void ColorizeTextGreen(string text, string normal)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(text);
            Console.ResetColor();
            Console.Write(normal);
        }

        private static void DisplayValidFeedback()
        {
            
        }

        private static void DisplayHelpModule()
        {
            
        }

        private static void DisplaySimulationModule()
        {
            
        }

        private static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();          
        }

        private static void DisplayHeader()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("************************STOCK TRADER************************");
        }
    }
}
