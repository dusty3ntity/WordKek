using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WordKek.Utilities;
using WordKek.ViewModels;
using WordKek.Views;
using System.Threading.Tasks;

namespace WordKek
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MasterDetailPage
            {
                Master = new MasterPage(),
                Detail = new NavigationPage(new CarouselPage()
                {
                    Children = { new MainPage(),
                    new DicitonaryPage()},
                    Title = "WordKek"
                })
                {
                    BarBackgroundColor = Color.FromHex("#303030"),
                    BarTextColor = Color.FromHex("#B5B5B5"),
                }
            };

        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
            FileHandler.SaveMainWordList(MainPageViewModel.mainWordList);
            FileHandler.SaveLearningWordList(MainPageViewModel.learningWordList);

        }

        protected override void OnResume()
        {
            MainPageViewModel.learningWordList = FileHandler.OpenLearningWordList(MainPageViewModel.mainWordList);
        }
    }
}
