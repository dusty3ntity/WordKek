using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using WordKek.Droid;
using WordKek.Models;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHandlerService))]
namespace WordKek.Droid
{
	class FileHandlerService : IFileHandlerService
	{
		private string DefaultFolder = Environment.ExternalStorageDirectory.AbsolutePath;

		public bool FileExists(string filePath)
		{
			string file = Path.Combine(DefaultFolder, filePath);
			return File.Exists(file);
		}

		public bool SaveMainWordList(MainWordList dictionary)
		{
			string dictionaryFile = Path.Combine(DefaultFolder, "dictionary.dat");

			BinaryFormatter formatter = new BinaryFormatter();
			using(FileStream fs = new FileStream(dictionaryFile, FileMode.Create))
			{
				formatter.Serialize(fs, dictionary);
			}
			return true;
		}

		public bool SaveLearningWordList(LearningWordList list)
		{
			string learningListFile = Path.Combine(DefaultFolder, "learning_list.dat");

			BinaryFormatter formatter = new BinaryFormatter();
			using(FileStream fs = new FileStream(learningListFile, FileMode.Create))
			{
				formatter.Serialize(fs, list);
			}
			return true;
		}

		public MainWordList OpenMainWordList()
		{

			string dictionaryFile = Path.Combine(DefaultFolder, "dictionary.dat");

			BinaryFormatter formatter = new BinaryFormatter();
			using(FileStream fs = new FileStream(dictionaryFile, FileMode.Open))
			{
				MainWordList dictionary = (MainWordList)formatter.Deserialize(fs);
				return dictionary;
			}
		}

		public LearningWordList OpenLearningWordList()
		{
			string learningListFile = Path.Combine(DefaultFolder, "learning_list.dat");

			BinaryFormatter formatter = new BinaryFormatter();
			using(FileStream fs = new FileStream(learningListFile, FileMode.Open))
			{
				LearningWordList learningWordList = (LearningWordList)formatter.Deserialize(fs);
				return learningWordList;
			}
		}
	}
}