using WordKek.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WordKek.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearningPage : ContentPage
    {
        public LearningPage()
        {
            InitializeComponent();
            BindingContext = new LearningPageViewModel();
            LearningPageViewModel.Navigation = Navigation;
        }
    }
}