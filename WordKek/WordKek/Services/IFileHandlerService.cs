using WordKek.Models;

namespace WordKek
{
    public interface IFileHandlerService
    {
        bool FileExists(string filePath);
        bool CreateDictionary(MainWordList dictionary);
        MainWordList ReadDictionary();
    }
}
