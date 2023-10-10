using CSTest.Interfaces;
using CSTest.Rules;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSTest
{
    class Program
    {
        static void Main()
        {
            var rules = new List<ITradeCategorizationRule>
        {
            new LowRiskCategorizationRule(),
            new MediumRiskCategorizationRule(),
            new HighRiskCategorizationRule()
        };

            var tradeCategorizer = new TradeCategorizer(rules);

            var portfolio = new List<ITrade>
        {
            new Trade { Value = 2000000, ClientSector = "Private" },
            new Trade { Value = 400000, ClientSector = "Public" },
            new Trade { Value = 500000, ClientSector = "Public" },
            new Trade { Value = 3000000, ClientSector = "Public" }
        };

            var tradeCategories = portfolio.Select(tradeCategorizer.CategorizeTrade).ToArray();

            Console.WriteLine("Output: tradeCategories = {" + string.Join(", ", tradeCategories.Select(tc => $"\"{tc}\"")) + "}");

        }
    }
}
