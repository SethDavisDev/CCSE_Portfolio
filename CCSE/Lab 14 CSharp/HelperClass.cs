using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1322_Lab_14 {
	
    class HelperClass {

        private List<string> words;

        public HelperClass(List<string> words) {
            this.words = words;
        }

        public List<string> getList() {
            return words;
        }

        //function which replaces <>
        public void ReplaceHTML() {

            for (int i = 0; i < words.Count; i++)
            {
                while (words[i].Contains("<") || words[i].Contains(">")) {
                    int startIndex = words[i].IndexOf('<');
                    int endIndex = words[i].IndexOf('>');
                    if (startIndex == -1 || (endIndex < startIndex && endIndex != -1))
                    {
                        //no < symbol
                        words[i] = words[i].Remove(0, endIndex + 1);
                        continue;
                    }
                    else if (endIndex == -1)
                    {
                        words[i] = words[i].Remove(startIndex);
                    }
                    else {
                        words[i] = words[i].Remove(startIndex, ((endIndex - startIndex) + 1));
                        words[i] = words[i].Insert(startIndex , " ");
                    }
                    
                    
                }
                
                

            }

        }

    }
}
