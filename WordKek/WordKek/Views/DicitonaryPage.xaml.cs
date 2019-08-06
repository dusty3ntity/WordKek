using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using WordKek.ViewModels;

namespace WordKek.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DicitonaryPage : ContentPage
    {
        public DicitonaryPage()
        {
            InitializeComponent();
            DictionaryList.ItemsSource = MainPageViewModel.mainWordList;
        }
    }
}