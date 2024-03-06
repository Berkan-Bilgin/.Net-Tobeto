/*String metotlarını araştırınız. Her bir metot için örnek yapınız.*/


string example = "Hello, World!";

Console.WriteLine($"Length => {example.Length}");
Console.WriteLine($"Substring => {example.Substring(7)}");
Console.WriteLine($"Replace => {example.Replace("World", "Berkan")}");
Console.WriteLine($"ToLower => {example.ToLower()}");
Console.WriteLine($"ToUpper => {example.ToUpper()}");
Console.WriteLine($"IndexOf => {example.IndexOf('o')}");
Console.WriteLine($"LastIndexOf => {example.LastIndexOf('o')}");
Console.WriteLine($"StartsWith => {example.StartsWith("Hello")}");
Console.WriteLine($"EndsWith => {example.EndsWith("World!")}");
Console.WriteLine($"Contains => {example.Contains("Wor")}");
Console.WriteLine($"Insert => {example.Insert(7, "Old ")}");
Console.WriteLine($"Remove => {example.Remove(5)}");


string example1 = " Hello, World! ";

Console.WriteLine($"Trim => {example1.Trim()}");
Console.WriteLine($"Trim => {example1.TrimStart()}");
Console.WriteLine($"Trim => {example1.TrimEnd()}");

