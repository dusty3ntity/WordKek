using System;

namespace WordKek.Models
{
    [Serializable]
    public class Word
    {
		private const uint maxRepeats = 5;

        public string OriginalWord { get; private set; }
        public string Translation { get; private set; }
        public bool IsLearned { get; private set; }
        public ushort CorrectRepeatsCount { get; private set; }
        public ushort TotalRepeatsCount { get; private set; }
		public bool GoesForNextDay { get; private set; }

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
            TotalRepeatsCount = 0;
			GoesForNextDay = false;
        }

        public void IncreaseCorrectRepeatsCount()
        {
            TotalRepeatsCount++;
            CorrectRepeatsCount++;
            if (CorrectRepeatsCount == maxRepeats)
                IsLearned = true;
			GoesForNextDay = false;
        }

        public void ResetCorrectRepeatsCount()
        {
            TotalRepeatsCount++;
            CorrectRepeatsCount = 0;
			GoesForNextDay = true;
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
