using WordKek.Models;

namespace WordKek
{
    public interface IFileHandlerService
    {
        bool FileExists(string filePath);
        bool SaveMainWordList(MainWordList dictionary);
		bool SaveLearningWordList(LearningWordList list);
        MainWordList OpenMainWordList();
		LearningWordList OpenLearningWordList();
    }
}
