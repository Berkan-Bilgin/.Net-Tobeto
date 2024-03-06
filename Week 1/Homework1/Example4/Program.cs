/*Kullanıcının 1 ile 10 arasında rastgele bir sayıyı tahmin etmesini isteyen 
ve doğru tahmin edene kadar devam eden bir program yazınız.*/

Random random = new Random();

int randomNumber = random.Next(1, 11);

Console.WriteLine("Guess the number between 1 and 10");

int guess = 0;

int counter = 0;


do
{
    Console.Write("Your Guess: ...");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out guess))
    {
        Console.WriteLine("Please enter a valid number ");
        continue;
    }

    if (guess < randomNumber)
    {
        Console.WriteLine("Increase the guess");
    }
    else if (guess > randomNumber)
    {
        Console.WriteLine("Decrease the guess");
    }
    else
    {
        Console.WriteLine("Congratulations!...");
    }
    counter++;
} while (guess != randomNumber);

Console.WriteLine($"Random number: {randomNumber}, Your Guess: {guess}");
Console.WriteLine($"You guessed it after {counter} tries");