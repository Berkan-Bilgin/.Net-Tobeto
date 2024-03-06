//Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş 
//edildiğini belirleyen algoritma yazınız.Input için Scanner kullanınız.


Console.WriteLine("Order number: ");
string orderNumber = Console.ReadLine();

switch (orderNumber)
{
    case "0":
        Console.WriteLine("Your Order: Book");
        break;
    case "1":
        Console.WriteLine("Your Order: Pen");
        break;
    case "2":
        Console.WriteLine("Your Order: Notebook");
        break;
    case "3":
        Console.WriteLine("Your Order: Eraser");
        break;
    default:
        Console.WriteLine("This product is not in stock.");
        break;
}