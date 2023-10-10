using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTest.Interfaces
{
    public interface ITradeCategorizationRule
    {
        TradeCategory CategorizeTrade(ITrade trade);
    }
}
