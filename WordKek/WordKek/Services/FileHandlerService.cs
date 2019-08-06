using Xamarin.Forms;

using WordKek.Models;

namespace WordKek.Services
{
    public static class FileHandlerService
    {
        public static bool FileExists(string filePath)
        {
            return DependencyService.Get<IFileHandlerService>().FileExists(filePath);
        }

        public static bool SaveMainWordList(MainWordList dictionary)
        {
            return DependencyService.Get<IFileHandlerService>().SaveMainWordList(dictionary);
        }

        public static MainWordList OpenMainWordList()
        {
            return DependencyService.Get<IFileHandlerService>().OpenMainWordList();
        }
    }
}
