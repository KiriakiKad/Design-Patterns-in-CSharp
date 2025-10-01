using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilderDP
{
    public class Burger
    {
        public string TypeOfBread { get; set; }
        public string TypeOfMeat { get; set; }
        public string TypeOfCheese { get; set; }
        public List<string> Sauces { get; set; } = new List<string>();
        public List<string> Extras { get; set; } = new List<string>();

        public override string ToString()
        {
            return $"Burger with {TypeOfBread} bread, {TypeOfMeat} patty, " +
                   $"{TypeOfCheese} cheese, Sauces: {string.Join(", ", Sauces)}, " +
                   $"Extras: {string.Join(", ", Extras)}";
        }
    }
}
