using System;
using System.Collections.Generic;
using System.Text;

namespace Shamim
{
   
    public interface IHawaianPizzaBuilder : IShaminProduct
    {
        IAddition1HP setAdd1(Addition add1);
        BasicPizza build();
    }
    public interface IAddition1HP
    {
        IAddition2HP setAdd2(Addition add2);
        BasicPizza build();
    }
    public interface IAddition2HP
    {
        IAddition3HP setAdd3(Addition add3);
        BasicPizza build();
    }

    public interface IAddition3HP
    {
        
        BasicPizza build();
    }

    public class HawaianPizzaBuilder : IHawaianPizzaBuilder, IAddition1HP, IAddition2HP, IAddition3HP
    {
        private BasicPizza hp;

        public HawaianPizzaBuilder(string baseDough, string sauce, double price)
        {
            hp = new BasicPizza(baseDough, sauce, price);
           
        }

        public static IHawaianPizzaBuilder Init(string baseDough, string sauce, double price)
        {
            return new HawaianPizzaBuilder(baseDough, sauce, price);
        }
        public IAddition1HP setAdd1(Addition add1)
        {
            hp.SetAddition1(add1);
            return this;
        }

        public IAddition2HP setAdd2(Addition add2)
        {
            hp.SetAddition2(add2);
            return this;
        }

        public IAddition3HP setAdd3(Addition add3)
        {
            hp.SetAddition3(add3);
            return this;
        }


        public BasicPizza build()
        {
            return hp;
        }
    }
     
     
     
}
