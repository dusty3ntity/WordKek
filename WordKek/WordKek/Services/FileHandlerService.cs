using WordKek.Models;
using Xamarin.Forms;

namespace WordKek.Services
{
    public static class FileHandlerService
    {
        public static bool FileExists(string filePath)
        {
            return DependencyService.Get<IFileHandlerService>().FileExists(filePath);
        }

        public static bool CreateDictionary(MainWordList dictionary)
        {
            return DependencyService.Get<IFileHandlerService>().CreateDictionary(dictionary);
        }

        public static MainWordList ReadDictionary()
        {
            return DependencyService.Get<IFileHandlerService>().ReadDictionary();
        }
    }
}
