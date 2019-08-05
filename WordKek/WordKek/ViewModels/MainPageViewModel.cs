using System.Windows.Input;
using WordKek.Models;
using WordKek.Utils;
using Xamarin.Forms;

namespace WordKek.ViewModels
{
    class MainPageViewModel: BaseViewModel
    {
        private MainWordList mainWordList;

        private ClickModel clickModel;

        public ICommand ClickCommand { get; private set; }

        public string LabelText {
            get => clickModel.Status;
        }

        public MainPageViewModel()
        {
            mainWordList = FileHandler.OpenMainWordList();

            ClickCommand = new Command(OnButtonClick);
            clickModel = new ClickModel();
        }

        private void OnButtonClick()
        {
            clickModel.OnClick();
            NotifyPropertyChanged(nameof(LabelText));
        }
    }
}
