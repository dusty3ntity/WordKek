using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using WordKek.Models;

namespace WordKek.ViewModels
{
    abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public static MainWordList mainWordList;

        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
