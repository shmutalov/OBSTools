using Microsoft.AspNetCore.Mvc;
using OBSTools.Services;

namespace OBSTools.Controllers;

public class MediaPlayerController : Controller
{
    private readonly IMediaPlayerService _mp;
    public MediaPlayerController(IMediaPlayerService mp)
    {
        _mp = mp;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CurrentSong() => Json(_mp.GetCurrentSong());
}

