// See https://aka.ms/new-console-template for more information
using Invetory;


 void Teste1()
{
    Console.WriteLine("Hello, World!");
    Product product = new Product();
    product.Name = "Teste";
    product.Quantity = 1;

    ListProduct.Product!.Add(product);

    var search = ListProduct.Product.FirstOrDefault();

    Product newProduct = new Product();
    newProduct.Name = "Mouse";
    newProduct.Quantity = 2;

    ListProduct.Product!.Add(newProduct);

    var searchName = ListProduct.Product.FirstOrDefault(x => x.Name == "Mouse");

    foreach (var p in ListProduct.Product)
    {
        Console.WriteLine("Name:" + p.Name);
        Console.WriteLine("Quantity:" + p.Quantity);
    }
}

int? test2(string name)
{
    var product = ListProduct.Product!.FirstOrDefault(x => x.Name == name);

    return product?.Quantity;
}

Teste1();
var r = test2("Mouse");
Console.WriteLine(r);

