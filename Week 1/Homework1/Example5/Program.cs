// Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.

/*
In number theory, a perfect number is a positive integer that is equal to the sum of its positive divisors,
excluding the number itself. For instance, 6 has divisors 1, 2 and 3 (excluding itself),
and 1 + 2 + 3 = 6, so 6 is a perfect number.*/

Console.WriteLine("Enter a number");
int number = int.Parse(Console.ReadLine());
int total = 0;

for (int i = 1; i < number; i++)
{
    if (number % i == 0)
    {
        total += i;
    }

}

if (total == number)
{
    Console.WriteLine($"{number} is a perfect number.");
}
else
{
    Console.WriteLine($"{number} is not a perfect number.");
}