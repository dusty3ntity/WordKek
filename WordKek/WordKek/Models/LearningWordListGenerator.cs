using System;

namespace WordKek.Models
{
    static class LearningWordListGenerator
    {
        private static int numberOfWordsPerDay = 100;
        private static double numberOfNewWordsInTrainingCoef = 0.8;

        public static LearningWordList GenerateList(MainWordList mainList)
        {
			LearningWordList wordList = new LearningWordList(DateTime.Now.Date);

            //Failed Words
            uint failedWordsNumber = 0;
            foreach (Word w in mainList)
            {
                if (w.GoesForNextDay)
                {
                    wordList.Add(w);
                    failedWordsNumber++;
                }
            }

            //New Words
            uint newWordsMaxNumber = (uint) Math.Floor((numberOfWordsPerDay - failedWordsNumber) * numberOfNewWordsInTrainingCoef);
            uint newWordsNumber = 0;
            foreach (Word w in mainList)
            {
                if (!w.IsLearned)
                {
                    if (newWordsNumber == newWordsMaxNumber)
                        break;
                    wordList.Add(w);
                    newWordsNumber++;
                }
            }

            //Learned words
            uint learnedWordsMaxNumber = (uint) (numberOfWordsPerDay-failedWordsNumber-newWordsNumber);
            uint learnedWordsNumber = 0;
            foreach (Word w in mainList)
            {
                if(w.IsLearned)
                {
                    if (learnedWordsNumber == learnedWordsMaxNumber)
                        break;
                    wordList.Add(w);
                    learnedWordsNumber++;
                }
            }

            wordList.NewWordsNumber = newWordsNumber;
            wordList.WordsToPracticeNumber = failedWordsNumber + learnedWordsNumber;

            return wordList;
        }
    }
}
