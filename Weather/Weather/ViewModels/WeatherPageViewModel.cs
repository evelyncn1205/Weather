using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Weather.ItemViewModel;
using Weather.Models;
using Weather.Service;
using Weather.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Weather.ViewModels
{
    public class WeatherPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IApiService _apiService;
        private bool _isRunning;
        
        public WeatherPageViewModel(INavigationService navigationService,
            IApiService apiService) : base(navigationService)
        {
            _navigationService = navigationService;
            _apiService = apiService;
            Title ="Weather";
            LoadWeatherAsync();
        }

        public bool IsRunning
        {
            get => _isRunning;
            set => SetProperty(ref _isRunning, value);
        }

        private void LoadWeatherAsync()
        {
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await App.Current.MainPage.DisplayAlert(
                        "Error",
                        "Check internet connection", "Accept");
                });
                return;
            }
            IsRunning = true;
            string url = App.Current.Resources["ApiBaseUrl"].ToString();
            string cidade = string.Empty;

            


            IsRunning = false;
        }

       

    }
}
