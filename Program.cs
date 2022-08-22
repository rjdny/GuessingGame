using System;

Console.Write("Guess a secret number:");
int guessedNumber = int.Parse(Console.ReadLine());
int secretNumber = 42;
string result = (guessedNumber == secretNumber) 
? "You guessed the secret number!!" : "Try again...";
Console.WriteLine(result);