namespace EshopModulith.Catalog.Products.Models;
public class Product : Agregate<Guid>
{
    public string Name { get; private set; } = default!;

    public List<string> Category { get; private set; } = new();

    public string Description { get; private set; } = default!;

    public string ImageFile { get; private set; } = default!;

    public decimal Price { get; private set; }

    public static Product Create(Guid id, string name, string description, List<string> category, decimal price, string imageFile)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price, nameof(price));

        Product product = new Product
        {
            Id = id,
            Name = name,
            Description = description,
            Category = category,
            Price = price,
            ImageFile = imageFile
        };
        
        product.AddDomainEvent(new ProductCreatedEvent(product));

        return product;
    }

    public void Update(string name, string description, List<string> category, decimal price, string imageFile)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price, nameof(price));
        
        Name = name;
        Category = category;
        Description = description;
        ImageFile = imageFile;

        if (price != Price)
        {
            Price = price;
            AddDomainEvent(new ProductPriceChangedEvent(this));
        }
    }
}
