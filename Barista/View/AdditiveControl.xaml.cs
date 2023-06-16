using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Barista.ViewModel;
namespace Barista.View
{
    /// <summary>
    /// Interaction logic for AdditiveControl.xaml
    /// </summary>
    public partial class AdditiveControl : UserControl
    {
        public AdditiveControl()
        {
            this.DataContext = new AdditiveViewModel(); 
            InitializeComponent();
        }

      
    }
}
