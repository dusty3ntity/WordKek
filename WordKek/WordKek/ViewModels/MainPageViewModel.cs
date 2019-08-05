using System.Windows.Input;
using WordKek.Models;
using WordKek.Utils;
using Xamarin.Forms;

namespace WordKek.ViewModels
{
    class MainPageViewModel: BaseViewModel
    {
        public MainPageViewModel()
        {
            mainWordList = FileHandler.OpenMainWordList();
        }
    }
}
