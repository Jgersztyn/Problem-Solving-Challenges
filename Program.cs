using System;

namespace CodingTests
{
    class Program
    {
        // some old coding samples found here
        // http://codercareer.blogspot.com/2011/10/no-15-fibonacci-sequences.html

        static void Main(string[] args)
        {
            // value to pass into the function
            double dollarAmount = 1.09;

            // Instantiate class
            BasicTest testInstance = new BasicTest();

            // Execute code from given test
            int minimumCoins = testInstance.MakeChange(dollarAmount);

            // Show result
            if(minimumCoins > 0)
            {
                Console.WriteLine("Minimum number of coins to make change is " + minimumCoins);
            }
            else
            {
                Console.WriteLine("No change required.");
            }         
        }
    }
}
