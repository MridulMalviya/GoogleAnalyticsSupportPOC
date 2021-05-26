using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.GoogleAnalytics;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoogleAnalyticsSupportPOC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
           
            GoogleAnalytics.Current.Tracker.SendView("Page1");
        }
    }
}