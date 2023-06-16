using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace Barista.Model
{
    public class Additive : Drink
    {
        private Drink _base;

        public Additive(Drink drink, DrinkIngredient ingredient, double cost)
        {
            _base = drink;
            _ingredients = new ObservableCollection<DrinkIngredient>(_base.Ingredients);
            _ingredients.Add(ingredient);
            _cost = cost;
        }

        public override double GetCost()
        {
            return _base.GetCost() + _cost;
        }

    }
}
