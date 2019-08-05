using WordKek.Models;
using WordKek.Services;

namespace WordKek.Utils
{
    static class FileHandler
    {
        public static MainWordList OpenMainWordList()
        {
            MainWordList list;
            if (FileHandlerService.FileExists("dictionary.dat"))
                list = FileHandlerService.ReadDictionary();
            else
            {
                list = new MainWordList();
                PopUpMessageService.GeneratePopUpMessage("New dictionary has been created");
            }
            return list;
        }
    }
}
