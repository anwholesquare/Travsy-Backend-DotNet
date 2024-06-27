using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Travsy_Backend_DotNet.Models;

namespace Travsy_Backend_DotNet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public String Index()
    {
        return "{\"name\": \"Travsy AI!\"}";
    }


    public String Public()
    {
        return "{\"name\": \"Travsy AI!\"}";
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
