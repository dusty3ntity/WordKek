using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using WordKek.ViewModels;

namespace WordKek.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DicitonaryPage : ContentPage
    {
        static object locker = new object();
        public DicitonaryPage()
        {
            InitializeComponent();
            DictionaryList.ItemsSource = BaseViewModel.mainWordList;
            BindingContext = new AddNewWordPageViewModel();
            AddNewWordPageViewModel.DPage = this;
        }
        public void UpdateDictionary()
        {
            DictionaryList.ItemsSource = null;
            DictionaryList.ItemsSource = BaseViewModel.mainWordList;
        }
        protected override void OnAppearing()
        {
           // DictionaryList.ItemsSource = null;
           // DictionaryList.ItemsSource = BaseViewModel.mainWordList;
            base.OnAppearing();
           /* lock(locker) {

            }*/

        }
    }
}