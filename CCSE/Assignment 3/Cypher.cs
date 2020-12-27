using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Cypher
    {
        string original;
        string encrypted;
        string decrypted;

        public Cypher() : this("cypher") {
        }
        public Cypher(string message) {
            original = message; 
        }


        public void cypherMethod() {
            StringBuilder firstHalf = new StringBuilder();
            StringBuilder secondHalf = new StringBuilder();
            for (int i = 0; i < original.Length; i++){
                if (i % 2 == 0)
                {
                    firstHalf.Append(original[i]);
                }
                else {
                    secondHalf.Append(original[i]);
                }
            }
            firstHalf.Append(secondHalf.ToString());
            encrypted = firstHalf.ToString();
        }
        public void reverseMethod() {
            StringBuilder sb1 = new StringBuilder(15);
            StringBuilder sb2 = new StringBuilder(15);
            sb1.Append(encrypted);
            sb2.Append(encrypted);
            sb1.Remove(sb1.Length - (sb1.Length / 2), sb1.Length / 2);
            sb2.Remove(0, sb1.Length);
            
            for (int i = 1; i <= sb1.Length; i +=2)
            {
                sb1.Insert(i, sb2[0]);
                sb2.Remove(0, 1);
                if (sb2.Length <= 0) break;
            }
           
            decrypted = sb1.ToString();
            
        }

        public string getOriginal() {
            return original;
        }

        public void setOriginal(string message) {
            original = message;
        }

        public string getEncrypted() {
            return encrypted;
        }
        public string getDecrypted() {
            return decrypted;
        }

        public string toString() {
            return String.Format("Original: {0} Encrypted: {1} Decrypted: {2} ",original, encrypted, decrypted);
        }
    }
}
