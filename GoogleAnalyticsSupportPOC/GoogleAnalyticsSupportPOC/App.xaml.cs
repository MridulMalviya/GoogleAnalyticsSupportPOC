using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.GoogleAnalytics;


namespace GoogleAnalyticsSupportPOC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            GoogleAnalytics.Current.Config.TrackingId = "273509979";
            GoogleAnalytics.Current.Config.AppId = "analyticspoc-b4b54";
            GoogleAnalytics.Current.Config.AppName = "GoogleAnalyticsPoc";
            GoogleAnalytics.Current.Config.AppVersion = "1.0.0.0";
            //GoogleAnalytics.Current.Config.Debug = true;
            //For tracking install and starts app, you can change default event properties:
            //GoogleAnalytics.Current.Config.ServiceCategoryName = "App";
            //GoogleAnalytics.Current.Config.InstallMessage = "Install";
            //GoogleAnalytics.Current.Config.StartMessage = "Start";
            //GoogleAnalytics.Current.Config.AppInstallerId = "someID"; // for custom installer id
            GoogleAnalytics.Current.InitTracker();

            //Track view
            GoogleAnalytics.Current.Tracker.SendView("MainPage");

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
    }
}
