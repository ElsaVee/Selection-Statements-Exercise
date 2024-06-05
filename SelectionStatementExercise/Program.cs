using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            var faveNumber = 8;
            Console.WriteLine("Try to guess my favorite number");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput < faveNumber)
            {
                Console.WriteLine("Too Low, think higher!");
            }
            else if (userInput > faveNumber)
            {
                Console.WriteLine("Slow your Roll, too high!");
            }
            else
            {
                Console.WriteLine("You got it!");

            }

            //Exercise 2

            Console.WriteLine("Hello, what is your favorite school subject?");
            string userSubject = Console.ReadLine();

            switch (userSubject.ToLower())
            {
                case "reading":
                    Console.WriteLine($"{userSubject}? Ahh, a bookworm?");
                    break;

                case "science":
                    Console.WriteLine($"{userSubject}? To infinity and beyond!");
                    break;

                case "math":
                    Console.WriteLine($"{userSubject}? Please excuse my dear Aunt Sally");
                    break;

                case "history":
                    Console.WriteLine($"{userSubject}? I remember a time when ...zzzz");
                    break;

                case "art":
                    Console.WriteLine($"{userSubject}? Yellow and blue make green?");
                    break;

                default:
                    Console.WriteLine($"{userSubject}, is that something new?");
                    break;
            }
        }
    }
}
