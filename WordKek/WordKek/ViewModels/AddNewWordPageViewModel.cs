using Xamarin.Forms;

using WordKek.Models;
using WordKek.Views;
using WordKek.Services;

namespace WordKek.ViewModels
{
	class AddNewWordPageViewModel : BaseViewModel
	{
		public string Word { get; set; }
		public string Translate { get; set; }

		public Command AddNewWord { get; set; }

		public static DicitonaryPage DPage { get; set; }

		public AddNewWordPageViewModel()
		{
			AddNewWord = new Command(() =>
			{
				if(!string.IsNullOrEmpty(Word) && !string.IsNullOrEmpty(Translate))
				{
					mainWordList.Add(new Word(Word, Translate));
					if(DPage != null)
						DPage.UpdateDictionary();
					PopUpMessageService.GeneratePopUpMessage($"Word ' {Word} - {Translate} ' added");
					this.Word = string.Empty;
					this.Translate = string.Empty;
					NotifyPropertyChanged(nameof(Word));
					NotifyPropertyChanged(nameof(Translate));
				}
				else
					PopUpMessageService.GeneratePopUpMessage("Error");
			});
		}
	}
}
