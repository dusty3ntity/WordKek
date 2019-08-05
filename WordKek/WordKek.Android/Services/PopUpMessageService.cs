using System;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;

using WordKek.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(PopUpMessageService))]
namespace WordKek.Droid
{
    class PopUpMessageService : IPopUpMessageService
    {
        public void GeneratePopUpMessage(string message)
        {
            Notify(message, 2000, null, null);
        }

        public void GeneratePopUpMessage(string message, uint duration)
        {
            Notify(message, duration, null, null);
        }

        private void Notify(string message, uint duration, string actionText, Action<object> action)
        {
            var view = ((Activity)Forms.Context).FindViewById(Android.Resource.Id.Content);
            var snack = Snackbar.Make(view, message, (int) duration);
            if (actionText != null && action != null)
                snack.SetAction(actionText, action);
            snack.Show();
        }
    }
}