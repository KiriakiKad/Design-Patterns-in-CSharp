using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilderDP
{
    class Program
    {
        static void Main(string[] args) {
            var burger = new BurgerBuilder()
                .WithBread("Classic")
                .WithMeat("Chicken")
                .WithCheese("Cheddar")
                .AddSauce("Mayo")
                .AddSauce("BBQ")
                .AddExtra("Fries")
                .Build(); 
            
            Console.WriteLine(burger); 
        }
    }
}
