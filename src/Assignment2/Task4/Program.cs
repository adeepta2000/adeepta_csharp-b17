// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Task4;

Admin admin = new Admin("a", "b", "c");
admin.GenerateId("AD-");
Console.WriteLine(admin.Id);