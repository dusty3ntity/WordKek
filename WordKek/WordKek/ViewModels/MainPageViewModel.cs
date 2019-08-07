using WordKek.Models;
using WordKek.Utilities;

namespace WordKek.ViewModels
{
    class MainPageViewModel: BaseViewModel
    {
        public uint WordsInDictionaryNumber { get { return mainWordList.NumberOfWords; } }
        public uint WordsToPracticeNumber { get { return learningWordList.WordsToPracticeNumber; } }
        public uint NewWordsNumber { get { return learningWordList.NewWordsNumber; } }

        public MainPageViewModel()
        {
            mainWordList = FileHandler.OpenMainWordList();
            IsDictionaryChanged = false;
            learningWordList = LearningWordListGenerator.GenerateList(mainWordList);
        }
    }
}
