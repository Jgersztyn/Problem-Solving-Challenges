using System;
using System.Collections.Generic;

namespace CodingTests
{
    public class BasicTest
    {
        public int MakeChange(double amount)
        {
            if (amount <= 0)
            {
                return 0;
            }

            int result = 0;

            while(amount > 0)
            {
                if(amount >= coins.GetValueOrDefault("Quarter"))
                {
                    result = result + 1;
                    amount = amount - coins.GetValueOrDefault("Quarter");
                }
                else if (amount >= coins.GetValueOrDefault("Dime"))
                {
                    result = result + 1;
                    amount = amount - coins.GetValueOrDefault("Dime");
                }
                else if (amount >= coins.GetValueOrDefault("Nickel"))
                {
                    result = result + 1;
                    amount = amount - coins.GetValueOrDefault("Nickel");
                }
                else
                {
                    result = result + 1;
                    amount = amount - coins.GetValueOrDefault("Penny");
                }
            }

            return result;
        }

        public static Dictionary<string, double> coins = new Dictionary<string, double>()
        {
            { "Quarter", 0.25 },
            { "Dime", 0.10 },
            { "Nickel", 0.05 },
            { "Penny", 0.01 }
        };
    }
}
