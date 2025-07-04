using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace comparetool.Models;

public abstract class EntityBase
{
    [Key]
    public string Id = Guid.NewGuid().ToString();

    [ForeignKey(nameof(User))]
    public string UserId { get; set; } = null!;
    public User User { get; set; } = null!;
}
