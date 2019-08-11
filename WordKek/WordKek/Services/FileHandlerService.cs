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

		public static bool SaveLearningWordList(LearningWordList list)
		{
			return DependencyService.Get<IFileHandlerService>().SaveLearningWordList(list);
		}

        public static MainWordList OpenMainWordList()
        {
            return DependencyService.Get<IFileHandlerService>().OpenMainWordList();
        }

		public static LearningWordList OpenLearningWordList()
		{
			return DependencyService.Get<IFileHandlerService>().OpenLearningWordList();
		}
    }
}
