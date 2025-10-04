using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDiscountStrategyDP;

public class NoDiscount: IDiscountStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine("No discount for the amount of " +amount + " euros");
    }
}
