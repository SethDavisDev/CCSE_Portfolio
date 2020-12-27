//Name: Seth Davis
//Class: CSE 1322L
//Section: 03 C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class QuizTime
    {
        static void Main(string[] args)
        {
            int optionNum = 0;
            Quiz q1 = new Quiz(5);
            while (optionNum != 6)
            {
                Console.WriteLine("1. Add Question, 2. Display Questions, 3. Delete question, 4. try quiz, 5. show question and answer sheet");
                Console.WriteLine("Enter a number for the option you want (1-5) (6 to Exit):");
                optionNum = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (optionNum)
                {
                    case 1:
                        Console.WriteLine("Enter the question statement:");
                        string que = Console.ReadLine();
                        Console.WriteLine("Enter the answer statement:");
                        string ans = Console.ReadLine();
                        Console.WriteLine("Enter the difficulty level:");
                        string dif = Console.ReadLine();
                        q1.addQuestion(que, ans, dif);
                        break;
                    case 2:
                        Console.WriteLine(q1.getQuestions());
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("enter the number of the question you want to delete:");
                        int qNum = Int32.Parse(Console.ReadLine()) - 1;
                        q1.removeQuestion(qNum);
                        break;
                    case 4:
                        q1.giveQuiz();
                        break;
                    case 5:
                        Console.WriteLine(q1.resultsPaper());
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
            Console.ReadKey();
        }

    }
}
