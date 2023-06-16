namespace Barista.Model
{
    public  class BaseCoffee : Drink
    {
        public BaseCoffee() : base(DrinkIngredient.Coffee, DrinkIngredientCost.Coffee) { }
    }
}
