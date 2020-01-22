using System;

namespace GitActivityA
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] correctAnswers = new string[] { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
            string[] quizNumber = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            int score = 0;
            Console.WriteLine("Welcome to the .NET Core quiz!\nYou will have 10 questions to answer, all multiple choice\n\n");
            Console.WriteLine("1.) What is the system support by .NET Core?\nA.)Mac\nB.)Windows\nC.)Linux\nD.)None of the above\nPlease enter an answer\n");
            string answer1 = Console.ReadLine();
            if (correctAnswers[0] == answer1)
            {
                score++;
                answer1 = quizNumber[0];

            }
            else
            {
                answer1 = quizNumber[0];
            }
            Console.WriteLine("2.)Which cross-platform is supported by .Net Core?\nA.)WinForms\nB.)Universal Windows Platform\nC.)Windows Forms\nD.)NuGet");
            string answer2 = Console.ReadLine();
            if (correctAnswers[1] == answer2)
            {
                score++;
                answer2 = quizNumber[1];
            }
            else
            {
                answer2 = quizNumber[1];
            }
            Console.WriteLine("3.)What programming language does .Net Core fully support?\nA.)Python\nB.)Java\nC.)F#\nD.)Cobol");
            string answer3 = Console.ReadLine();
            if (correctAnswers[2]== answer3)
            {
                score++;
                answer3 = quizNumber[2];
            }
            else
            {
                answer3 = quizNumber[2];
            }
            




            }
        }
}