using Xamarin.Forms;

using WordKek.Utilities;
using WordKek.ViewModels;
using WordKek.Views;

namespace WordKek
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var tabbed = new CarouselPage();
            tabbed.Children.Add(new MainPage());
            tabbed.Children.Add(new DicitonaryPage());
            tabbed.Title = "WordKek";
            
            var masterDetailPage = new MasterDetailPage
            {
                Master= new MasterPage(),
                Detail = new NavigationPage(tabbed)
                {
                    BarBackgroundColor = Color.FromHex("#303030"),
                    BarTextColor = Color.FromHex("#B5B5B5"),
                }
            };
            MainPage =  masterDetailPage;
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
            FileHandler.SaveMainWordList(MainPageViewModel.mainWordList);
        }

        protected override void OnResume()
        {

        }
    }
}
