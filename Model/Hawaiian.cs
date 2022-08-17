using System.ComponentModel.DataAnnotations;

namespace DSD601PizzaParlour.Model
{
    public class Hawaiian : Pizza
    {
        [Display (Name = "Hawaiian")]
        public string PizzaName { get; set; }
    }
}
