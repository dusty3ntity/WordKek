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

        public static INavigation Navigation { get; set; }
        public string LearninigWordsInfo
        {
            get
            {
                return string.Format("{0}/{1}",learningWordList.CurrentWordNumber+1,learningWordList.WordsNumber);
            }
        }

        public Command OnSubmitButtonClick { get; set; }
        public LearningPageViewModel()
        {
			NotifyPropertyChanged(nameof(LearninigWordsInfo));

			OriginalWord = learningWordList.GetNextWord();
            if (OriginalWord == null) Navigation.PopAsync();
            OnSubmitButtonClick = new Command(async() =>
            {
                string rightTranslation = learningWordList.CheckCurrentWord(Translation).ToLower();

                if (Translation!=null && !rightTranslation.Equals(Translation.ToLower()))
                {
                    await Application.Current.MainPage.DisplayAlert("Failed", "\n" + OriginalWord + " - " + rightTranslation, "OK");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Correct", "\n" + OriginalWord + " - " + rightTranslation, "OK");
                }
                UpdateOrLeavePage();
			});
        }

        void UpdateOrLeavePage()
        {
            OriginalWord = learningWordList.GetNextWord();
            if (OriginalWord == null) Navigation.PopAsync();
            Translation = string.Empty;
            NotifyPropertyChanged(nameof(OriginalWord));
            NotifyPropertyChanged(nameof(Translation));
            NotifyPropertyChanged(nameof(LearninigWordsInfo));
        }
    }

}
