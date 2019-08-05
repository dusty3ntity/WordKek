using System.Collections;
using System.Collections.Generic;

namespace WordKek.Models
{
    class LearningWordList : IEnumerable
    {
        private List<Word> wordList;
        public uint NewWordsNumber { get; set; }
        public uint WordsToPracticeNumber { get; set; }

        public LearningWordList()
        {
            wordList = new List<Word>();
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
