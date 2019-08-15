using System;

namespace WordKek.Models
{
	static class LearningWordListGenerator
	{
		private const int numberOfWordsPerDay = 100;
		private const double numberOfOnLearningWordsInTrainingCoef = 0.7;
		private const double numberOfNewWordsInTrainingCoef = 0.2;


		public static LearningWordList GenerateList(MainWordList mainList)
		{
			LearningWordList wordList = new LearningWordList(DateTime.Now.Date);

			//Failed words
			uint failedWordsNumber = 0;
			foreach(Word w in mainList)
			{
				if(w.GoesForNextDay)
				{
					wordList.Add(w);
					failedWordsNumber++;
				}
			}

			//Not new but not completed words
			uint onLearningWordsMaxNumber = (uint)Math.Floor((numberOfWordsPerDay - failedWordsNumber) * numberOfOnLearningWordsInTrainingCoef);
			uint onLearningWordsNumber = 0;
			foreach(Word w in mainList)
			{
				if(w.CorrectRepeatsCount > 0 && w.CorrectRepeatsCount < 5)
				{
					if(onLearningWordsNumber == onLearningWordsMaxNumber)
						break;
					wordList.Add(w);
					onLearningWordsNumber++;
				}
			}

			//New words
			uint newWordsMaxNumber = (uint)Math.Floor((numberOfWordsPerDay - failedWordsNumber - onLearningWordsNumber) * (numberOfOnLearningWordsInTrainingCoef - numberOfNewWordsInTrainingCoef));
			uint newWordsNumber = 0;
			foreach(Word w in mainList)
			{
				if(!w.GoesForNextDay && w.CorrectRepeatsCount == 0)
				{
					if(newWordsNumber == newWordsMaxNumber)
						break;
					wordList.Add(w);
					newWordsNumber++;
				}
			}

			//Learned words
			uint learnedWordsMaxNumber = (uint)(numberOfWordsPerDay - failedWordsNumber - onLearningWordsNumber - newWordsNumber);
			uint learnedWordsNumber = 0;
			foreach(Word w in mainList)
			{
				if(w.IsLearned)
				{
					if(learnedWordsNumber == learnedWordsMaxNumber)
						break;
					wordList.Add(w);
					learnedWordsNumber++;
				}
			}

			wordList.NewWordsNumber = newWordsNumber;
			wordList.WordsToPracticeNumber = failedWordsNumber + onLearningWordsNumber + learnedWordsNumber;

			return wordList;
		}
	}
}
