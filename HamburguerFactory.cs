using System;
namespace Shamim
{
    public class HamburguerFactory : AbstractFactory
    {
        public HamburguerFactory()
        {
        }

        public override IShaminProduct CreateProductVeg(string bread, string meat, double price)
        {
            return HealthyHamburguerBuilder.Init(meat, price);
        }

        public override IShaminProduct CreateProductNoVeg(string bread, string meat, double price)
        {
            return DeluxeHamburguerBuilder.Init(bread, meat, price);
        }

        public IShaminProduct CreateProductBasic(string bread, string meat, double price)
        {
            return BasicHamburguerBuilder.Init(bread, meat, price);
        }
    }
}