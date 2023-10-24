using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Weather.ItemViewModel;
using Weather.Models;
using Weather.Views;

namespace Weather.ViewModels
{
    public class WeatherMasterDetailPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public WeatherMasterDetailPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
            _navigationService = navigationService;
            LoadMenus();
        }
        public ObservableCollection<MenuItemViewModel> Menus { get; set; }

        private void LoadMenus()
        {
            List<Menu> menus = new List<Menu>
            {
                new Menu
                {
                   Icon = "ic_launcher",
                   PageName = $"{nameof(WeatherPage)}",
                   Title = "Weather"
                },
            //new Menu
            //{
            //    Icon = "ic_shopping_cart",
            //    PageName = $"{nameof(ShowCarPage)}",
            //    Title = Languages.ShowShoppingCar
            //},
            new Menu
            {
                Icon = "ic_person",
                PageName = $"{nameof(SobrePage)}",
                Title = "Sobre",
                IsLoginRequired = true
            },
            new Menu
            {
                Icon = "ic_exit_to_app",
                PageName = $"{nameof(LoginPage)}",
                Title = "Login",
                IsLoginRequired = true
            },
            new Menu
            {
                Icon = "ic_exit_to_app",
                PageName = $"{nameof(LoginPage)}",
                Title = "Logout"
            }
            };

            Menus = new ObservableCollection<MenuItemViewModel>(
                menus.Select(m => new MenuItemViewModel(_navigationService)
                {
                    Icon = m.Icon,
                    PageName = m.PageName,
                    Title = m.Title,
                    IsLoginRequired = m.IsLoginRequired
                }).ToList());
        }
    }
}
