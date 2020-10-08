using System;
using System.IO;

namespace PR_02_02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = File.OpenText(@"D:\hh.txt");
            string contents = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(contents);
        }
    }
}
