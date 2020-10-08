using System;
using System.IO;
using System.IO.IsolatedStorage;

namespace PR_02_04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            IsolatedStorageFile userStore = IsolatedStorageFile.GetUserStoreForAssembly();
            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Create, userStore);

            StreamWriter userWriter = new StreamWriter(userStream);
            userWriter.WriteLine("99 Bottles of Beer on the wall,99 Bottles of Beer");
            userWriter.Close();

            string[] files = userStore.GetFileNames("UserSettings.set");
            if (files.Length == 0)
            {
                Console.WriteLine("Файл отсутствует");
                Environment.Exit(0);
            }

            userStream = new IsolatedStorageFileStream("UserSettings.set",FileMode.Open, userStore); 
            StreamReader userReader = new StreamReader(userStream);
            string contents = userReader.ReadToEnd();

            Console.WriteLine(userReader);
        }
    }
}
