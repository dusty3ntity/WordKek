using System.ComponentModel;
using System.Runtime.CompilerServices;

using WordKek.Models;

namespace WordKek.ViewModels
{
    abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public static MainWordList mainWordList { get; set; }
        public static bool IsDictionaryChanged;
        public static LearningWordList learningWordList;


        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
