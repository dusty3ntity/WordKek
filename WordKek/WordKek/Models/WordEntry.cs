using System;
using System.Collections.Generic;
using System.Text;

namespace WordKek.Models
{

    class WordEntry
    {
        public string Word { get; private set; }
        public string Translation { get; private set; }
        public bool IsLearned { get; private set; }
        public ushort CorrectRepeatsCount { get; private set; }
        /// <summary>
        /// Parameterized constructor 
        /// </summary>
        /// <param name="word"> Foreign word</param>
        /// <param name="translation"> Origin word</param>
        public WordEntry(string word, string translation)
        {
            Word = word;
            Translation = translation;
            IsLearned = false;
            CorrectRepeatsCount = 0;
        }

        public void IncreaseCorrectRepeatsCount(ushort maxRepeats)
        {
            if (CorrectRepeatsCount < maxRepeats)
                CorrectRepeatsCount++;
            else
                IsLearned = true;
        }
        private void ResetCorrectRepeatsCount()
        {
            CorrectRepeatsCount = 0;
        }
        public bool Equals(WordEntry word)
        {
            return Word == word.Word && Translation == word.Translation;
        }
    }
}
