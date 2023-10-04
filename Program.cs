using System;
using System.IO;

namespace renamer
{
    class Program
    {
        static void Main(string[] args)
        {
            var directories = Directory.GetDirectories(".");
            foreach(var directory in directories)
            {
                Rename(directory);
            }
        }

        private static void Rename(string directory)
        {
            var newName = directory.Substring(0, 10) + "0"+directory.Substring(10);
            Directory.Move(directory,newName);
            Console.WriteLine(newName);
        }
    }
}
