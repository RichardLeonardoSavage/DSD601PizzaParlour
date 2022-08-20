namespace DSD601PizzaParlour.Model
{
    public class Meatlovers : Pizza
    {
        public Meatlovers()
        {
            PizzaName = "MeatLovers";
            Image = "meatlovers.jpg";
            Description = "This pizza will seriously mess you up.";
            isGlutenFree = false;
            isVegeterian = false;
            PizzaChef = "Yoenis Cespedes";
            ListOfIngredients.Add("Bacon");
            ListOfIngredients.Add("Beef");
            ListOfIngredients.Add("Cheese");
            ListOfIngredients.Add("Ham");
            ListOfIngredients.Add("Pepperoni");
            ListOfSizesAndPrices.Add("Small - $8.00");
            ListOfSizesAndPrices.Add("Medium - $11.50");
            ListOfSizesAndPrices.Add("Large - $14.00");

        }
    }
}
