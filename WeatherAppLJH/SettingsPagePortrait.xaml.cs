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
            string UnitOfMeasurementWind = Preferences.Get("UnitOfMeasurementWind", "");
            {
                if (UnitOfMeasurementWind == "meters/sec")
                {
                    WindUnitOfMeasurement.IsToggled = false;
                }
                if (UnitOfMeasurementWind == "miles/hour")
                {
                    WindUnitOfMeasurement.IsToggled = true;
                }
            }
            string TimeFormat = Preferences.Get("12Hour24HourTime", "");
            {
                if (TimeFormat == "hh:mm:ss")
                {
                    TwelveHourTime.IsToggled = false;
                }
                if (TimeFormat == "HH:mm:ss")
                {
                    TwelveHourTime.IsToggled = true;
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
            string Degrees = Preferences.Get("UnitOfMeasurement", "");
            {
                if (Degrees == "Metric")
                {
                    Preferences.Set("TempDegrees", "°C");
                }
                if (Degrees == "Imperial")
                {
                    Preferences.Set("TempDegrees", "°F");
                }
            }
        }

        private void WindUnitOfMeasurement_Toggled(object sender, ToggledEventArgs e)
        {
            Preferences.Set("UnitOfMeasurementWind", (WindUnitOfMeasurement.IsToggled) ? "miles/hour" : "meters/sec");
        }

        private void TwelveHourTime_Toggled(object sender, ToggledEventArgs e)
        {
            Preferences.Set("12Hour24HourTime", (TwelveHourTime.IsToggled) ? "HH:mm:ss" : "hh:mm:ss");
        }
    }
}