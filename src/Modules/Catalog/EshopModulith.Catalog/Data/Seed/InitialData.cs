namespace EshopModulith.Catalog.Data.Seed;
public static class InitialData
{
    public static IEnumerable<Product> Products =>
        new List<Product>
        {
            Product.Create(new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61"), "IPhone X", "Long description", ["category1"], 500, "imagefile"),
            Product.Create(new Guid("c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914"), "Samsung 10", "Long description", ["category1"], 400, "imagefile"),
            Product.Create(new Guid("4f136e9f-ff8c-4c1f-9a33-d12f689bdab8"), "Huawei Plus", "Long description", ["category2"], 650, "imagefile"),
            Product.Create(new Guid("6ec1297b-ec0a-4aa1-be25-6726e3b51a27"), "Xiaomi Mi", "Long description", ["category2"], 450, "imagefile")
        };
}
