namespace Shamim
{
    public interface IHealthyHamburguerBuilder : IShaminProduct
    {
        IAddition1HH setAdd1(Addition add1);
        HealthyHamburguer build();
    }

    public interface IAddition1HH
    {
        IAddition2HH setAdd2(Addition add2);
        HealthyHamburguer build();
    }

    public interface IAddition2HH
    {
        IAddition3HH setAdd3(Addition add3);
        HealthyHamburguer build();
    }

    public interface IAddition3HH
    {
        IAddition4HH setAdd4(Addition add4);
        HealthyHamburguer build();
    }

    public interface IAddition4HH
    {
        IAddition5HH setAdd5(Addition add4);
        HealthyHamburguer build();
    }

    public interface IAddition5HH
    {
        IAddition6HH setAdd6(Addition add4);
        HealthyHamburguer build();
    }

    public interface IAddition6HH
    {
        HealthyHamburguer build();
    }

    public class HealthyHamburguerBuilder : IHealthyHamburguerBuilder, IAddition1HH, IAddition2HH, IAddition3HH, IAddition4HH, IAddition5HH, IAddition6HH
    {
        private HealthyHamburguer hh;

        public HealthyHamburguerBuilder(string meat, double price)
        {
            hh = new HealthyHamburguer("Brown rye roll", meat, price);
        }

        public static IHealthyHamburguerBuilder Init(string meat, double price)
        {
            return new HealthyHamburguerBuilder(meat, price);
        }

        public IAddition1HH setAdd1(Addition add)
        {
            hh.SetAddition1(add);
            return this;
        }

        public IAddition2HH setAdd2(Addition add)
        {
            hh.SetAddition2(add);
            return this;
        }

        public IAddition3HH setAdd3(Addition add)
        {
            hh.SetAddition3(add);
            return this;
        }

        public IAddition4HH setAdd4(Addition add)
        {
            hh.SetAddition4(add);
            return this;
        }

        public IAddition5HH setAdd5(Addition add)
        {
            hh.SetAddition5(add);
            return this;
        }

        public IAddition6HH setAdd6(Addition add)
        {
            hh.SetAddition6(add);
            return this;
        }

        public HealthyHamburguer build()
        {
            return hh;
        }
    }
}