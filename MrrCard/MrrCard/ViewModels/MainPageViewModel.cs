using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System;
using Xamarin.Forms;
using System.Diagnostics;

namespace MrrCard.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private INavigationService _navigationService;

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand GotoOurSiteCommand { get; private set; }
        public DelegateCommand GotoFacebookCommand { get; private set; }
        public DelegateCommand GotoLinkedinCommand { get; private set; }
        public DelegateCommand GotoWhatsAppCommand { get; private set; }
        public DelegateCommand GotoCallUsCommand { get; private set; }
        public DelegateCommand GotoMRRCardCommand { get; private set; }

        public MainPageViewModel()
        {
            
        }

        public MainPageViewModel(INavigationService navigationService, IEventAggregator ea, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;

            Title = "M.R.R. Coumputers and Systems";

            GotoFacebookCommand = new DelegateCommand(() =>
            {
                Uri uri = new Uri("https://www.facebook.com/mrrcomputers");
                Device.OpenUri(uri);
            });

            GotoLinkedinCommand = new DelegateCommand(() =>
            {
                Uri uri = new Uri("https://www.linkedin.com/in/smallbusinessinventory/");
                Device.OpenUri(uri);
            });

            GotoWhatsAppCommand = new DelegateCommand(() =>
            {
                
            });

            GotoCallUsCommand = new DelegateCommand(() =>
            {
                Uri uri = new Uri("tel:0504427137");
                Device.OpenUri(uri);
            });

            GotoMRRCardCommand = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync("CardPage");
            });

            
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }

        private void OnPressWhatsApp()
        {
            //Xamarin.Forms.DependencyService.Get<IWhatsAppEvents>.OnPressWhatsApp();
        }
    }

    public interface IWhatsAppEvents
    {
        void OnPressWhatsApp();
    }
}
