using System.ComponentModel.DataAnnotations.Schema;

namespace comparetool.Models;

public class Item : EntityBase
{
    public string Name { get; set; } = null!;

    [ForeignKey(nameof(Category))]
    public string? CategoryId { get; set; }
    public Category? Category { get; set; }
}
