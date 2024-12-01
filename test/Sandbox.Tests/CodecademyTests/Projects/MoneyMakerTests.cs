using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.Codecademy.Projects;

namespace Sandbox.Tests.CodecademyTests.Projects
{
    public class MoneyMakerTests

    {
        [Theory]
        [InlineData(1, 0, 0, 1)]
        [InlineData(16, 1, 1, 1)]
        [InlineData(98, 9, 1, 3)]
        [InlineData(5000, 500, 0, 0)]
        public void CoinConverter(int userInput, int goldCoins, int silverCoins, int bronzeCoins)
        {

            var userInputString = Convert.ToString(userInput);
            var expectedOutput = $"Welcome to Money Maker!{Environment.NewLine}" +
                                $"Please enter the amount of coins you'd like to convert{Environment.NewLine}" +
                                $"You entered {userInput}{Environment.NewLine}" +
                                $"{userInput} is equal to...{Environment.NewLine}" +
                                $"Gold coins: {goldCoins}{Environment.NewLine}" +
                                $"Silver coins: {silverCoins}{Environment.NewLine}" +
                                $"Bronze coins: {bronzeCoins}{Environment.NewLine}";

            using (var swCoinConverter = new StringWriter())
            {
                Console.SetOut(swCoinConverter); using (var srCoinConverter = new StringReader(userInputString))
                {
                    Console.SetIn(srCoinConverter);

                    // Act
                    MoneyMaker.CoinConverter(null);

                    // Assert
                    var result = swCoinConverter.ToString();
                    Assert.Equal(expectedOutput, result);
                }
            }
        }
    }
}
