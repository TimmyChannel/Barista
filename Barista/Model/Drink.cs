using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Barista.Model
{
    public abstract class Drink : IEnumerable<DrinkIngredient>
    {
        protected ObservableCollection<DrinkIngredient> _ingredients;
        public ObservableCollection<DrinkIngredient> Ingredients => _ingredients;
        protected double _cost;
        
        protected Drink() { }

        public Drink(DrinkIngredient ingredient, double cost)
        {
            _ingredients = new ObservableCollection<DrinkIngredient> { ingredient };
            _cost = cost;
        }  

        public virtual double GetCost()
        {
            return _cost;
        }
        public DrinkIngredient GetBase()
        {
            return _ingredients[0];
        }
        public IEnumerator<DrinkIngredient> GetEnumerator()
        {
            return ((IEnumerable<DrinkIngredient>)_ingredients).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_ingredients).GetEnumerator();
        }
    }
}
