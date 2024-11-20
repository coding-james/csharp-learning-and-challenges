using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codecademy.Projects
{
    public class MoneyMaker
    {
        public static void CoinConverter(string[] args)
        {
            int goldCoinValue = 10;
            int silverCoinValue = 5;

            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Please enter the amount of coins you'd like to convert");
            string inputAmountString = Console.ReadLine();
            Console.WriteLine($"You entered {inputAmountString}");

            double inputAmountDouble = Convert.ToDouble(inputAmountString);
            Console.WriteLine($"{inputAmountDouble} is equal to...");

            double goldCoins = Math.Floor(inputAmountDouble / goldCoinValue);
            double remainder = inputAmountDouble % goldCoinValue;

            double silverCoins = Math.Floor(remainder / silverCoinValue);
            remainder = remainder % silverCoinValue;

            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {Math.Floor(remainder)}");
        }
    }
}
