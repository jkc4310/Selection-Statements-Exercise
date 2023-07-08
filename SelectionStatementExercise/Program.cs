namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("welcome to the number guessing game!");
            Console.WriteLine("Try your best to guess the right number!");
            Console.WriteLine("what would you like the upper range of the number to be?");

            var userResponse = Console.ReadLine();
            var upperLimit = int.Parse(userResponse);

            var random = new Random();
            var number = random.Next(1, upperLimit);

            Console.WriteLine("Input your guess!");

            var guess = int.Parse(Console.ReadLine());

            if (guess < number)
            {
                Console.WriteLine("Too Low!");
            }

            else if (guess > number)
            {
                Console.WriteLine("Too High!");
            }

            else
            {
                Console.WriteLine("You Guessed It!");
            }

        }



    }
}
