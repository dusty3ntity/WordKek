using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using WordKek.Models;
using Xamarin.Forms;

namespace WordKek.ViewModels
{
    class LearningPageViewModel :BaseViewModel 
    {
        public string Translation { get; set; }
        public string OriginalWord { get; set; }

        public string LearninigWordsInfo
        {
            get
            {
                return string.Format("{0}/{1}",learningWordList.CurrentWordNumber,learningWordList.WordsNumber);
            }
        }

        public Command OnSubmitButtonClick { get; set; }
        public LearningPageViewModel()

        {

            OriginalWord = learningWordList.GetNextWord();
            if (string.IsNullOrEmpty(OriginalWord)) return;
            OnSubmitButtonClick = new Command(() =>
            {
                if (string.IsNullOrEmpty(OriginalWord)) return;
                    string rightTranslation = learningWordList.CheckCurrentWord(Translation).ToLower();
                if (!rightTranslation.Equals(Translation.ToLower()))
                {
                    Application.Current.MainPage.DisplayAlert("Failed", "You entered incorrectly:" + OriginalWord + " - " + rightTranslation, "OK");
                }
                else
                {
                    Application.Current.MainPage.DisplayAlert("Correct", "You entered correctly:" + OriginalWord + " - " + rightTranslation, "OK");
                }
                OriginalWord = learningWordList.GetNextWord();
                Translation = string.Empty;
                NotifyPropertyChanged(nameof(OriginalWord));
                NotifyPropertyChanged(nameof(Translation));
                NotifyPropertyChanged(nameof(LearninigWordsInfo));

            });
        }
    }
}
