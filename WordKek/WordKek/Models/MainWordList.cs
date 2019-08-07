using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace WordKek.Models 
{
    [Serializable]
    public class MainWordList : IEnumerable
    {
        private List<Word> wordList;

        public MainWordList()
        {
            wordList = new List<Word>();
        }

        public uint GetNumberOfWords()
        {
            return (uint)wordList.Count;
        }

        public bool Add(Word word)
        {
            if (!Contains(word))
            {
                wordList.Add(word);
                return true;
            }
            else
                return false;
        }

        private bool Contains(Word word)
        {
            return wordList.Contains(word);
        }

        public void Remove(Word word)
        {
            wordList.Remove(word);
        }


        public IEnumerator GetEnumerator()
        {
            return wordList.GetEnumerator();
        }
    }
}
