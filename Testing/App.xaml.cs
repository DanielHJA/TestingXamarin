using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Testing
{
    public partial class App : Application
    {

        public static IUserPreferences UserPreferences { get; private set; }

        public static void Init(IUserPreferences userPreferences)
        {
            App.UserPreferences = userPreferences;
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
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

        public static void Print(object value)
        {
            System.Console.WriteLine(value);
        }

    }
}
