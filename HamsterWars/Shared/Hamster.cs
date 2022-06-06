using System.ComponentModel.DataAnnotations;

namespace HamsterWars.Shared;

public class Hamster
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(10)]
    public string Name { get; set; } = string.Empty;
    [Required]
    [Range(1, 3)]
    public int Age { get; set; }
    [Required]
    public string FavouriteFood { get; set; } = string.Empty;
    [Required]
    public string Loves { get; set; } = string.Empty;
    public string ImageName { get; set; } = string.Empty;
    public int Wins { get; set; } = 0;
    public int Losses { get; set; } = 0;
    public int Games { get; set; } = 0;

}
