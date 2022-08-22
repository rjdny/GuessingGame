using System;


Console.WriteLine("Choose a difficulty level");
Console.WriteLine("(E)asy, (M)edium, or(H)ard.");

string difficulty = Console.ReadLine().ToLower();
int attempts = 0;

switch (difficulty)
{
    case "e":{ attempts = 8; break; }
    case "m":{ attempts = 6; break; }
    case "h":{ attempts = 4; break; }
}

int secretNumber = new Random().Next(1,101);
Console.WriteLine("Guess a secret number:");
while (attempts > 0)
{
    attempts--;
    int guessedNumber = int.Parse(Console.ReadLine());

    string highOrLow = (guessedNumber > secretNumber)
    ? "Too high" : "Too low";

    string onWrong = (attempts != 0) 
        ? $"{highOrLow}... You have {attempts} tries left." 
        : $"All out of tries.\nThe secret number was {secretNumber}";

    bool correct = (guessedNumber == secretNumber);

    string result = (correct)? "You guessed the secret number!!" : onWrong;
    Console.WriteLine(result);

    if (correct)
        break;
}
