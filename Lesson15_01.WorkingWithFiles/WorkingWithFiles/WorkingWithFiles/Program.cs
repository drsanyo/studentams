using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingWithFilesBL;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Analizuoju komandinės eilutės parametrus");

            var command = args[0];

            if (command == "--file")
            {
                var filePath = args[1];
                Console.WriteLine($"Pasirinkta viena byla {filePath}");
                ProcessSingleFile(filePath);
            }
            else if (command == "--dir")
            {
                var directoryPath = args[1];
                var fileType = args[2];
                Console.WriteLine($"Pasirinktas katalogas {directoryPath} ir bylos tipas {fileType} ");
                ProcessDirectory(directoryPath, fileType);
            }
            else
            {
                Console.WriteLine("Nezinomas kamandinės eilutės parametras {0}", command);
            }

            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }

        private static void ProcessSingleFile(string filePath)
        {
            var fileProcessor = new FileProcessor(filePath);
            fileProcessor.Process();
        }

        private static void ProcessDirectory(string directoryPath, string fileType)
        {
            switch (fileType)
            {
                case "TEXT":
                    string[] textFiles = Directory.GetFiles(directoryPath, "*.txt");
                    foreach (var textFilePath in textFiles)
                    {
                        Console.WriteLine(textFilePath);
                        //var fileProcessor = new FileProcessor(textFilePath);
                        //fileProcessor.Process();
                    }
                    break;
                default:
                    Console.WriteLine($"KLAIDA: nepalaikomas tipas {fileType} ");
                    return;
            }
        }
    }
}
