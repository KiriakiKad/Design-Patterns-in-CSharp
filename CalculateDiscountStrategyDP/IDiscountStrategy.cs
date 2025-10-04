using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDiscountStrategyDP;

public interface IDiscountStrategy
{
    void Pay(double amount);
}
