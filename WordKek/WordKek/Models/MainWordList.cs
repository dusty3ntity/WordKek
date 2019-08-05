using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

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
