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

        public bool CreateDictionary(MainWordList dictionary)
        {
            string dictionaryFile = Path.Combine(DefaultFolder, "dictionary.dat");

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(dictionaryFile, FileMode.Create))
            {
                formatter.Serialize(fs, dictionary);
            }
            return true;
        }

        public MainWordList ReadDictionary()
        {
            string dictionaryFile = Path.Combine(DefaultFolder, "dictionary.dat");

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(dictionaryFile, FileMode.Open))
            {
                MainWordList dictionary = (MainWordList)formatter.Deserialize(fs);
                return dictionary;
            }
        }
    }
}