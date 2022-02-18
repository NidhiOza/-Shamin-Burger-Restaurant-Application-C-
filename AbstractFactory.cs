namespace Shamim
{
    public abstract class AbstractFactory
    {
        private static HamburguerFactory hf = new HamburguerFactory();

        private static PizzaFactory pf = new PizzaFactory();


        public static AbstractFactory getFactory(Product p)
        {
            AbstractFactory factory = null;

            switch (p)
            {

                case Product.Hamburger:
                    factory = hf;
                    break;

                case Product.Pizza:
                    factory = pf;
                    break;
            }

            return factory;



        }


        public abstract IShaminProduct CreateProductVeg(string bread, string meat, double price);
        public abstract IShaminProduct CreateProductNoVeg(string bread, string meat, double price);
    }
}
