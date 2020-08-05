using Falapp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Falapp
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            MainPage = new NavigationPage(new MainPage());

            //MainPage = new SelecaoDeJogo();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

       
        
    }
}
