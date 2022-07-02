using System.ComponentModel.DataAnnotations;

namespace PlatformService.DTO;

public class PlatformCreateDTO
{
    [Required]
    public string? NamePlatform { get; set; }
    [Required]
    public string? Publisher { get; set; }
    [Required]
    public decimal Cost { get; set; }
}