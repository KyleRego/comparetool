namespace comparetool.Data;

public class AppDbContext : IdentityDbContext<IdentityUser>
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<ItemVariant> ItemVariants { get; set; }
    public DbSet<PriceEntry> PriceEntries { get; set; }
    public DbSet<StoreLocation> StoreLocations { get; set; }
}
