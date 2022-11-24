using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherAppLJH
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPortrait();
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
