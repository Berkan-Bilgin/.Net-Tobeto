//Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.

int counter = 6;

while (counter <= 5)
{
    Console.WriteLine($"While loop: counter {counter}");
    counter++;
}

int counter1 = 6;
do
{
    Console.WriteLine($"Do - While loop: Counter: {counter1}");
    counter1++;
} while (counter1 <= 5);