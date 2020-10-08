using System;
using System.IO;

namespace PR_02_01_02
{
    class Program
    {
        static void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Changed: {0}", e.FullPath);
        }
        static void Main(string[] args)
        {
            FileSystemWatcher watcher =new FileSystemWatcher(Environment.SystemDirectory);

            // C#
            watcher.EnableRaisingEvents = true;
            watcher.Filter = "*.ini*";
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.Size;
            watcher.Changed += new FileSystemEventHandler(watcher_Changed);
            Console.ReadKey();
            
        }
    }
}
