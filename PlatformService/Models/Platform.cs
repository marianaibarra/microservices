using System.ComponentModel.DataAnnotations;

namespace PlatformService.Models;

public class Platform
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public string? NamePlatform { get; set; }
    [Required]
    public string? Publisher { get; set; }
    [Required]
    public decimal Cost { get; set; }
}
