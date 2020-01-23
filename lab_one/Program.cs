using System;

namespace GitActivityA
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* Sets up my main global variables to keep track of the User's score and answers */
            string[] correctAnswers =  { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
            string[] correctAnswersLower = { "b", "b", "c", "a", "d", "a", "a", "c", "d", "a" };
            string[] quizNumber = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            int score = 0;
            int incorrectAnswers = 0;
            while (score < 7) {
                    /* Welcome text */
                    Console.WriteLine("\n.NET Core quiz.\nYou will have 10 questions to answer, all multiple choice.\n");
                    /*Question 1 with if else statements to add score and get answer or just get answer if wrong (this is repeated for every question)*/
                    Console.WriteLine("1.)");
                    string answer1 = Console.ReadLine();
                    if (correctAnswers[0] == answer1)
                    {
                        score++;
                        quizNumber[0] = "";

                    }
                    else if (correctAnswersLower[0] == answer1)
                    {
                        score++;
                        quizNumber[0] = "";
                    }
                    else
                    {
                        incorrectAnswers++;
                        quizNumber[0] = "1,";
                    }
                    Console.WriteLine("2.)Which cross-platform is supported by .Net Core?\nA.)WinForms\nB.)Universal Windows Platform\nC.)Windows Forms\nD.)NuGet\n");
                    string answer2 = Console.ReadLine();
                    if (correctAnswers[1] == answer2)
                    {
                        score++;
                        quizNumber[1] = "";
                    }
                    else if (correctAnswersLower[1] == answer2)
                    {
                        score++;
                        quizNumber[1] = "";
                    }
                    else
                    {
                        incorrectAnswers++;
                        quizNumber[1] = "2,";
                    }

                    Console.WriteLine("3.)What programming language does .Net Core fully support?\nA.)Python\nB.)Java\nC.)F#\nD.)Cobol\n");
                    string answer3 = Console.ReadLine();
                    if (correctAnswers[2] == answer3)
                    {
                        score++;
                        quizNumber[2] = "";
                    }
                    else if (correctAnswersLower[2] == answer3)
                    {
                        score++;
                        quizNumber[2] = "";
                    }
                    else
                    {
                        incorrectAnswers++;
                        quizNumber[2] = "3,";
                    }
                    Console.WriteLine("4.)What company made .NET Core?\na.)Microsoft\nb.)Apple\nc.)Google\nNone of the above\n");
                    string answer4 = Console.ReadLine();
                    if (correctAnswers[3] == answer4)
                    {
                        score++;
                        quizNumber[3] = "";
                    }
                    else if (correctAnswersLower[3] == answer4)
                    {
                        score++;
                        quizNumber[3] = "";
                    }
                    else
                    {
                        incorrectAnswers++;
                        quizNumber[3] = "4,";
                    }
                    Console.WriteLine("5.)Which operating system is supported by .NET Core?\nA.)Mac\nB.)Windows\nC.)Linux\nD.)All of the above\n");
                    string answer5 = Console.ReadLine();
                    if (correctAnswers[4] == answer5)
                    {
                        score++;
                        quizNumber[4] = "";
                    }
                    else if (correctAnswersLower[4] == answer5)
                    {
                        score++;
                        quizNumber[4] = "";
                    }
                    else
                    {
                        incorrectAnswers++;
                        quizNumber[4] = "5,";
                    }
                    Console.WriteLine("6.)");
                    string answer6 = Console.ReadLine();
                    if (correctAnswers[5] == answer6)
                    {
                        score++;
                        quizNumber[5] = "";
                    }
                    else if (correctAnswersLower[5] == answer6)
                    {
                        score++;
                        quizNumber[5] = "";
                    }
                    else
                    {
                        incorrectAnswers++;
                        quizNumber[5] = "6,";
                    }
                    Console.WriteLine("7.)");
                    string answer7 = Console.ReadLine();
                    if (correctAnswers[6] == answer7)
                    {
                        score++;
                        quizNumber[6] = "";
                    }
                    else if (correctAnswersLower[6] == answer7)
                    {
                        score++;
                        quizNumber[6] = "";
                    }
                    else
                    {
                        incorrectAnswers++;
                        quizNumber[6] = "7,";
                    }
                    Console.WriteLine("8.)");
                    string answer8 = Console.ReadLine();
                    if (correctAnswers[7] == answer8)
                    {
                        score++;
                        quizNumber[7] = "";
                    }
                    else if (correctAnswersLower[7] == answer8)
                    {
                        score++;
                        quizNumber[7] = "";
                    }
                    else
                    {
                        incorrectAnswers++;
                        quizNumber[7] = "8,";
                    }
                    Console.WriteLine("9.)");
                    string answer9 = Console.ReadLine();
                    if (correctAnswers[8] == answer9)
                    {
                        score++;
                        quizNumber[8] = "";
                    }
                    else if (correctAnswersLower[8] == answer9)
                    {
                        score++;
                        quizNumber[8] = "";
                    }
                    else
                    {
                        incorrectAnswers++;
                        quizNumber[8] = "9,";
                    }
                    Console.WriteLine("10.)");
                    string answer10 = Console.ReadLine();
                    if (correctAnswers[9] == answer10)
                    {
                        score++;
                        quizNumber[9] = "";
                    }
                    else if (correctAnswersLower[9] == answer10)
                    {
                        score++;
                        quizNumber[9] = "";
                    }
                else
                    {
                        incorrectAnswers++;
                    }
                if (score >= 7)
                    {
                        Console.WriteLine("Congrats, you passed!\n" + "Number of questions correct: " + score + "\nNumber of questions incorrect: " + incorrectAnswers + "\nThe questions you got wrong: " + quizNumber[0] + " " + quizNumber[1] + " " + quizNumber[2] + " " + quizNumber[3] + " " + quizNumber[4] + " " + quizNumber[5] + " " + quizNumber[6] + " " + quizNumber[7] + " " + quizNumber[8] + " " + quizNumber[9]);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you failed!!\n" + "Number of questions correct: " + score + "\nNumber of questions incorrect: " + incorrectAnswers + "\nThe questions you got wrong: " + quizNumber[0] + " " + quizNumber[1] + " " + quizNumber[2] + " " + quizNumber[3] + " " + quizNumber[4] + " " + quizNumber[5] + " " + quizNumber[6] + " " + quizNumber[7] + " " + quizNumber[8] + " " + quizNumber[9]+"\nPlease try again.");
                    }
                } 



        }
        }
}