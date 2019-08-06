using System.ComponentModel;
using Xamarin.Forms;

using WordKek.ViewModels;

namespace WordKek.Views
{
    [DesignTimeVisible(false)]
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}