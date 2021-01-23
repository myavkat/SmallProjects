using System;
using System.Collections.Generic;
using System.IO;

namespace FileCollecterSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 01;
            string directory;
            string fileType;

            directory = GetDirectory();
            while (!Directory.Exists(directory))
            {
                directory = GetDirectory();
                Console.WriteLine(directory);
            }
            Console.Write("Enter file type (Ex: .jpg) : ");
            fileType = Console.ReadLine();

            foreach (var folder in Directory.GetDirectories(directory))
            {
                Console.WriteLine(folder);
                foreach (var file in Directory.GetFiles(folder, "*" + fileType))
                {
                    Console.WriteLine(file);
                    Directory.CreateDirectory(directory + "\\Result\\In Here");
                    File.Copy(file, directory +  "\\Result\\In Here\\" + i + fileType);
                    i++;
                }       
            }
            Console.WriteLine("Successfully completed!\nMade by MyavKat");
            Console.ReadKey();
        }

        static string GetDirectory()
        {
            //Asks user directory
            string directory;

            Console.Write("Enter file directory:");
            return directory = Console.ReadLine();
            
        }
    }
}
