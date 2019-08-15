using System;
using System.Collections;

namespace WordKek.Models
{
	[Serializable]
	public class LearningWordList
	{
		private ArrayList wordList;
		public DateTime WasCreatedOn { get; }
		public uint NewWordsNumber { get; set; }
		public uint WordsToPracticeNumber { get; set; }

		public uint CurrentWordNumber { get; private set; }
		public uint WordsNumber { get { return (uint)wordList.Count; } }

		public LearningWordList(DateTime wasCreatedOn)
		{
			wordList = new ArrayList();
			WasCreatedOn = wasCreatedOn;
			CurrentWordNumber = 0;
		}

		public Word GetNextWord()
		{
			if(CurrentWordNumber < wordList.Count)
				return (Word)wordList[(int)CurrentWordNumber];
			else
				return null;
		}

		public bool CheckCurrentWord(string originalWord)
		{
			Word w = (Word)wordList[(int)CurrentWordNumber++];
			if(originalWord == null)
				return false;
			if(w.OriginalWord.ToLower().Equals(originalWord.ToLower()))
			{
				w.IncreaseCorrectRepeatsCount();
				return true;
			}
			w.ResetCorrectRepeatsCount();
			return false;
		}

		public void Add(Word word)
		{
			wordList.Add(word);
		}
	}
}
