namespace Shamim
{
    public interface IDeluxeHamburguerBuilder : IShaminProduct
    {
        DeluxeHamburguer build();
    }

    public class DeluxeHamburguerBuilder : IDeluxeHamburguerBuilder
    {
        private DeluxeHamburguer dh;

        public DeluxeHamburguerBuilder(string bread, string meat, double price)
        {
            dh = new DeluxeHamburguer(bread, meat, price);
            dh.SetAddition1(new Addition("Chips", 2.75));
            dh.SetAddition2(new Addition("Drink", 1.81));
        }

        public static IDeluxeHamburguerBuilder Init(string bread, string meat, double price)
        {
            return new DeluxeHamburguerBuilder(bread, meat, price);
        }

        public DeluxeHamburguer build()
        {
            return dh;
        }
    }
}