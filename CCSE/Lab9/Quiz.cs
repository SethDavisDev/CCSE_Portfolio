using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab9
{
    class Quiz
    {
        ArrayList quiz =  new ArrayList();

        string[] studentAnswers;
        public Quiz(int numQuestions) {
            quiz.Capacity = numQuestions;
        }

        public void addQuestion(string que, string ans, string dif) {
            Question q = new Question(que, ans, dif);
            quiz.Add(q);
        }

        public void removeQuestion(int questionNum) {
            quiz.RemoveAt(questionNum);
        }

        // this will either change the question or answer of a Question object, if you want to change 
        //both then add a new question and remove an old one.
        public void modifyQuestion(int questionNum, string newInput, bool changeAnswer) {
            Question q = (Question) quiz[questionNum];
            if (changeAnswer)
            {
                q.setAnswer(newInput);
            }
            else
            {
                q.setQuestion(newInput);
            }
            
            quiz[questionNum] = q;
        }

        public void giveQuiz() {
            studentAnswers = new string[quiz.Capacity];
            int i = 0;
            foreach (Question q in quiz) {
                Console.WriteLine((i + 1)+": " + q.getQuestion());
                studentAnswers[i] = Console.ReadLine();
                Console.Write("press any button to continue");
                Console.ReadKey();
                Console.Clear();
                i++;
            }
        }


        public string getQuestions() {
            StringBuilder sb = new StringBuilder();
            int i = 1;
            foreach (Question q in quiz) {
                sb.AppendLine("Question " + (i++) + ": " + q.getQuestion());
                
            }
            return sb.ToString();
        }

        public string resultsPaper() {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            foreach (Question q in quiz)
            {
                sb.AppendLine("Question " + (i + 1) + ": " + q.getQuestion()+", your response: "+ studentAnswers[i] + ", correct response: " + q.getAnswer());
                i++;
            }
            return sb.ToString();
        }

    }
}
