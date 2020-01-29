using System;
using System.Collections;

namespace GitActivityA
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            /* Sets up my main global variables to keep track of the User's score and answers */
            string[] correctAnswers =  { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
            string[] correctAnswersLower = { "b", "b", "c", "a", "d", "a", "a", "c", "d", "a" };
            var wrongAnswers = new ArrayList();
            var questionsWrong = new ArrayList();
            int score = 0;
            int incorrectAnswers = 0;
            while (true)
           {
                /* Welcome text */
                Console.WriteLine("\n.NET Core quiz.\nYou will have 10 questions to answer, all multiple choice.\n");
                /*Question 1 with if else statements to add score and get answer (in lower or upper case) or add incorrect score and mark the question if wrong (this is repeated for every question)*/
                Console.WriteLine("1.)Which open source platform is compatibile with .NET Core?\na.)Arduino\nb.)Xamarin\nc.)Solaris\nd.)Chrome OS\n");
                string answer1 = Console.ReadLine();
                Console.WriteLine("");
                if (correctAnswers[0] == answer1)
                {
                    score++;
                }
                else if (correctAnswersLower[0] == answer1)
                {
                    score++;
                }
                else
                {
                    incorrectAnswers++;
                    questionsWrong.Add("1");
                    wrongAnswers.Add(answer1);
                }
                Console.WriteLine("2.)Which cross-platform is supported by .Net Core?\nA.)WinForms\nB.)Universal Windows Platform\nC.)Windows Forms\nD.)NuGet\n");
                string answer2 = Console.ReadLine();
                Console.WriteLine("");
                if (correctAnswers[1] == answer2)
                {
                    score++;
                }
                else if (correctAnswersLower[1] == answer2)
                {
                    score++;
                }
                else
                {
                    incorrectAnswers++;
                    questionsWrong.Add("2");
                    wrongAnswers.Add(answer2);
                }

                Console.WriteLine("3.)What programming language does .Net Core fully support?\nA.)Python\nB.)Java\nC.)F#\nD.)Cobol\n");
                string answer3 = Console.ReadLine();
                Console.WriteLine("");
                if (correctAnswers[2] == answer3)
                {
                    score++;
                }
                else if (correctAnswersLower[2] == answer3)
                {
                    score++;
                }
                else
                {
                    incorrectAnswers++;
                    questionsWrong.Add("3");
                    wrongAnswers.Add(answer3);
                }
                Console.WriteLine("4.)What company made .NET Core?\na.)Microsoft\nb.)Apple\nc.)Google\nNone of the above\n");
                string answer4 = Console.ReadLine();
                Console.WriteLine("");
                if (correctAnswers[3] == answer4)
                {
                    score++;
                }
                else if (correctAnswersLower[3] == answer4)
                {
                    score++;
                }
                else
                {
                    incorrectAnswers++;
                    questionsWrong.Add("4");
                    wrongAnswers.Add(answer4);
                }
                Console.WriteLine("5.)Which operating system is supported by .NET Core?\nA.)Mac\nB.)Windows\nC.)Linux\nD.)All of the above\n");
                string answer5 = Console.ReadLine();
                Console.WriteLine("");
                if (correctAnswers[4] == answer5)
                {
                    score++;
                }
                else if (correctAnswersLower[4] == answer5)
                {
                    score++;
                }
                else
                {
                    incorrectAnswers++;
                    questionsWrong.Add("5");
                    wrongAnswers.Add(answer5);
                }
                Console.WriteLine("6.)Which open source license does .NET Core use?\na.)Apache 2\nb.)BSD 3-Clause\nc.)Mozilla Public License\nd.)Ecplise Public License\n");
                string answer6 = Console.ReadLine();
                Console.WriteLine("");
                if (correctAnswers[5] == answer6)
                {
                    score++;
                }
                else if (correctAnswersLower[5] == answer6)
                {
                    score++;
                }
                else
                {
                    incorrectAnswers++;
                    questionsWrong.Add("6");
                    wrongAnswers.Add(answer6);
                }
                Console.WriteLine("7.)What year did .NET Core come out?\na.)2016\nb.)1998\nc.)2006\nd.)1987\n");
                string answer7 = Console.ReadLine();
                Console.WriteLine("");
                if (correctAnswers[6] == answer7)
                {
                    score++;
                }
                else if (correctAnswersLower[6] == answer7)
                {
                    score++;
                }
                else
                {
                    incorrectAnswers++;
                    questionsWrong.Add("7");
                    wrongAnswers.Add(answer7);
                }
                Console.WriteLine("8.)Currently, how many versions of .NET Core have come out?\na.)3\nb.)9\nc.)7\nd.)12\n");
                string answer8 = Console.ReadLine();
                Console.WriteLine("");
                if (correctAnswers[7] == answer8)
                {
                    score++;
                }
                else if (correctAnswersLower[7] == answer8)
                {
                    score++;
                }
                else
                {
                    incorrectAnswers++;
                    questionsWrong.Add("8");
                    wrongAnswers.Add(answer8);
                }
                Console.WriteLine("9.)What are the main differences between .NET Core and .NET Framework\na.)APIs\nb.)Subsystems\nc.)Platforms\nd.)All of the above\n");
                string answer9 = Console.ReadLine();
                Console.WriteLine("");
                if (correctAnswers[8] == answer9)
                {
                    score++;
                }
                else if (correctAnswersLower[8] == answer9)
                {
                    score++;
                }
                else
                {
                    incorrectAnswers++;
                    questionsWrong.Add("9");
                    wrongAnswers.Add(answer9);
                }
                Console.WriteLine("10.)Which integrated learning environment(IDE)supports .NET Core?\na.)Visual Studio Code\nb.)Eclipse\nc.)Netbeans\nd.)intelliJ idea\n");
                string answer10 = Console.ReadLine();
                Console.WriteLine("");
                if (correctAnswers[9] == answer10)
                {
                    score++;
                }
                else if (correctAnswersLower[9] == answer10)
                {
                    score++;
                }
                else
                {
                    incorrectAnswers++;
                    questionsWrong.Add("10");
                    wrongAnswers.Add(answer10);
                }
                /* End if else statments to tell the user how many they got right and wrong and what questions they got wrong.*/

                if (score == 10)
                {
                    Console.WriteLine("Congrats, you aced it!\n" + "Number of questions correct: " + score + "\nNumber of questions incorrect: " + incorrectAnswers + "\nThe questions you got wrong: none!");
                }
                else if (score >= 7)
                {
                    Console.WriteLine("Congrats, you passed!\n" + "Number of questions correct: " + score + "\nNumber of questions incorrect: " + incorrectAnswers);
                    Console.WriteLine("Questions you got wrong: ");
                // for each statement to print out each question answered wrong and what you answered
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
                // for each statement to print out each question answered wrong and what you answered
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
        }
}