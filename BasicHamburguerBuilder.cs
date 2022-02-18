namespace Shamim
{
    public interface IBasicHamburguerBuilder: IShaminProduct
    {
        IAddition1BH setAdd1(Addition add1);
        BasicHamburguer build();
    }

    public interface IAddition1BH
    {
        IAddition2BH setAdd2(Addition add2);
        BasicHamburguer build();
    }

    public interface IAddition2BH
    {
        IAddition3BH setAdd3(Addition add3);
        BasicHamburguer build();
    }

    public interface IAddition3BH
    {
        IAddition4BH setAdd4(Addition add4);
        BasicHamburguer build();
    }

    public interface IAddition4BH
    {
        BasicHamburguer build();
    }

    public class BasicHamburguerBuilder : IBasicHamburguerBuilder, IAddition1BH, IAddition2BH, IAddition3BH, IAddition4BH
    {
        private BasicHamburguer bh;

        public BasicHamburguerBuilder(string bread, string meat, double price)
        {
            bh = new BasicHamburguer(bread, meat, price);
        }

        public static IBasicHamburguerBuilder Init(string bread, string meat, double price)
        {
            return new BasicHamburguerBuilder(bread, meat, price);
        }

        public IAddition1BH setAdd1(Addition add1)
        {
            bh.SetAddition1(add1);
            return this;
        }

        public IAddition2BH setAdd2(Addition add2)
        {
            bh.SetAddition2(add2);
            return this;
        }

        public IAddition3BH setAdd3(Addition add3)
        {
            bh.SetAddition3(add3);
            return this;
        }

        public IAddition4BH setAdd4(Addition add4)
        {
            bh.SetAddition4(add4);
            return this;
        }

        public BasicHamburguer build()
        {
            return bh;
        }
    }
}