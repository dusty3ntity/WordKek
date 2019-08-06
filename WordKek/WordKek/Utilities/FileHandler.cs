using WordKek.Models;
using WordKek.Services;

namespace WordKek.Utilities
{
    static class FileHandler
    {
        public static MainWordList OpenMainWordList()
        {
            MainWordList list;
            if (FileHandlerService.FileExists("dictionary.dat"))
                list = FileHandlerService.OpenMainWordList();
            else
            {
                list = new MainWordList();
                PopUpMessageService.GeneratePopUpMessage("New dictionary has been created");
            }
            return list;
        }

        public static void SaveMainWordList(MainWordList list)
        {
            FileHandlerService.SaveMainWordList(list);
        }
    }
}
