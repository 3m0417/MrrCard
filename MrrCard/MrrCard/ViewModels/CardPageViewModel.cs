using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MrrCard.ViewModels
{
    public class CardPageViewModel : BindableBase
    {
        private INavigationService _navigationService;

        public CardPageViewModel()
        {

        }

        public CardPageViewModel(INavigationService navigationService, IEventAggregator ea, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            
        }
    }
}
