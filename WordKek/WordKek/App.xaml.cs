using System;
using WordKek.Utils;
using WordKek.ViewModels;
using WordKek.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WordKek
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var tabbed = new CarouselPage();
            tabbed.Children.Add(new MainPage());
            tabbed.Children.Add(new MainPage());
            tabbed.Title = "WordKek";
            
            
            var masterdetailpage = new MasterDetailPage
            {

                Master= new MainPage(),
                Detail = new NavigationPage(tabbed)
                {
                    BarBackgroundColor = Color.FromHex("#303030"),
                    BarTextColor = Color.FromHex("#B5B5B5"),
                }

            };
            MainPage =  masterdetailpage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            FileHandler.SaveMainWordList(MainPageViewModel.mainWordList);
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
