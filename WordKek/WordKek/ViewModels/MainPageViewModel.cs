using WordKek.Utilities;

namespace WordKek.ViewModels
{
    class MainPageViewModel: BaseViewModel
    {
        public MainPageViewModel()
        {
            mainWordList = FileHandler.OpenMainWordList();
            IsDictionaryChanged = false;
        }
    }
}
