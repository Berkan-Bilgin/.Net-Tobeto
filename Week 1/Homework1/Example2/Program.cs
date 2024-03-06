/*kullanıcıdan kaç ürün almak istediğini soran, her ürünün fiyatını alarak toplam 
alışveriş tutarını hesaplayan bir algoritma yazınız.(Input için Scanner ve döngü için for döngüsü kullanınız*/

//todo: check negative values , add different products to cart

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        products.Add(new Product("Kalem", 1.99m));
        products.Add(new Product("Defter", 3.99m));

        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine("{0}.{1} ürün", i + 1, products[i].Name);
        }

        Console.WriteLine("Hello, which product do you want to buy ? ");
        string selectedProduct = Console.ReadLine();
        Console.WriteLine(selectedProduct);

        var product = products.FirstOrDefault(p => p.Name.Equals(selectedProduct, StringComparison.OrdinalIgnoreCase));

        int productNumber = 0;

        if (product != null)
        {
            Console.WriteLine("Enter the product quantity:");
            Console.WriteLine(product.Price);
            if (int.TryParse(Console.ReadLine(), out productNumber))
            {
                decimal productPrice = productNumber * product.Price;
                Console.WriteLine($"Total price for {productNumber} units of {product.Name} is: {productPrice}");
            }

        }
        else
        {
            Console.WriteLine("Sorry,This product is not in stock. ");
        }
    }
}

