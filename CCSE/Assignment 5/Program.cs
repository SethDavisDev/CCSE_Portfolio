using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath;
            string text;
            string generalInput = "n";
            string savepPath = "";
            Console.WriteLine("Please enter the location and name of the file you want: ");
            filePath = Console.ReadLine();
            while(!File.Exists(filePath)) {
                Console.WriteLine("That file name or location was incorrect. Please enter another file name and location:");
                filePath = Console.ReadLine();
            }
            //FileStream fs = File.Open(filePath, FileMode.Open);
            StreamReader streamReader = new StreamReader(filePath);
            using (streamReader) {
                text = streamReader.ReadToEnd();
            }
            while (generalInput != "y")
            {
                Console.WriteLine("What would you like to name the copy of this file as: ");
                string fileName = Console.ReadLine();
                Console.WriteLine("where would you like to save the copy to");
                string destination = Console.ReadLine();
                savepPath = destination + "\\" + fileName;
                if (File.Exists(savepPath))
                {
                    Console.WriteLine("There already exists a file by that name in that location. Would you like to OverWrite it? (y/n)");
                    generalInput = Console.ReadLine();
                    if (generalInput == "y") Console.WriteLine("The file will be overwritten");
                }
                else {
                    generalInput = "y";
                }
            }

            StreamWriter streamWriter = new StreamWriter(savepPath);
            using (streamWriter) {
                streamWriter.Write(text);
            }

            Console.WriteLine("File copied from {0} and saved to {1}", filePath, savepPath);


            Console.ReadKey(); 
        }
    }
}
