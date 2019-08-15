using Xamarin.Forms;

using WordKek.Models;
using WordKek.Services;

using System.Diagnostics;

namespace WordKek.ViewModels
{
	class LearningPageViewModel : BaseViewModel
	{
		private Word currentWord;
		public string Translation { get; set; }
		public string OriginalWord { get; set; }

		public static INavigation Navigation { get; set; }
		public Command OnSubmitButtonClick { get; set; }
		public string LearniningWordsInfo
		{
			get
			{
				return string.Format("{0}/{1}   CR: {2}", learningWordList.CurrentWordNumber + 1, learningWordList.WordsNumber, currentWord.CorrectRepeatsCount);
			}
		}

		public LearningPageViewModel()
		{
			currentWord = learningWordList.GetNextWord();
			if(currentWord == null)
				Navigation.PopAsync();
			OriginalWord = currentWord.Translation;

			OnSubmitButtonClick = new Command(async () =>
			{
				if(learningWordList.CheckCurrentWord(Translation))
					await Application.Current.MainPage.DisplayAlert("Correct!", "\n" + currentWord.OriginalWord + " - " + OriginalWord, "OK");
				else
					await Application.Current.MainPage.DisplayAlert("Wrong!", "\n" + currentWord.OriginalWord + " - " + OriginalWord, "OK");

				UpdateOrLeavePage();
			});
		}

		void UpdateOrLeavePage()
		{
			currentWord = learningWordList.GetNextWord();
			if(currentWord == null)
			{
				Navigation.PopAsync();
				PopUpMessageService.GeneratePopUpMessage("Great! There are no words left for today!");
			}
			else
			{
				OriginalWord = currentWord.Translation;
				Translation = string.Empty;
				NotifyPropertyChanged(nameof(OriginalWord));
				NotifyPropertyChanged(nameof(Translation));
				NotifyPropertyChanged(nameof(LearniningWordsInfo));
			}
		}
	}

}
