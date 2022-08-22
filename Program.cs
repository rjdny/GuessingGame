using System;

Console.WriteLine("Guess a secret number:");

int secretNumber = new Random().Next(1,101);

int attempts = 4;

while(attempts > 0)
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