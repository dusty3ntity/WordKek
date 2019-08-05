using Xamarin.Forms;

namespace WordKek.Services
{
    public static class PopUpMessageService
    {
        public static void GeneratePopUpMessage(string message)
        {
            DependencyService.Get<IPopUpMessageService>().GeneratePopUpMessage(message);
        }

        public static void GeneratePopUpMessage(string message, uint duration)
        {
            DependencyService.Get<IPopUpMessageService>().GeneratePopUpMessage(message, duration);
        }
    }
}
