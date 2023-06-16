namespace Barista.Model
{
    public class AdditiveCream : Additive
    {
        public AdditiveCream(Drink drink) : base(drink, DrinkIngredient.Cream, DrinkIngredientCost.Cream) { }
    }
}
