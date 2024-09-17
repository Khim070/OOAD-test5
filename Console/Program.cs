using productlib;

namespace ProductConsole;

class Program
{
    static void Main(string[] args)
    {
        var req = new ProductCreateReq()
        {
            Code = "P001",
            Name = "Coca drink",
            Category = Category.Drink.ToString(),
        };
        Console.WriteLine("A new product was requested to create");
        Console.WriteLine($"\t+Code is: {req.Code}");
        Console.WriteLine($"\t+Name is: {req.Name}");
        Console.WriteLine($"\t+Category is: {req.Category}");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

        var category = Category.None;
        Category.TryParse(req.Category, out category);
        var prd = new Product()
        {
            Id = Guid.NewGuid().ToString(),
            Code = req.Code,
            Name = req.Name,
            Category = category,
            Created = DateTime.Now,
            LastUpdated = null
        };
        Console.WriteLine("\nSuccessfully created a product");
        Console.WriteLine($"\t+Id is: {prd.Id}");
        Console.WriteLine($"\t+Code is: {prd.Code}");
        Console.WriteLine($"\t+Name is: {prd.Name}");
        Console.WriteLine($"\t+Category is: {prd.Category}");
        Console.WriteLine($"\t+Created is: {prd.Created}");
        Console.WriteLine($"\tLastUpdated is: {prd.LastUpdated}");
        Console.WriteLine("Press any key to continue... ");
        Console.ReadKey();

        var res = new ProductResponse()
        {
            Id = prd.Id,
            Code = prd.Code,
            Name = prd.Name,
            Category = prd.Category.ToString(),
        };
        Console.WriteLine("\nSuccessfully response a product");
        Console.WriteLine($"\t+Id is: {res.Id}");
        Console.WriteLine($"\t+Code is: {res.Code}");
        Console.WriteLine($"\t+Name is: {res.Name}");
        Console.WriteLine($"\t+Category is: {res.Category}");
        Console.WriteLine("Press any key to continue... ");
        Console.ReadKey();
    }
}
