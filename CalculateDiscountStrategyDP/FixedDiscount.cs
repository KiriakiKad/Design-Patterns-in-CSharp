using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDiscountStrategyDP;

public class FixedDiscount: IDiscountStrategy
{
    public void Pay(double amount)
    {
        if (amount >= 5)

            amount = amount - 5;
        else
            amount = 0;

        Console.WriteLine("You get a 5 euro discount. The final price is: " + amount + " euros");
    }
}
