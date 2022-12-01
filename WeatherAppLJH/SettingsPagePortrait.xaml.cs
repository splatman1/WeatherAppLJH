using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace WeatherAppLJH
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPagePortrait : ContentPage
    {
        public SettingsPagePortrait()
        {
            InitializeComponent();
            //Preferences.Set("UnitOfMeasurement", (ImperialOn.IsToggled)? "Imperial":"Metric");
            string UnitOfMeasurement = Preferences.Get("UnitOfMeasurement", "");
            {
                if (UnitOfMeasurement == "Metric")
                {
                    ImperialOn.IsToggled = false;
                }
                if (UnitOfMeasurement == "Imperial"){
                    ImperialOn.IsToggled = true;
                }
            }

        }

        private async void HomeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void ImperialOn_Toggled(object sender, ToggledEventArgs e)
        {
            Preferences.Set("UnitOfMeasurement", (ImperialOn.IsToggled)? "Imperial":"Metric");
        }

        private void WindUnitOfMeasurement_Toggled(object sender, ToggledEventArgs e)
        {
            Preferences.Set("UnitOfMeasurementWind", (WindUnitOfMeasurement.IsToggled) ? "meters/sec" : "miles/hour");
        }
    }
}