using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\file1.txt.txt";
            string target = @"C:\temp\file2.txt.txt";
            FileInfo file = new FileInfo(path);
            file.CopyTo(target);
            

            
        }
    }
}
