namespace Barista.Model
{
    public class AdditiveMilk : Additive
    {
        public AdditiveMilk(Drink drink) : base(drink, DrinkIngredient.Milk, DrinkIngredientCost.Milk) { }
    }
}
