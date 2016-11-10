using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DemoApp
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        void Button_OnClicked(object sender, EventArgs e)
        {
            var button = sender as Button;

            var currentMasterDetailPage = Application.Current.MainPage as MasterDetailPage;

            switch (button?.AutomationId)
            {
                case "main":
                    currentMasterDetailPage.Detail = new NavigationPage(new ContentPage {BackgroundColor = Color.Fuchsia});
                    break;
                case "help":
                    currentMasterDetailPage.Detail = new NavigationPage(new ContentPage { BackgroundColor = Color.Lime });
                    break;
                case "about":
                    break;
            }
        }
    }
}
