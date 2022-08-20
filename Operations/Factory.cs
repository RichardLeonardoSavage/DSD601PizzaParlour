using DSD601PizzaParlour.Model;

namespace DSD601PizzaParlour.Operations
{
    public class Factory
    {
        public static Pizza GetAPizza(int? id)
        {
            switch(id)
                {
                case 0:
                    return new Pizza();

                case 1:
                    return new Hawaiian();

                    case 2:
                    return new Meatlovers();

                    case 3:
                    return new Vegetarian();

                default:
                    return new Pizza();

            }
        }
    }
}
