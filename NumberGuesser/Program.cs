using System;

// Namespace
namespace NumberGuesser
{
	// Main Class
	class Program
	{
		// Entry Point Method
		static void Main(string[] args)
		{
				GetAppInfo();

				GreetUser();

			while (true) {
				// Init random number
				Random random = new Random();

				int correctNumber = random.Next(1, 10);

				// Init guess var
				int guess = 0;

				// Ask user for number
				Console.WriteLine("Trouvez le bon chiffre entre 1 et 10");

				while (guess != correctNumber) {
					// Get users input
					string input = Console.ReadLine();

					// Print error message
					if (!int.TryParse(input, out guess)) {

						PrintColorMessage(ConsoleColor.Red, "Désolé, veuillez entrer un nombre");

						// Keep going in the loop while
						continue;
					}

					// Cast to int and put in guess
					guess = Int32.Parse(input);

					// Match guess to correct number
					if (guess != correctNumber)
					{
						PrintColorMessage(ConsoleColor.Red, "Réessayez encore...");
					}

				}

				// Output success message
				PrintColorMessage(ConsoleColor.DarkYellow, "BRAVO !");

				// Ask to play again
				Console.WriteLine("Voulez vous encore jouer? [O ou N]");

				string answer = Console.ReadLine().ToUpper();

				if (answer == "O")
				{
					continue;
				}
				else if (answer == "N")
				{
					return;
				}
				else
				{
					return;
				}
			}
		}

		// Get app info
		static void GetAppInfo() {
		
			string appName = "Number Guesser";
			string appVersion = "1.0.0";
			string appAuthor = "Mydrie Pénot";

			Console.ForegroundColor = ConsoleColor.Green;

			Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

			Console.ResetColor();
		}


		// Ask users name and greet
		static void GreetUser() {
			
			Console.WriteLine("Quel est votre prénom ?");

			string inputName = Console.ReadLine();

			Console.WriteLine("Salut {0}, jouons !", inputName);
		}

		static void PrintColorMessage(ConsoleColor color, string message) {
			// Change text color
			Console.ForegroundColor = color;

			// Tell user it's not a number
			Console.WriteLine(message);

			// Reset text color
			Console.ResetColor();
		}

	}
}
