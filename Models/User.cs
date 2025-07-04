namespace comparetool.Models;

public class User : IdentityUser
{
    public List<Category> Categories { get; set; } = [];
    public List<Item> Items { get; set; } = [];
    public List<ItemVariant> ItemVariants { get; set; } = [];
    public List<PriceEntry> PriceEntries { get; set; } = [];
    public List<StoreLocation> StoreLocations { get; set; } = [];    
}