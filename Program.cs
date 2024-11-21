using System;
using System.Collections.Generic;
using System.IO;

namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("question.txt");
             
            List <string> questions = new List<string>();

            List <string> answers = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                if (i % 4 == 0)
                {
                    questions.Add(text[i]);
                }
                else
                {
                    answers.Add(text[i]);
                }
            }

            int score = 0;
            int questionIndex = 0;
            int answerIndex = 0;

            while (questionIndex < questions.Count)
            {
                Console.WriteLine(questions[questionIndex]);
                questionIndex++;

                int correctAnswerIndex = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (answers[answerIndex].StartsWith(">"))
                        correctAnswerIndex = i + 1;
                    
                    Console.WriteLine(i + 1 + " . " + answers[answerIndex].Replace(">" , ""));
                    answerIndex++;
                }

                int answer = Convert.ToInt32(Console.ReadLine());

                if (correctAnswerIndex == answer)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }

            Console.WriteLine("the quiz is end , your score is :" + score);
            
            Console.ReadKey();
        } 
    }
}
