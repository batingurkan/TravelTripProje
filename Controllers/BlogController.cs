using Microsoft.AspNetCore.Mvc;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Controllers
{
	public class BlogController : Controller
	{
		Context c = new Context();
		public IActionResult Index()
		{
			var by = new BlogYorum();
			// var bloglar = c.Blogs.ToList();
			by.Deger1 = c.Blogs.ToList();
			by.Deger3 = c.Blogs.Take(3).ToList();
            by.Deger4 = c.Yorumlars.ToList();

            return View(by);

		}

		public IActionResult BlogDetay(int id)
		{
			var by = new BlogYorum();
			// var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
			by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
			by.Deger2 = c.Yorumlars.Where(x => x.Blodid == id).ToList();
			by.Deger4 = c.Yorumlars.ToList();
            return View(by);
		}
		[HttpGet]
		public PartialViewResult YorumYap(int id)
		{
			ViewBag.deger = id;
            return PartialView();
		}

		[HttpPost]
		public PartialViewResult YorumYap(Yorumlar y)
		{
            
            c.Yorumlars.Add(y);
			c.SaveChanges();
			return PartialView();
		}
    }
}
