﻿using System;
using MarketDataMonitorAPI;

namespace Example
{
    public class GetSecurityPriceTechnicalsSmaExample
    {

        public static void Main()
        {
            //initializes method from SMADayAverage class and sets it to a variable
            SMADayAverage RealTimeSMAAverage = new SMADayAverage();

            //calls method from SMADayAverage class
            var SMAAverageDay_20 = RealTimeSMAAverage.SMACurrentAverage(20);
            var SMAAverageDay_10 = RealTimeSMAAverage.SMACurrentAverage(10);
            var SMAAverageDay_5 = RealTimeSMAAverage.SMACurrentAverage(5);

            Console.WriteLine($"20SMA: { SMAAverageDay_20}");
            Console.WriteLine($"10SMA: {SMAAverageDay_10}");
            Console.WriteLine($"5SMA: {SMAAverageDay_5}");

            //initializes method from GetLatestPrice class and sets it to a variable
            GetLatestPrice RealTimePrice = new GetLatestPrice();

            //call method from GetLatestPrice class and return the decemial value
            var currentTickerPrice = RealTimePrice.TickerCurrentPrice("AAPL");

            Console.WriteLine($"LatestPrice: {currentTickerPrice}");

            //initializes method from BuyShares class and then executes buy order for ticker
            BuyShares buy = new BuyShares();
            var buyTicker = buy.ExecuteOrder("AAPL");

            //initializes method from SellShares class and then executes sell order for ticker
            SellShares sell = new SellShares();
            var sellTicker = sell.ExecuteOrder("AAPL");

            //initializes method from Account Summary class then displays gain/loss on account for the intraday
            AccountSummary ViewAccountSummary = new AccountSummary();
            var portfolioBalance = ViewAccountSummary.ExecuteBalanceView();
            Console.WriteLine(portfolioBalance);


            Console.ReadLine();


            //***************Next todo on Agenda*******************
            //create loop for cycling through the monitoring api and conditions for buying and selling


        }

    }
 }
