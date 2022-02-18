using System;
namespace Shamim
{
    public class Addition
    {
        public string Name { set; get; }
        public double Price { set; get; }

        public Addition(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
