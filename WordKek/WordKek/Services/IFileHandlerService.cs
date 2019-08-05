using WordKek.Models;

namespace WordKek
{
    public interface IFileHandlerService
    {
        bool FileExists(string filePath);
        bool SaveMainWordList(MainWordList dictionary);
        MainWordList OpenMainWordList();
    }
}
