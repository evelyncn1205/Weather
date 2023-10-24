using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Syncfusion.SfBusyIndicator.XForms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Weather.ViewModels
{
    public class SobrePageViewModel : ViewModelBase
    {
        public SobrePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title="Sobre";
        }
    }
}
