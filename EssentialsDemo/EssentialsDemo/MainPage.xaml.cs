using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace EssentialsDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ReadDescription(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(description.Text, default);
        }

        private void CallContactNumber(object sender, EventArgs e)
        {
            PhoneDialer.Open(contactNumber.Text);
        }

        private async void SeeDirections(object sender, EventArgs e)
        {
            var location = await Geocoding.GetLocationsAsync(storeAddress.Text);

            await Map.OpenAsync(location.FirstOrDefault(), new MapLaunchOptions { NavigationMode = NavigationMode.Driving });
        }
    }
}
