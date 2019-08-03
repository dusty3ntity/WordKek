using System;
using System.Collections.Generic;
using System.Text;

namespace WordKek.Models
{
    [Serializable]
    class WordList
    {
        private List<WordEntry> dictionary;

        public WordList()
        {
            dictionary = new List<WordEntry>();
        }

        public bool Add(WordEntry word)
        {
            if (!Contains(word))
            {
                dictionary.Add(word);
                return true;
            }
            else
                return false;
        }
        public bool Contains(WordEntry word)
        {
            return dictionary.Contains(word);
        }

    }
}
