using AutoMapper;
using PlatformService.Models;
using PlatformService.DTO;
namespace PlatformService.Profiles;

public class PlatformsProfile : Profile
{
    public PlatformsProfile()
    {
        CreateMap<Platform, PlatformReadDTO>();
        CreateMap<PlatformCreateDTO, Platform>();
    }
}