using System;
using System.Collections;
using System.Text;

namespace WordKek.Models
{
    class LearningWordList
    {
        public ArrayList WordList { get; private set; }

        public ushort CurrentWordNumber { get; private set; }

        public LearningWordList(ArrayList list)
        {
            WordList = list;
            CurrentWordNumber = 0;
        }

        public Word GetNextWord()
        {
            if (CurrentWordNumber == WordList.Count)
                return null;
            return (Word) WordList[CurrentWordNumber++];
        }
    }
}
