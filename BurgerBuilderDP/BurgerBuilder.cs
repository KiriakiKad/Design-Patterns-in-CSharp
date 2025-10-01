using System;
using System.Collections.Generic;

namespace BurgerBuilderDP
{
    public class BurgerBuilder
    {
        private Burger _burger = new Burger();

        public BurgerBuilder WithBread(string bread)
        {
            _burger.TypeOfBread = bread;
            return this;
        }

        public BurgerBuilder WithMeat(string meat)
        {
            _burger.TypeOfMeat = meat;
            return this;
        }

        public BurgerBuilder WithCheese(string cheese)
        {
            _burger.TypeOfCheese = cheese;
            return this;
        }

        public BurgerBuilder AddSauce(string sauce)
        {
            _burger.Sauces.Add(sauce);
            return this;
        }

        public BurgerBuilder AddExtra(string extra)
        {
            _burger.Extras.Add(extra);
            return this;
        }

        public Burger Build()
        {
            return _burger;
        }
    }
}
