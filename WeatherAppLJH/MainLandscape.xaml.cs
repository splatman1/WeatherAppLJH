using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherAppLJH
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainLandscape : ContentView
    {
        public MainLandscape(string importantData)
        {
            InitializeComponent();
        }
    }
}