using PlatformService.Models;

namespace PlatformService.Services;

public class PlatformsService : IPlatformService
{
    private readonly List<Platform> _platforms = new();
    public PlatformsService()
    {
        _platforms.Add(
            new Platform
            {
                Id = 1,
                NamePlatform = "Loona Flip That mini albúm",
                Publisher = "sh*tty BBC",
                Cost = 26.95m
            });
        _platforms.Add(
        new Platform
        {
            Id = 2,
            NamePlatform = "KEP1ER(GIRLS PLANET 999) [ FIRST IMPACT ] 1st Mini Album.",
            Publisher = "Idunno... maybe mbc?",
            Cost = 29.55m
        });
        _platforms.Add(
        new Platform
        {
            Id = 3,
            NamePlatform = "IM NAYEON 1st Mini Album",
            Publisher = "Papi JYP",
            Cost = 24.90m
        });
    }
    public Platform GetPlatform(int id)
    {
        return _platforms.Find(x => x.Id == id);
    }
    public IEnumerable<Platform> GetPlatforms()
    {
        return _platforms;
    }
    public void PostPlatform(Platform platform)
    {
        _platforms.Add(platform);
    }
    public string PutPlatform(Platform platform)
    {
        return $"Updated platform with id {platform.Id}";
    }
    public string DeletePlatform(int id)
    {
        return "deleted";
    }
}