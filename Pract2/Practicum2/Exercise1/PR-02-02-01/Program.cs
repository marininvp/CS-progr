using System;
using System.IO;


namespace PR_02_02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = File.CreateText(@"D:\hh.txt"); 
            writer.WriteLine("This is my new file");
            writer.WriteLine("Do you like its format?"); 
            writer.Close();
        }
    }
}
