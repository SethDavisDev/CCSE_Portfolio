
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1322_Lab_14 {
    static class MyFileReader {

        //Reads a file and stores the contents in a list
        public static List<string> ScanList(StreamReader sr) {

            List<string> myList = new List<string>();

            while (!sr.EndOfStream) {
                myList.Add(sr.ReadLine());
            }

            return myList;
        }

        //Splits the contents of a list into two
        public static void SplitList(List<string> words, List<string> list1, List<string> list2) {

            bool latter = false;
            for (int i = 0; i < words.Count; i++) {
                if (i == words.Count / 2) {
                    latter = true;
                }

                if (latter) {
                    list2.Add(words[i]);
                } else {
                    list1.Add(words[i]);
                }

            }

        }

    }
}
