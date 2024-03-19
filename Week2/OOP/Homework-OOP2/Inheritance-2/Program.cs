// See https://aka.ms/new-console-template for more information


List<MediaItem> libraryItems = new List<MediaItem>
{
    new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", PageCount = 180, Publisher = "Charles Scribner's Sons", YearPublished = 1925 },
    new Magazine { Title = "National Geographic", IssueNumber = 1, Publisher = "National Geographic Society", YearPublished = 1888 },
    new DVD { Title = "Inception", RuntimeInMinutes = 148, Publisher = "Warner Bros. Pictures", YearPublished = 2010 }
};

foreach (var item in libraryItems)
{
    item.Display();
    Console.WriteLine(); // Boş satır için
}
public abstract class MediaItem
{
    public string Title { get; set; }
    public string Publisher { get; set; }
    public int YearPublished { get; set; }


    public virtual void Display()
    {
        Console.WriteLine($"Title: {Title}, Published by: {Publisher}, Year: {YearPublished}");
    }
}


public class Book : MediaItem
{
    public string Author { get; set; }
    public int PageCount { get; set; }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Author: {Author}, Pages: {PageCount}");
    }
}


public class Magazine : MediaItem
{
    public int IssueNumber { get; set; }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Issue Number: {IssueNumber}");
    }
}


public class DVD : MediaItem
{
    public int RuntimeInMinutes { get; set; }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Runtime: {RuntimeInMinutes} minutes");
    }
}

