using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LottieWorkWithUs
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            ((NavigationPage)MainPage).BarBackgroundColor = Color.LightGray;
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
