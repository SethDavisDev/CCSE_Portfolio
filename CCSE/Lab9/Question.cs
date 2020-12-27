using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Question
    {
        string question;
        string answer;
        string difficulty;

        public Question(string q, string a, string d) {
            question = q;
            answer = a;
            difficulty = d;
        }

        public string getQuestion() {
            return question;
        }
        public void setQuestion(string que) {
            question = que;
        }

        public string getAnswer() {
            return answer;
        }
        public void setAnswer(string ans) {
            answer = ans;
        }
    }
}
