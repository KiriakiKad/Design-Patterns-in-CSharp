using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDiscountStrategyDP;

public class DiscountContext
{
    private IDiscountStrategy _discountStrategy;

    public DiscountContext(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public void SetStrategy(IDiscountStrategy strategy)
    {
        _discountStrategy = strategy;
    }

    public void Pay(double amount) 
    { 
        _discountStrategy.Pay(amount);
    }
}
