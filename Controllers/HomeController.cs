using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelTripProje.Models;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        var context = new Context();

        var model = new HomeIndexModel();
        model.Bloglar = context.Blogs.Where(x => x.ID == 1).ToList();
        model.AraBloglar = context.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
        model.ListBlog = context.Blogs.Take(10).ToList();
        model.ResmBlog = context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
        model.ResmBlog2 = context.Blogs.OrderByDescending(x => x.ID >= 4).Take(3).ToList();
        model.SayfaninAdi = "Tatil Seyehat Bloğuna Hoşgeldiniz";
        return View(model);
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}