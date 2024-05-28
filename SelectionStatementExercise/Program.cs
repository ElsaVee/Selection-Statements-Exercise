using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
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

        }   
    }
}
