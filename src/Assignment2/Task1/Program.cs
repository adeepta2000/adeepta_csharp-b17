using Task1;

Product product1 = new Product();

Product product2 = new Product("Pen", 10.00);

Product product3 = new Product("4B Pencil", 20.00, "Latest 4B Pencil", "Black");

Console.WriteLine(product1.Name);
Console.WriteLine(product1.Price);
Console.WriteLine(product1.Description);
Console.WriteLine(product1.Color);

Console.WriteLine("--------------------");

Console.WriteLine(product2.Name);
Console.WriteLine(product2.Price);
Console.WriteLine(product2.Description);
Console.WriteLine(product2.Color);

Console.WriteLine("--------------------");

Console.WriteLine(product3.Name);
Console.WriteLine(product3.Price);
Console.WriteLine(product3.Description);
Console.WriteLine(product3.Color);
