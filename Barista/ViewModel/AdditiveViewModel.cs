using Barista.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Barista.ViewModel
{
    public class AdditiveViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "", bool allProperties = false) =>
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(allProperties ? null : propertyName));

        private void OnAllPropertiesChanged() =>
           OnPropertyChanged(allProperties: true);

        private CoffeeMachineModel _model;
        public AdditiveViewModel()
        {
            _model = CoffeeMachineModel.Model;
            _model.PropertyChanged += _model_PropertyChanged;
        }
        public bool AddMilk 
        {
            set
            {
                if (value) _model.AddIngridient(DrinkIngredient.Milk);
                else _model.RemoveAdditive(DrinkIngredient.Milk);
            }
            get
            {
                return _model.CurrentDrink.Ingredients.Contains(DrinkIngredient.Milk);
            }
        } 
        public bool AddSugar 
        {
            set
            {
                if (value) _model.AddIngridient(DrinkIngredient.Sugar);
                else _model.RemoveAdditive(DrinkIngredient.Sugar);
            }
            get
            {
                return _model.CurrentDrink.Ingredients.Contains(DrinkIngredient.Sugar);
            }
        } 
        public bool AddCream 
        {
            set
            {
                if (value) _model.AddIngridient(DrinkIngredient.Cream);
                else _model.RemoveAdditive(DrinkIngredient.Cream);
            }
            get
            {
                return _model.CurrentDrink.Ingredients.Contains(DrinkIngredient.Cream);
            }
        }
        private void _model_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            OnAllPropertiesChanged();
        }
    }
}
