﻿namespace EshopModulith.Catalog.Data.Seed;
public class CatalogDataSeeder(CatalogDbContext dbContext)
    : IDataSeeder
{
    public async Task SeedAllAsync()
    {
        if (!await dbContext.Products.AnyAsync())
        {
            dbContext.Products.AddRange(InitialData.Products);
            await dbContext.SaveChangesAsync();
        }
    }
}
