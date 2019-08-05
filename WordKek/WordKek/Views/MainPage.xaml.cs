﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordKek.ViewModels;
using Xamarin.Forms;
namespace WordKek.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AddNewWord.Source = ImageSource.FromFile("ImagePlusButton.png");
            BindingContext = new MainPageViewModel();
        }

        private void AddNewWord_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddNewWord());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LearningPage());
        }
    }
}
