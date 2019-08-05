using System;

namespace WordKek.Models
{
    [Serializable]
    public class Word
    {
        public string OriginalWord { get; private set; }
        public string Translation { get; private set; }
        public bool IsLearned { get; private set; }
        public ushort CorrectRepeatsCount { get; private set; }
        public ushort TotalRepeatsCount { get; private set; }

        /// <summary>
        /// Parameterized constructor 
        /// </summary>
        /// <param name="word"> Foreign word </param>
        /// <param name="translation"> Translation </param>
        public Word(string originalWord, string translation)
        {
            OriginalWord = originalWord;
            Translation = translation;
            IsLearned = false;
            CorrectRepeatsCount = 0;
        }

        public void IncreaseCorrectRepeatsCount(ushort maxRepeats)
        {
            CorrectRepeatsCount++;
            if (CorrectRepeatsCount == maxRepeats)
                IsLearned = true;
        }

        private void ResetCorrectRepeatsCount()
        {
            CorrectRepeatsCount = 0;
        }

        public override bool Equals(object ob)
        {
            Word w = ob as Word;
            if (w == null)
                return false;
            return OriginalWord == w.OriginalWord && Translation == w.Translation;
        }
    }
}
