using System;
using System.IO;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt.txt";
            string targetPath = @"c:\temp\file2.txt.txt";

            FileInfo file = new FileInfo(sourcePath);
            file.CopyTo(targetPath);
        }
    }
}
