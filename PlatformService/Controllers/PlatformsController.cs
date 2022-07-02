using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.DTO;
using PlatformService.Models;
using PlatformService.Services;

namespace PlatformService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlatformsController : ControllerBase
{
    private readonly IPlatformService _service;
    private readonly IMapper _mapper;

    public PlatformsController(IPlatformService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }
    [HttpGet]
    public ActionResult<IEnumerable<PlatformReadDTO>> GetPlatforms()
    {
        var platforms = _service.GetPlatforms();
        return Ok(_mapper.Map<IEnumerable<PlatformReadDTO>>(platforms));
    }
    [HttpGet("{id}", Name = "GetOnePlatform")]
    public ActionResult<PlatformReadDTO> GetOnePlatform(int id)
    {
        var platform = _service.GetPlatform(id);
        if (platform == null) return NotFound();
        return Ok(_mapper.Map<PlatformReadDTO>(platform));
    }
    [HttpPost]
    public ActionResult<PlatformReadDTO> CreatePlatform(PlatformCreateDTO platform)
    {
        var platformModel = _mapper.Map<Platform>(platform);
        _service.PostPlatform(platformModel);

        var platformRead = _mapper.Map<PlatformReadDTO>(platformModel);
        return CreatedAtRoute(nameof(GetOnePlatform), new { Id = platformRead.Id }, platformRead);
    }
}