using PlatformService.Models;

namespace PlatformService.Services;
public interface IPlatformService
{
    string DeletePlatform(int id);
    Platform GetPlatform(int id);
    IEnumerable<Platform> GetPlatforms();
    void PostPlatform(Platform platform);
    string PutPlatform(Platform platform);
}