using Barista.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Barista.ViewModel
{
    public class CupDisplayerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "", bool allProperties = false) =>
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(allProperties ? null : propertyName));

        private void OnAllPropertiesChanged() =>
           OnPropertyChanged(allProperties: true);

        private CoffeeMachineModel _model;
        private DrinkIngredient _currentBase;
        public CupDisplayerViewModel()
        {
            _model = CoffeeMachineModel.Model;
            _model.PropertyChanged += _model_PropertyChanged;
        }

        public string TotalCost
        {
            get
            {
                return $"Итог: {_model.CurrentDrink.GetCost()}р.";
            }
        }
        public string SugarCost
        {
            get
            {
                return $"- Сахар: {DrinkIngredientCost.Sugar}р.";
            }
        }
        public string Level2Text
        {
            get
            {
                return $"- Сливки: {DrinkIngredientCost.Cream}р.";
            }
        }
        public string Level1Text
        {
            get
            {
                if (_model.CurrentDrink.Ingredients.Contains(DrinkIngredient.Milk))
                    return $"- Молоко: {DrinkIngredientCost.Milk}р.";
                return $"- Сливки: {DrinkIngredientCost.Cream}р.";
            }
        }
        public string Level0Text
        {
            get
            {
                switch (_currentBase)
                {
                    case DrinkIngredient.Coffee:
                        return $"- Кофе: {DrinkIngredientCost.Coffee}р.";
                    case DrinkIngredient.Cocoa:
                        return $"- Какао: {DrinkIngredientCost.Cocoa}р.";
                    case DrinkIngredient.Chocolate:
                        return $"- Шоколад: {DrinkIngredientCost.Chocolate}р.";
                    default:
                        return "- Напиток: р.";
                }
            }
        }

        public bool Level2IsVisible
        {
            get
            {
                return _model.CurrentDrink.Ingredients.Contains(DrinkIngredient.Milk)
                    & _model.CurrentDrink.Ingredients.Contains(DrinkIngredient.Cream);
            }
        }
        public bool Level1IsVisible
        {
            get
            {
                return _model.CurrentDrink.Ingredients.Contains(DrinkIngredient.Milk)
                    || _model.CurrentDrink.Ingredients.Contains(DrinkIngredient.Cream);
            }
        }
        public bool SugarIsVisible
        {
            get
            {
                return _model.CurrentDrink.Ingredients.Contains(DrinkIngredient.Sugar);
            }
        }
        public string PathToBase
        {
            get
            {
                switch (_currentBase)
                {
                    case DrinkIngredient.Coffee:
                        return "pack://application:,,,/Resources/Waves/coffee.gif";
                    case DrinkIngredient.Cocoa:
                        return "pack://application:,,,/Resources/Waves/cocoa.gif";
                    case DrinkIngredient.Chocolate:
                        return "pack://application:,,,/Resources/Waves/chocolate.gif";
                    default:
                        return "pack://application:,,,/Resources/Waves/coffee.gif";
                }
            }
        }
        private void _model_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            _currentBase = _model.CurrentDrink.GetBase();
            OnAllPropertiesChanged();
        }
    }
}
