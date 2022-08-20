using DSD601PizzaParlour.Operations;
using System.ComponentModel.DataAnnotations;

namespace DSD601PizzaParlour.Model
{
    public class Pizza
    {
       
        public string Image { get; set; }
        public string PizzaChef { get; set; }

        public string Description { get; set; }

        public List<string> ListOfIngredients { get; set; }

        public List<string> ListOfSizesAndPrices { get; set; }

        public string PizzaName { get; set; }
        
        public bool isGlutenFree { get; set; }

        public bool isVegeterian { get; set; }

        public Pizza()
        {
            ListOfIngredients = new List<string>();
            ListOfSizesAndPrices = new List<string>();
        }

        [Display(Name = "Select Pizza")]
        public EnumOperationType PizzaType { get; set; }

        public bool IsFirstLoad { get; set; } = false; 
        public string? ErrorMessage { get; set; }
    }
}
