using System;
using System.IO;
using System.IO.IsolatedStorage;

namespace PR_02_04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            IsolatedStorageFile userStore = IsolatedStorageFile.GetUserStoreForAssembly();
            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream("UserSettings.set",FileMode.Create, userStore);

            StreamWriter userWriter = new StreamWriter(userStream); 
            userWriter.WriteLine("99 Bottles of Beer on the wall, 99 Bottles of Beer");
            userWriter.Close();

        }
    }
}
