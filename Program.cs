using System;
using System.Collections.Generic;

namespace Wallstreet
{
    class Program
    {
        static string Main(string[] args)
        {
            var stocks = new Dictionary<string,string>();
            stocks.Add("GDDY", "Go Daddy");
            stocks.Add("MGM", "MGM Resorts");
            stocks.Add("RCL", "Royal Carribbean");
            stocks.Add("BA", "Boeing");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add(("GDDY",45,45.81));
            Console.WriteLine(string.Join("CASH",stocks["GDDY"]));
        }
    }
}
