namespace Catalog.Products.Models;

public class Product : Entity<Guid>
{
    public string Name { get; private set; } = default!;
    public List<string> Category { get; private set; } = new();
    public string Description { get; private set; } = default!;
    public decimal Price { get; private set; }
    public string ImageFile { get; private set; } = default!;

    // Create method to initialize a new product
    public static Product Create(Guid id, string name, List<string> category, string description, decimal price, string imageFile)
    {
        ValidateNameAndPrice(name, price);

        return new Product
        {
            Id = id,
            Name = name,
            Category = category,
            Description = description,
            Price = price,
            ImageFile = imageFile
        };
    }

    // Update method for modifying product details
    public void Update(string name, List<string> category, string description, decimal price, string imageFile)
    {
        ValidateNameAndPrice(name, price);

        Name = name;
        Category = category;
        Description = description;
        Price = price;
        ImageFile = imageFile;

        // TODO: if price has changed, raise a ProductPriceChanged domain event
    }

    private static void ValidateNameAndPrice(string name, decimal price)
    {
        ArgumentException.ThrowIfNullOrEmpty(name, nameof(name));
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price, nameof(price));
    }
}