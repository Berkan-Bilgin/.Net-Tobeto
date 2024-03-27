// See https://aka.ms/new-console-template for more information
using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;

Console.WriteLine("Hello, World!");


ProductManager productManager = new ProductManager(new EfProductDal());

foreach (var p in productManager.GetByUnitPrice(20, 100))
{
    Console.WriteLine(p.ProductName);
}