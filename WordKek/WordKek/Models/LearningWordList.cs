using System;
using System.Collections;
using System.Collections.Generic;

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

		public string GetNextWord()
		{
			if(CurrentWordNumber < wordList.Count)
			{
				Word w = (Word)wordList[(int)CurrentWordNumber];
				return w.Translation;
			}
			else
				return null;
		}

		public string CheckCurrentWord(string originalWord)
		{
			Word w = (Word)wordList[(int)CurrentWordNumber];
            CurrentWordNumber++;
			return w.OriginalWord;
		}

		public void Add(Word word)
		{
			wordList.Add(word);
		}
	}
}
