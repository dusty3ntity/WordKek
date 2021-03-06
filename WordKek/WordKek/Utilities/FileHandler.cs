﻿using System;
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

		public static LearningWordList OpenLearningWordList(MainWordList dictionary)
		{
			if(!FileHandlerService.FileExists("learning_list.dat"))
				return LearningWordListGenerator.GenerateList(dictionary);
			LearningWordList openedList = FileHandlerService.OpenLearningWordList();
			if(openedList.WasCreatedOn < DateTime.Now.Date)
				return LearningWordListGenerator.GenerateList(dictionary);
			else
				return openedList;
		}

        public static void SaveMainWordList(MainWordList list)
        {
            FileHandlerService.SaveMainWordList(list);
        }

		public static void SaveLearningWordList(LearningWordList list)
		{
			FileHandlerService.SaveLearningWordList(list);
		}
    }
}
