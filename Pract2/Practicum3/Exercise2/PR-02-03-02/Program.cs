using System;
using System.IO;
using System.IO.Compression;

namespace PR_02_03_02
{
    class Program
    {
        static void UncompressFile(string inFilename,string outFilename)
        {
            FileStream sourceFile = File.OpenRead(inFilename);
            FileStream destFile = File.Create(outFilename);
            
            GZipStream compStream = new GZipStream(sourceFile, CompressionMode.Decompress);

            int theByte = compStream.ReadByte();
            while (theByte != -1)
            {
                destFile.WriteByte((byte)theByte);
                theByte = compStream.ReadByte();
            }

            compStream.Close();
            destFile.Close();
        }

        static void Main(string[] args)
        {
            UncompressFile(@"D:\hh.txt.gz", @"D:\hh.txt.test");
        }
    }
}