using System;
using System.Collections.Generic;
using System.Text;
using WordKek.Models;
using Xamarin.Forms;

namespace WordKek.ViewModels
{
    class LearningPageViewModel :BaseViewModel 
    {
        public static string Translation { get; set; }
        public static string OriginalWord { get; set; }

        private static Word word=learningWordList.GetNextWord();
        public string LearninigWordsInfo
        {
            get
            {
                return string.Format("{0}/{1}",word.CorrectRepeatsCount,word.TotalRepeatsCount);
            }
        }

        public Command OnSubmitButtonClick { get; set; }
        static LearningPageViewModel()
        {
            OriginalWord = word.OriginalWord;
        }
        public LearningPageViewModel()
        {
            OnSubmitButtonClick = new Command(() =>
            {
                NotifyPropertyChanged(nameof(OriginalWord));
                NotifyPropertyChanged(nameof(LearninigWordsInfo));
                if (word.IsTranslationCorrect(Translation))
                {
                    Application.Current.MainPage.DisplayAlert("Correct", "You entered correctly:"+OriginalWord+" - "+Translation, "OK");
                }
                 else
                {
                    Application.Current.MainPage.DisplayAlert("Failed", "You entered incorrectly:" + OriginalWord + " - " + Translation, "OK");
                }
            });
        }
    }
}
