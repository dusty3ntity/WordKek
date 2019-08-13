using System;
using System.ComponentModel;
using Xamarin.Forms;

using WordKek.ViewModels;

namespace WordKek.Views
{
    [DesignTimeVisible(false)]
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
            if (BaseViewModel.learningWordList.GetNextWord() != null)
            Navigation.PushAsync(new LearningPage());
        }
    }
}
