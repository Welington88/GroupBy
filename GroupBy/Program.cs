// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using GroupBy;

/*class Product
{
    
}*/

// Aqui está uma coleção de produtos
var products = new List<Product>
{
    new Product { Name = "Apple", Category = "Fruit", Price = 1.99 },
    new Product { Name = "Banana", Category = "Fruit", Price = 0.99 },
    new Product { Name = "Carrot", Category = "Vegetable", Price = 1.49 },
    new Product { Name = "Eggplant", Category = "Vegetable", Price = 2.99 },
    new Product { Name = "Steak", Category = "Meat", Price = 9.99 },
    new Product { Name = "Salmon", Category = "Fish", Price = 12.99 }
};

// Agrupando os produtos por categoria
var groupedProducts = products.GroupBy(p => p.Category);

foreach (var group in groupedProducts)
{
    Console.WriteLine($"Categoria: {group.Key}");

    foreach (var product in group)
    {
        Console.WriteLine($"    {product.Name}, Preço: {product.Price:C}");
    }
}


