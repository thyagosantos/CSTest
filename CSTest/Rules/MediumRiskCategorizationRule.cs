using CSTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTest.Rules
{
    public class MediumRiskCategorizationRule : ITradeCategorizationRule
    {
        public TradeCategory CategorizeTrade(ITrade trade)
        {
            if (trade.Value >= 1000000 && trade.ClientSector == "Public")
                return TradeCategory.MEDIUMRISK;
            return TradeCategory.HIGHRISK;
        }
    }
}
