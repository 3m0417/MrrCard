using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq; 

namespace MrrCard.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
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
    }
}
