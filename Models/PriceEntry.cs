using System.ComponentModel.DataAnnotations.Schema;

namespace comparetool.Models;

public class PriceEntry : EntityBase
{
    [ForeignKey(nameof(ItemVariant))]
    public string ItemVariantId { get; set; } = null!;
    public ItemVariant ItemVariant { get; set; } = null!;

    [ForeignKey(nameof(StoreLocation))]
    public string StoreLocationId { get; set; } = null!;
    public StoreLocation StoreLocation { get; set; } = null!;

    public decimal Price { get; set; }
    public DateTime DateRecorded { get; set;  }
}
