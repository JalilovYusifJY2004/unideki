using System.Globalization;
using yaxsi_elyire_m.quiz;

namespace yaxsi_elyire_m
{
    internal class Program
    {
        static List<Quiz> quizzes = new List<Quiz>();
        static void Main(string[] args)
        {




            Console.WriteLine("");
            Console.WriteLine("Menyu");
            Console.WriteLine("1. create new quiz");
            Console.WriteLine("2.Solve a quiz");
            Console.WriteLine("3.show quizes");
            Console.WriteLine("0.quit");



            int input = int.Parse(Console.ReadLine());

            while (true)
            {
                switch (input)
                {
                    case 1:
                      CreateNewQuiz();
                        break;
                    case 2:
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    case 0:
                        Console.WriteLine();
                        break;


                    case 10:
                        Console.WriteLine("Quizin adini daxil edin");
                        break;
                    case 11:
                        Console.WriteLine("Terkibinde nece sual var");
                        break;
                    case 12:
                        Console.WriteLine("suallari daxil ediirk");
                        break;
                    default:
                        Console.WriteLine("neyse sehvlik var");
                        break;




                }
            }
            static void CreateNewQuiz()
            {
                Console.WriteLine("quiz adini daxil edin");
                string name = Console.ReadLine();
                Console.WriteLine("terkibinde nece sual olduqunu qeyd edin");
                int numberOfQuestions = int.Parse(Console.ReadLine());
                List<Question> questionList = new();
                
                for (int i = 0; i < numberOfQuestions; i++)
                {
                    Question question = new Question();
                    Console.Write(i + 1);
                    question.Text = Console.ReadLine();
                    question.Answers = new List<string>();
                   
                    for (int j = 0; j <= 4; j++)
                    {
                        question.Answers.Add(Console.ReadLine());
                        Console.WriteLine("duzgun variantlati qeyd ed");
                        Console.WriteLine("duzgun cavab qeyd ed ");

                        question.CorrectAnswerindex = int.Parse(Console.ReadLine());
                        questionList.Add(question);
                        quizzes.Add(quizzes[i]);
                        Console.WriteLine("quiz yarandi");
                    }
                }
                static void Solvequiz()
                {

                }
            }

        }

    }
}
