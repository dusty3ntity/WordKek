using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordKek.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WordKek.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DicitonaryListPage : ContentPage
    {
        public DicitonaryListPage()
        {
            InitializeComponent();
            DictionaryList.ItemsSource = MainPageViewModel.mainWordList;

        }
    }
}