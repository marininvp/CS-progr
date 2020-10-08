using System;
using System.IO;
using System.IO.Compression;


namespace PR_02_03_01
{
    class Program
    {
        static void CompressFile(string inFilename,string outFilename)
        {
            FileStream sourceFile = File.OpenRead(inFilename);
            FileStream destFile = File.Create(outFilename);

            GZipStream compStream = new GZipStream(destFile, CompressionMode.Compress);
            
            int theByte =sourceFile.ReadByte();
            while (theByte != -1)
            {
                compStream.WriteByte((byte)theByte);
                theByte = sourceFile.ReadByte();
            }
            compStream.Close();
            sourceFile.Close();
        }

        static void Main(string[] args)
        {
            CompressFile(@"D:\hh.txt", @"D:\hh.txt.gz");
        }
    }
}
