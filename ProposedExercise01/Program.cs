using ProposedExercise01.Entities;

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

List<Product> list  = new List<Product>();



for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    char ch = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());

    if(ch == 'c')
    {
        list.Add(new Product(name, price));
    }

    if (ch == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        list.Add(new UsedProduct(name, price, date));
    }

    if (ch == 'i')
    {
        Console.Write("Customs fee: ");
        double custom = double.Parse(Console.ReadLine());
        list.Add(new ImportedProduct(name, price, custom));
    }
}

Console.WriteLine("\nPRICE TAGS:");
foreach(Product product in list)
{
    Console.WriteLine(product.PriceTag());
}