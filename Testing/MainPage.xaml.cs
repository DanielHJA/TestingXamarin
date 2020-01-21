using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Testing
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        MainPageViewModel viewModel = new MainPageViewModel();

        public MainPage()
        {
            InitializeComponent();
            this.Title = "My Slider App";
            BindingContext = viewModel;
            App.Print(App.UserPreferences.GetString());

            if (Device.RuntimePlatform == Device.iOS) {

            }

        }

        void Slider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            Slider slider = sender as Slider;
            int value = (int)slider.Value;
            viewModel.SliderValue = value;
        }

    }
}
