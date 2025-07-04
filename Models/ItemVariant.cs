using System.ComponentModel.DataAnnotations.Schema;

namespace comparetool.Models;

public class ItemVariant : EntityBase
{
    [ForeignKey(nameof(Item))]
    public string ItemId { get; set; } = null!;
    public Item Item { get; set; } = null!;

    public string Description { get; set; } = null!;
}
