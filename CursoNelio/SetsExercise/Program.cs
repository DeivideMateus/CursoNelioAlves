using System;
using System.Collections.Generic;
using System.IO;
using SetsExercise.Entities;

namespace SetsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //usando HashSet ao invés de SortedSet, por ser mais rápido e a ordem não importar.
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = name, Instant = instant });
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
