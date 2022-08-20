namespace DSD601PizzaParlour.Model
{
    public class Vegetarian : Pizza
    {
        public Vegetarian()
        {
            PizzaName = "Vegetarian";
            Description = "This is our least recommended Pizza.";
            Image = "vegetarianpizza.jpg";
            PizzaChef = "Fernando Tatis Jr.";
            ListOfIngredients.Add("Capsicum");
            ListOfIngredients.Add("Jalapenos");
            ListOfIngredients.Add("Olives");
            ListOfIngredients.Add("Tomato");
            ListOfSizesAndPrices.Add("Small - $5.50");
            ListOfSizesAndPrices.Add("Medium - $7.50");
            ListOfSizesAndPrices.Add("Large - $9.00");
            isGlutenFree = true;
            isVegeterian = true;    
        }
    }
}
