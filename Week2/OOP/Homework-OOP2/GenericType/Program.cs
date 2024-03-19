// See https://aka.ms/new-console-template for more information
using GenericType;

Console.WriteLine("Hello, World!");

var intList = new GenericList<int>(4);

intList.Add(1);
intList.Add(2);
intList.Add(3);

Console.WriteLine(intList.GetItemAt(0));
Console.WriteLine(intList.GetItemAt(1));
Console.WriteLine(intList.GetItemAt(2));

var stringList = new GenericList<string>(5);
stringList.Add("elma");
stringList.Add("armut");
stringList.Add("muz");

Console.WriteLine(stringList.GetItemAt(0));
Console.WriteLine(stringList.GetItemAt(1));
Console.WriteLine(stringList.GetItemAt(2));

var personList = new GenericList<Person>(5);
personList.Add(new Person("Alice", 30));
personList.Add(new Person("Bob", 25));
personList.Add(new Person("Charlie", 35));

Console.WriteLine(personList.GetItemAt(0));
Console.WriteLine(personList.GetItemAt(1));
Console.WriteLine(personList.GetItemAt(2));

public class GenericList<T>
{
    private T[] items;
    private int count;

    public GenericList(int initialCapacity)
    {
        items = new T[initialCapacity];

    }
    public void Add(T item)
    {
        items[count] = item;
        count++;
    }
    public T GetItemAt(int index)
    {
        return items[index];
    }
}