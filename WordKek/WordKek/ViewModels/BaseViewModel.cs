using System.ComponentModel;
using System.Runtime.CompilerServices;

using WordKek.Models;

namespace WordKek.ViewModels
{
    abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public static MainWordList mainWordList;
        public static bool IsDictionaryChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
