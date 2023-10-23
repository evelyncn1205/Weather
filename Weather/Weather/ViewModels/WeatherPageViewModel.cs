using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Weather.ItemViewModel;
using Weather.Models;
using Weather.Views;
using Xamarin.Forms;

namespace Weather.ViewModels
{
    public class WeatherPageViewModel : ViewModelBase
    {
        public WeatherPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            
           
        }
    }
}
