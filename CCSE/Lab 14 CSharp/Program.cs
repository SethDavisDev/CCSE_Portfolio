using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace _1322_Lab_14 {
    class Program {
        static void Main(string[] args) {

           //Reading the file and spliting it into 2 lists.
            List<string> words;
            // This is reading the file from the \Lab\bin\Debug\ location which it searches by default
            StreamReader sr = new StreamReader("FYE.html");
            

            words = MyFileReader.ScanList(sr);
			
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();

           
            MyFileReader.SplitList(words, list1, list2);

            //Setting up threads to do the replacing.
			
            HelperClass tws1 = new HelperClass(list1);
            HelperClass tws2 = new HelperClass(list2);
			
			int choice=1;
			do
			{
				Console.WriteLine("Choose the function you would like to run:\n1-No Thread Test\n2-Thread Test");
				choice = int.Parse(Console.ReadLine());
				switch (choice) {
					case 1:
                        foreach (var word in tws1.getList())
                        {
                            Console.WriteLine(word);
                        }
                        NoThreadTest(tws1, tws2);
                        foreach (var word in tws1.getList())
                        {
                            Console.WriteLine(word);
                        }
						break;
					case 2:
						ThreadTest(tws1, tws2);
						break;
				}
				Console.WriteLine("Enter 0 to exit any other number to continue");
				choice = int.Parse(Console.ReadLine());
				
			}while(choice !=0);

            sr.Close();
        }

        //Removes the html characters without using threads.
        private static void NoThreadTest(HelperClass tws1, HelperClass tws2)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            tws1.ReplaceHTML();
            tws2.ReplaceHTML();
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            //Formatting the time elapsed output
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine("Without Thread Runtime: " + elapsedTime);
        }

        //Removes the html characters using threads.
        private static void ThreadTest(HelperClass tws1, HelperClass tws2)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //Write your code to use threads here
            Thread thread1 = new Thread(tws1.ReplaceHTML);
            Thread thread2 = new Thread(tws2.ReplaceHTML);
            thread1.Start();
            thread2.Start();
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            //Formatting the time elapsed output
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine("Thread Runtime: " + elapsedTime);
        }
    }
}
