using CSTest.Interfaces;
using CSTest.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTest
{
    public class TradeCategorizer
    {
        private readonly List<ITradeCategorizationRule> rules;

        public TradeCategorizer(List<ITradeCategorizationRule> rules)
        {
            this.rules = rules;
        }

        public TradeCategory CategorizeTrade(ITrade trade)
        {
            foreach (var rule in rules)
            {
                var category = rule.CategorizeTrade(trade);
                if (category != TradeCategory.HIGHRISK)
                    return category;
            }
            return TradeCategory.HIGHRISK; // Categoria padrão se não for categorizado
        }
    }

}
