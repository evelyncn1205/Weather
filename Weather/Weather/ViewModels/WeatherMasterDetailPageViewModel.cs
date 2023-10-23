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
                    Icon="",
                    PageName = $"{nameof(WeatherPage)}",
                    IsLoginRequired = true,
                    Title="Weather"
                },

            new Menu
            {
                Icon="ic_exit_to_app",
                PageName= $"{nameof(LoginPage)}",
                Title="Login"
            },
            //new Menu
            //{
            //    Icon="",
            //    PageName= $"{nameof(AboutPage)}",
            //    Title="About"
            //},
            new Menu
            {
                Icon="ic_exit_to_app",
                PageName= $"{nameof(LoginPage)}",
                Title="Logout"
            }};


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
