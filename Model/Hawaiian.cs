using System.ComponentModel.DataAnnotations;

namespace DSD601PizzaParlour.Model
{
    public class Hawaiian : Pizza
    {
        public Hawaiian()
        {
            
            PizzaName = "Hawaiian";
            PizzaChef = "Jaja Phons";
            Description = "The Flyin' Hawaiian that will seriously mess you up.";
            isGlutenFree = true;
            isVegeterian = false;
            Image = "hawaiianpizza.jpg";
            ListOfIngredients.Add("Cheese");
            ListOfIngredients.Add("Pineapple");
            ListOfIngredients.Add("Ham");
            ListOfSizesAndPrices.Add("Small - $6.50");
            ListOfSizesAndPrices.Add("Medium - $9.50");
            ListOfSizesAndPrices.Add("Large - $12.00");

        }
       

    }
}
