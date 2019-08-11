using System;
using System.Collections;
using System.Collections.Generic;

namespace WordKek.Models
{
	[Serializable]
    public class LearningWordList : IEnumerable
    {
        private List<Word> wordList;
		public DateTime WasCreatedOn { get; }
        public uint NewWordsNumber { get; set; }
        public uint WordsToPracticeNumber { get; set; }

        public LearningWordList(DateTime wasCreatedOn)
        {
            wordList = new List<Word>();
			WasCreatedOn = wasCreatedOn;
        }

        public void Add(Word word)
        {
            wordList.Add(word);
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
