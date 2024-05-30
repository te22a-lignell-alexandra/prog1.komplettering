// Flera sorters loopar + tryparse

using System.ComponentModel;

int round = 1;
List<int> NrOfGuesses = new();

while (true)
{
    int nrOfGuesses = 0;
    Random random = new Random();
    int number = random.Next(0,10);

    Console.WriteLine("\nGuess a number between 0 and 10");

    while (true)
        {
            string guess = Console.ReadLine();
            int intGuess;
            bool validGuess = int.TryParse(guess, out intGuess);

            if (intGuess == number)
            {
                nrOfGuesses++;
                Console.WriteLine("Correct!");
                break;
            }

            else if (validGuess == true && intGuess < number) Console.Write("Too low. ");

            else if (intGuess > number) Console.Write("Too high. ");

            else if (validGuess == false) Console.Write("No, a number. ");



            Console.WriteLine("Try again");
            nrOfGuesses++;
        }
    NrOfGuesses.Add(nrOfGuesses);

    Console.WriteLine("\nPlay another round?");
    string answer = Console.ReadLine().ToLower();

    while (answer != "yes" && answer != "no")
        {
            Console.WriteLine("\nAnswer yes or no.");
            answer = Console.ReadLine().ToLower();
        }
    if (answer == "yes")
        {
            round++;
            Console.WriteLine($"\nRound {round}\n");
        }
    if (answer == "no")
        {
            Console.WriteLine("\nFinal score");
            Console.WriteLine("Number of guesses per round:\n");

            for (int i = 0; i < NrOfGuesses.Count; i++)
            {
                Console.WriteLine($"Round {i+1}: " + NrOfGuesses[i] + " guesses");
            }
            Console.ReadLine();

            break;
        }
}