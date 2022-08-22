using System;

Console.WriteLine("Choose a difficulty level");
Console.WriteLine("(E)asy, (M)edium, or(H)ard.");

string difficulty = Console.ReadLine().ToLower();
int attempts = 0;
bool cheater = false;

switch (difficulty)
{
    case "e": { Console.WriteLine("Easy mode selected. (8) Tries"); attempts = 8; break; }
    case "m": { Console.WriteLine("Medium mode selected. (6) Tries"); attempts = 6; break; }
    case "h": { Console.WriteLine("Hard mode selected. (4) Tries"); attempts = 4; break; }
    case "0":
        {
            cheater = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cheater mode enabled!!!");
            break;
        }
}

int secretNumber = new Random().Next(1, 101);
Console.WriteLine("Guess a secret number:");
while (attempts > 0 || cheater)
{
    attempts--;
    int guessedNumber = int.Parse(Console.ReadLine());

    string highOrLow = (guessedNumber > secretNumber)
    ? "Too high" : "Too low";

    string onWrong = (attempts != 0)
        ? $"{highOrLow}... You have {(cheater ? "*" : attempts)} tries left."
        : $"All out of tries.\nThe secret number was {secretNumber}";

    bool correct = (guessedNumber == secretNumber);

    string result = (correct) ? "You guessed the secret number!!" : onWrong;
    Console.WriteLine(result);

    if (correct)
        break;
}
