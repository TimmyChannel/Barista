namespace Barista.Model
{
    public  class AdditiveSugar : Additive
    {
        public AdditiveSugar(Drink drink) : base(drink, DrinkIngredient.Sugar, DrinkIngredientCost.Sugar) { }
    }
}
