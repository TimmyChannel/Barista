using Barista.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Barista.ViewModel
{
    public class BaseDrinkViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
    => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private CoffeeMachineModel _model;
        public List<string> Ingredients { get; set; }
        public BaseDrinkViewModel()
        {
            _model = CoffeeMachineModel.Model;
            _model.PropertyChanged += _model_PropertyChanged;
            Ingredients = new List<string>
            {
                DrinkIngredient.Coffee.ToString(),
                DrinkIngredient.Cocoa.ToString(),
                DrinkIngredient.Chocolate.ToString()
            };
        }
        public string SelectedItem
        {
            set
            {
                Enum.TryParse(value, out DrinkIngredient ingredient);
                _model.AddIngridient(ingredient);
                OnPropertyChanged();
            }
        }
        
        private void _model_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged("Base");
        }
    }
}
