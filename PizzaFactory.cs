using System;
using System.Collections.Generic;
using System.Text;

namespace Shamim
{
    public class PizzaFactory : AbstractFactory
    {

        public PizzaFactory() { }
   

        public override IShaminProduct CreateProductVeg(string baseDough, string sauce, double price)
        {
            return VegetarianPizzaBuilder.Init(baseDough, sauce, price);
        }

        public override IShaminProduct CreateProductNoVeg(string baseDough, string sauce, double price)
        {
            return HawaianPizzaBuilder.Init(baseDough, sauce, price);
        }
    }
     
     
}