// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.IO;
using System;
using System.IO.Compression;

namespace CompressionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string inFilename = @"C:\!Полина\newfile.txt";
            string outFilename = @"C:\!Полина\2.txt.gz";
            FileStream sourceFile = File.OpenRead(inFilename);
            FileStream destFile = File.Create(outFilename);

            GZipStream compStream = new GZipStream(destFile, CompressionMode.Compress);
            int theByte = sourceFile.ReadByte();
            while (theByte != -1)
            {
                compStream.WriteByte((byte)theByte);
                theByte = sourceFile.ReadByte();
            }
            compStream.Close();
            */
            
            string inFilename = @"C:\!Полина\2.txt.gz";
            string outFilename = @"C:\!Полина\suda2.txt";
            FileStream sourceFile = File.OpenRead(inFilename);
            FileStream destFile = File.Create(outFilename);
            GZipStream compStream =
            new GZipStream(sourceFile, CompressionMode.Decompress);
            int theByte = compStream.ReadByte();
            while (theByte != -1)
            {
                destFile.WriteByte((byte)theByte);
                theByte = compStream.ReadByte();
            }

            compStream.Close();
            destFile.Close();
            sourceFile.Close();

        }
    }
}