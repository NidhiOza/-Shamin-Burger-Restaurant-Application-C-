using System;
using System.Collections.Generic;
using System.Text;

namespace Shamim
{ 
    public interface IVegetarianPizzaBuilder : IShaminProduct
    {
        IAddition1VP setAdd1(Addition add1);
        BasicPizza build();
    }
    public interface IAddition1VP
    {
        IAddition2VP setAdd2(Addition add2);
        BasicPizza build();
    }

    public interface IAddition2VP
    {
        IAddition3VP setAdd3(Addition add3);
        BasicPizza build();
    }

    public interface IAddition3VP
    {
        IAddition4VP setAdd4(Addition add4);
        BasicPizza build();
    }

    public interface IAddition4VP
    {
        BasicPizza build();
    }


    public class VegetarianPizzaBuilder : IVegetarianPizzaBuilder, IAddition1VP, IAddition2VP, IAddition3VP, IAddition4VP
    {
        private BasicPizza vp;

        public VegetarianPizzaBuilder(string baseDough, string sauce, double price)
        {
            vp = new BasicPizza(baseDough, sauce, price);
            
        }

        public static IVegetarianPizzaBuilder Init(string baseDough, string sauce, double price)
        {
            return new VegetarianPizzaBuilder(baseDough, sauce, price);
        }
        public IAddition1VP setAdd1(Addition add1)
        {
            vp.SetAddition1(add1);
            return this;
        }

        public IAddition2VP setAdd2(Addition add2)
        {
            vp.SetAddition2(add2);
            return this;
        }

        public IAddition3VP setAdd3(Addition add3)
        {
            vp.SetAddition3(add3);
            return this;
        }

        public IAddition4VP setAdd4(Addition add4)
        {
            vp.SetAddition4(add4);
            return this;
        }

        public BasicPizza build()
        {
            return vp;
        }
       
    }

    
}
