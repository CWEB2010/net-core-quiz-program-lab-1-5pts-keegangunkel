using System;
using System.Collections;

namespace GitActivityA
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            // Setting up arrays to keep track of wrong answers and questions wrong
            string[] correctAnswers =  { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
            string[] correctAnswersLower = { "b", "b", "c", "a", "d", "a", "a", "c", "d", "a" };
            var wrongAnswers = new ArrayList();
            var questionsWrong = new ArrayList();
            // Sets up my main local variables to keep track of the User's score and answers

            int score = 0;
            int incorrectAnswers = 0;
            while (true)
           {
                // Welcome text 
                Console.WriteLine("\n.NET Core quiz.\nYou will have 10 questions to answer, all multiple choice.\n");
                // Questions 1
                Console.WriteLine("1.)Which open source platform is compatibile with .NET Core?\na.)Arduino\nb.)Xamarin\nc.)Solaris\nd.)Chrome OS\n");
                string answer1 = Console.ReadLine();
                Console.WriteLine("");
                answersAndQuestions(correctAnswers[0], correctAnswersLower[0], answer1, wrongAnswers, questionsWrong, "1", score, incorrectAnswers);
                // Question 2
                Console.WriteLine("2.)Which cross-platform is supported by .Net Core?\nA.)WinForms\nB.)Universal Windows Platform\nC.)Windows Forms\nD.)NuGet\n");
                string answer2 = Console.ReadLine();
                Console.WriteLine("");
                answersAndQuestions(correctAnswers[1], correctAnswersLower[1], answer2, wrongAnswers, questionsWrong, "2", score, incorrectAnswers);
                // Question 3
                Console.WriteLine("3.)What programming language does .Net Core fully support?\nA.)Python\nB.)Java\nC.)F#\nD.)Cobol\n");
                string answer3 = Console.ReadLine();
                Console.WriteLine("");
                answersAndQuestions(correctAnswers[2], correctAnswersLower[2], answer3, wrongAnswers, questionsWrong, "3", score, incorrectAnswers);
                // Question 4
                Console.WriteLine("4.)What company made .NET Core?\na.)Microsoft\nb.)Apple\nc.)Google\nNone of the above\n");
                string answer4 = Console.ReadLine();
                Console.WriteLine("");
                answersAndQuestions(correctAnswers[3], correctAnswersLower[3], answer4, wrongAnswers, questionsWrong, "4", score, incorrectAnswers);
                // Question 5
                Console.WriteLine("5.)Which operating system is supported by .NET Core?\nA.)Mac\nB.)Windows\nC.)Linux\nD.)All of the above\n");
                string answer5 = Console.ReadLine();
                Console.WriteLine("");
                answersAndQuestions(correctAnswers[4], correctAnswersLower[4], answer5, wrongAnswers, questionsWrong, "5", score, incorrectAnswers);
                // Question 6
                Console.WriteLine("6.)Which open source license does .NET Core use?\na.)Apache 2\nb.)BSD 3-Clause\nc.)Mozilla Public License\nd.)Ecplise Public License\n");
                string answer6 = Console.ReadLine();
                Console.WriteLine("");
                answersAndQuestions(correctAnswers[5], correctAnswersLower[5], answer6, wrongAnswers, questionsWrong, "6", score, incorrectAnswers);
                // Question 7
                Console.WriteLine("7.)What year did .NET Core come out?\na.)2016\nb.)1998\nc.)2006\nd.)1987\n");
                string answer7 = Console.ReadLine();
                Console.WriteLine("");
                answersAndQuestions(correctAnswers[6], correctAnswersLower[6], answer7, wrongAnswers, questionsWrong, "7", score, incorrectAnswers);
                // Question 8
                Console.WriteLine("8.)Currently, how many versions of .NET Core have come out?\na.)3\nb.)9\nc.)7\nd.)12\n");
                string answer8 = Console.ReadLine();
                Console.WriteLine("");
                answersAndQuestions(correctAnswers[7], correctAnswersLower[7], answer8, wrongAnswers, questionsWrong, "8", score, incorrectAnswers);
                // Question 9 
                Console.WriteLine("9.)What are the main differences between .NET Core and .NET Framework\na.)APIs\nb.)Subsystems\nc.)Platforms\nd.)All of the above\n");
                string answer9 = Console.ReadLine();
                Console.WriteLine("");
                answersAndQuestions(correctAnswers[8], correctAnswersLower[8], answer9, wrongAnswers, questionsWrong, "9", score, incorrectAnswers);
                // Questions 10
                Console.WriteLine("10.)Which integrated learning environment(IDE)supports .NET Core?\na.)Visual Studio Code\nb.)Eclipse\nc.)Netbeans\nd.)intelliJ idea\n");
                string answer10 = Console.ReadLine();
                Console.WriteLine("");
                answersAndQuestions(correctAnswers[9], correctAnswersLower[9], answer10, wrongAnswers, questionsWrong, "10", score, incorrectAnswers);
                // End if else statments to tell the user how many they got right and wrong and what questions they got wrong.

                if (score == 10)
                {
                    Console.WriteLine("Congrats, you aced it!\n" + "Number of questions correct: " + score + "\nNumber of questions incorrect: " + incorrectAnswers + "\nThe questions you got wrong: none!");
                }
                else if (score >= 7)
                {
                    Console.WriteLine("Congrats, you passed!\n" + "Number of questions correct: " + score + "\nNumber of questions incorrect: " + incorrectAnswers);
                    Console.WriteLine("Questions you got wrong: ");
                
                // For each statement to print out each question answered wrong and what you answered.
                Console.ForegroundColor = ConsoleColor.Red;
                foreach (string i in questionsWrong)
                {
                    Console.Write(i + "\t");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nYour answers: ");
                Console.ForegroundColor = ConsoleColor.Red;
                    foreach (string j in wrongAnswers)
                {
                    Console.Write(j + "\t");
                }
            }
                else
                {
                    Console.WriteLine("Sorry, you failed!!\n" + "Number of questions correct: " + score + "\nNumber of questions incorrect: " + incorrectAnswers);
                    Console.WriteLine("Questions you got wrong: ");
                    // For each statement to print out each question answered wrong and what you answered
                    Console.ForegroundColor = ConsoleColor.Red;
                    foreach (string i in questionsWrong)
                    {
                        Console.Write(i + "\t");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nYour answers: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    foreach (string j in wrongAnswers)
                    {
                        Console.Write(j + "\t");
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                // Decision logic for if the user wants to try again or not
                Console.WriteLine("\nWould you like to take the quiz again? Y/N");
                string yesOrNoDecision = Console.ReadLine();
                if (yesOrNoDecision == "Y" || yesOrNoDecision == "y")
                {
                    goto Start;
                    
                }
                else if (yesOrNoDecision == "N" || yesOrNoDecision == "n")
                {
                   break;
                }
                else
                {
                    Console.WriteLine("Error closing program");
                    break;
                }
            }
            
            

                

            


        }
        // Modularized code
            public static void answersAndQuestions(string correctAnswersArray, string correctAnswersArrayLower, string answers, ArrayList wrongAnswersArray, ArrayList questionsWrongArray, string questionNum, int score, int incorrectScore )
        {
            if (correctAnswersArray == answers)
            {
                score++;
            }
            else if (correctAnswersArrayLower == answers)
            {
                score++;
            }
            else
            {
                incorrectScore++;
                questionsWrongArray.Add(questionNum);
                wrongAnswersArray.Add(answers);
            }
        }
        }
}