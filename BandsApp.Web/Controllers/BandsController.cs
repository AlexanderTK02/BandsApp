using BandsApp.Web.Services;
using BandsApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BandsApp.Web.Controllers;

public class BandsController : Controller
{
    BandService bandService = new BandService();

    [Route("")]
    public IActionResult Index()
    {
        Band[] bands = bandService.GetAll();
        return View(bands);
    }

    [Route("bands/{id}")]
    public IActionResult Details(int id)
    {
        return View(bandService.GetBandById(id));
    }
}
