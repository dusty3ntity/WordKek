using System;
using System.ComponentModel;

using Xamarin.Forms;

using WordKek.ViewModels;
using WordKek.Services;
using Xamarin.Forms.Xaml;

namespace WordKek.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AddNewWordButton.Source = ImageSource.FromFile("ImagePlusButton.png");
            BindingContext = new MainPageViewModel();
        }

        private void OnAddNewWordClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddNewWordPage());
        }

        private void OnContinueLearningClicked(object sender, EventArgs e)
        {
			if(MainPageViewModel.learningWordList.GetNextWord() != null)
				Navigation.PushAsync(new LearningPage());
			else
				PopUpMessageService.GeneratePopUpMessage("You've done your best today! Come tomorrow!");
        }
    }
}
