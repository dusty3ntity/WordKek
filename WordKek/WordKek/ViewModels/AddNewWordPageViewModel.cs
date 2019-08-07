using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WordKek.Models;
using Xamarin.Forms;
using WordKek.Views;
namespace WordKek.ViewModels 
{
    class AddNewWordPageViewModel : BaseViewModel
    {
        public string Word{get;set; }
        public string Translate { get; set; }
        
        public Command AddNewWord { get; set; }

        public static DicitonaryPage DPage { get; set; }

        public AddNewWordPageViewModel()
        {
            AddNewWord = new Command(() =>
            {
                if ((Word != null && Translate != null)&&
                    (Word != "" && Translate != "") 
                )
                {
                    mainWordList.Add(new Word(this.Word, Translate));
                    if(DPage!=null)
                    {
                        DPage.UpdateDictionary();
                    }
                    App.Current.MainPage.DisplayAlert("Notification", "Word Added", "Okay");
                    this.Word = string.Empty;
                    this.Translate = string.Empty;
                    NotifyPropertyChanged(nameof(Word));
                    NotifyPropertyChanged(nameof(Translate));
                }
                else
                {

                    App.Current.MainPage.DisplayAlert("Notification", "Error", "Okay");
                }
            });
        }
    }
}
