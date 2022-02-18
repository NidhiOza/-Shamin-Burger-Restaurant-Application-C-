using System;
namespace Shamim
{
    public class HealthyHamburguer : BasicHamburguer
    {
        private Addition add5;
        private Addition add6;

        public HealthyHamburguer(string bread, string meat, double price) : base(bread, meat, price) {}

        public void SetAddition5(Addition add)
        {
            add5 = add;
        }

        public void SetAddition6(Addition add)
        {
            add6 = add;
        }

        private double GetTotal()
        {
            return basePrice + (add1 != null ? add1.Price : 0) + (add2 != null ? add2.Price : 0) + (add3 != null ? add3.Price : 0) + (add4 != null ? add4.Price : 0) + (add5 != null ? add5.Price : 0) + (add6 != null ? add6.Price : 0);
        }

        public override string ToString()
        {
            String message = $"Basic hamburger on a {bread} with {meat}, price is {basePrice}\n";
            message += add1 != null ? $"Added {add1.Name} for an extra {add1.Price}\n" : "";
            message += add2 != null ? $"Added {add2.Name} for an extra {add2.Price}\n" : "";
            message += add3 != null ? $"Added {add3.Name} for an extra {add3.Price}\n" : "";
            message += add4 != null ? $"Added {add4.Name} for an extra {add4.Price}\n" : "";
            message += add5 != null ? $"Added {add5.Name} for an extra {add5.Price}\n" : "";
            message += add6 != null ? $"Added {add6.Name} for an extra {add6.Price}\n" : "";
            message += $"Total Burger price is {GetTotal()}\n";
            return message;
        }
    }
}
