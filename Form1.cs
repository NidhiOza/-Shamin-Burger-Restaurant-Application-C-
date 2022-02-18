using Shamim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShaminPart4
{
    public partial class frmShamin : Form
    {
       Dictionary<string,double> intemsPrice = new Dictionary<string, double>() { { "Tomato",1.25},{ "Lettuce",1.5},{ "Bacon",2.75},{ "Pickle",1.67},{ "Pepper",2.00},{ "Egg",2.25} };



        List<string> additions = new List<string>();
        String burgerType = "";
        AbstractFactory f1 = AbstractFactory.getFactory(Product.Hamburger);

       



        public frmShamin()
        {
            InitializeComponent();
           

        }

       
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
           
            switch (burgerType) {
                case "Basic Burguer":
                    txtTest.Text = basicHamburgerOrder().ToString();
                    
                    break;
                case "Healty Burguer":
                    txtTest.Text = HealtyHamburgerOrder().ToString();
                    break;
                case "Deluxe Burguer":
                    DeluxeHamburguer myHamburguer4 = ((IDeluxeHamburguerBuilder)((HamburguerFactory)f1).CreateProductNoVeg("White roll", "Sausage & Bacon", 14.54)).build();
                    txtTest.Text = myHamburguer4.ToString();
                    break;
            }

            
            btnBasicB.Enabled = btnDeluxeB.Enabled =btnHealty.Enabled= true;
            Bacon.Enabled = Pickle.Enabled = Tomato.Enabled = Lettuce.Enabled = Egg.Enabled = Pepper.Enabled = true;

            additions.Clear();
        }

       
        private void btnBurger_Click(object sender, EventArgs e)
        {
            Button burgertype = (Button)sender;

            burgerType = burgertype.Text;
            txtTest.Text = burgerType;

            switch (burgerType) {
                case "Basic Burguer":
                    Pickle.Enabled = Pepper.Enabled = btnHealty.Enabled = btnDeluxeB.Enabled = false;
                    break;
                case "Healty Burguer":
                    Egg.Enabled = Bacon.Enabled = Lettuce.Enabled = Tomato.Enabled = btnBasicB.Enabled = btnDeluxeB.Enabled = false;
                    Pepper.Enabled = Pickle.Enabled = true;
                    break;
                case "Deluxe Burguer":
                    Egg.Enabled = Bacon.Enabled = Lettuce.Enabled = Tomato.Enabled= Pickle.Enabled = Pepper.Enabled = btnHealty.Enabled = btnBasicB.Enabled = false;
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btnClicked = (Button)sender;
           
            btnClicked.Enabled = false;
            additions.Add(btnClicked.Name);
         
            
        }
        BasicHamburguer basicHamburgerOrder()
        {
            BasicHamburguer myHamburguer=null;
            int i = additions.Count;
            switch (i)
            {
                case 0:
                    myHamburguer = ((IBasicHamburguerBuilder)((HamburguerFactory)f1).CreateProductBasic("White roll", "Sausage", 3.56)).build();
                    return myHamburguer;
                    
                case 1:
                    myHamburguer = ((IBasicHamburguerBuilder)((HamburguerFactory)f1).CreateProductBasic("White roll", "Sausage", 3.56))
                .setAdd1(new Addition(additions[0], intemsPrice[additions[0]])).build();
                    return myHamburguer;
                case 2:

                    myHamburguer = ((IBasicHamburguerBuilder)((HamburguerFactory)f1).CreateProductBasic("White roll", "Sausage", 3.56))
                .setAdd1(new Addition(additions[0], intemsPrice[additions[0]]))
                .setAdd2(new Addition(additions[1], intemsPrice[additions[1]]))
                .build();
                    return myHamburguer;
                case 3:
                    myHamburguer = ((IBasicHamburguerBuilder)((HamburguerFactory)f1).CreateProductBasic("White roll", "Sausage", 3.56))
                     .setAdd1(new Addition(additions[0], intemsPrice[additions[0]]))
                     .setAdd2(new Addition(additions[1], intemsPrice[additions[1]]))
                     .setAdd3(new Addition(additions[2], intemsPrice[additions[2]]))
                     .build();
                    return myHamburguer;
                case 4:
                    myHamburguer = ((IBasicHamburguerBuilder)((HamburguerFactory)f1).CreateProductBasic("White roll", "Sausage", 3.56))
                    .setAdd1(new Addition(additions[0], intemsPrice[additions[0]]))
                    .setAdd2(new Addition(additions[1], intemsPrice[additions[1]]))
                    .setAdd3(new Addition(additions[2], intemsPrice[additions[2]]))
                    .setAdd4(new Addition(additions[3], intemsPrice[additions[3]]))
                    .build();
                    return myHamburguer;

            }
            return myHamburguer;
        }

        BasicHamburguer HealtyHamburgerOrder()
        {
            HealthyHamburguer myHealtyHamburguer = null;
            int i = additions.Count;
           
            switch (i)
            {
                case 0:
                    myHealtyHamburguer = ((IHealthyHamburguerBuilder)((HamburguerFactory)f1).CreateProductVeg(null, "Bacon", 5.67)).build();
                    return myHealtyHamburguer;

                case 1:
                    myHealtyHamburguer = ((IHealthyHamburguerBuilder)((HamburguerFactory)f1).CreateProductVeg(null, "Bacon", 5.67))
                .setAdd1(new Addition(additions[0], intemsPrice[additions[0]])).build();
                  return  myHealtyHamburguer;
                case 2:

                    myHealtyHamburguer = ((IHealthyHamburguerBuilder)((HamburguerFactory)f1).CreateProductVeg(null, "Bacon", 5.67))
                .setAdd1(new Addition(additions[0], intemsPrice[additions[0]]))
                .setAdd2(new Addition(additions[1], intemsPrice[additions[1]]))
                .build();
                    return myHealtyHamburguer;
                
            }
            return myHealtyHamburguer;
        }
    }
}
