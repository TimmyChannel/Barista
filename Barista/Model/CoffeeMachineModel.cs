using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Barista.Model
{
    /// <summary>
    /// Класс модели
    /// </summary>
    public class CoffeeMachineModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
    => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        static CoffeeMachineModel _model;
        public static CoffeeMachineModel Model => _model ??= new CoffeeMachineModel();

        private Drink _currentDrink;
        public Drink CurrentDrink => _currentDrink??=new BaseCoffee();

        public void AddIngridient(DrinkIngredient add)
        {
            switch (add)
            {
                case DrinkIngredient.Sugar:
                    _currentDrink = new AdditiveSugar(_currentDrink);
                    break;
                case DrinkIngredient.Milk:
                    _currentDrink = new AdditiveMilk(_currentDrink);
                    break;
                case DrinkIngredient.Cream:
                    _currentDrink = new AdditiveCream(_currentDrink);
                    break;
                case DrinkIngredient.Coffee:
                    _currentDrink = new BaseCoffee();
                    break;
                case DrinkIngredient.Cocoa:
                    _currentDrink = new BaseCocoa();
                    break;
                case DrinkIngredient.Chocolate:
                    _currentDrink = new BaseChocolate();
                    break;
                default:
                    break;
            }
            DrinkChanged();
        }
        public void RemoveAdditive(DrinkIngredient add)
        {
            var temIngredients = new ObservableCollection<DrinkIngredient>(_currentDrink.Ingredients);

            temIngredients.Remove(add);
            foreach (var ingredient in temIngredients)
            {
                AddIngridient(ingredient);
            }
            DrinkChanged();
        }
        public void DrinkChanged() => OnPropertyChanged();
    }
}
