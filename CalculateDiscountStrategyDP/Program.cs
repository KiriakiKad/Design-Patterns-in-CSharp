using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDiscountStrategyDP
{
    class Program
    {
        public static void Main(string[] args) 
        {
            var productPrice = 103.70;
            var context = new DiscountContext(new NoDiscount());

            context.Pay(productPrice);

            context.SetStrategy(new PercentageDiscount());
            context.Pay(productPrice);

            context.SetStrategy(new FixedDiscount());
            context.Pay(productPrice);


        }
    }
}
