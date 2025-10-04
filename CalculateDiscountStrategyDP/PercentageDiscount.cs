using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDiscountStrategyDP;

public class PercentageDiscount: IDiscountStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine("You get a 20% discount. The final price is: " + (amount - amount*0.2) + " euros");
    }
}
